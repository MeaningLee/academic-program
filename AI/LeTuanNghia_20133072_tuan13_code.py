#%%
import gym 
import numpy as np

import torch 
import torch.nn as nn
import torch.optim as optim 
import time 
from collections import namedtuple


model = 3
if model == 1:
    HIDDEN_SIZE = 128
    BATCH_SIZE = 16
    PERCENTILE = 70

if model == 2:
    HIDDEN_SIZE = 50
    BATCH_SIZE = 10
    PERCENTILE = 80    

if model == 3:
    HIDDEN_SIZE = 10
    BATCH_SIZE = 10
    PERCENTILE = 80    

class Net(nn.Module):
    def __init__(self, obs_size, hidden_size, n_actions):
        super().__init__()
        self.net = nn.Sequential(
            nn.Linear(obs_size, hidden_size),
            nn.ReLU(),
            nn.Linear(hidden_size, n_actions)
            )
    def forward(self, x):
        return self.net(x)

Episode = namedtuple('Episode', field_names = ['reward', 'steps'])
EpisodeStep = namedtuple('EpisodeStep', field_names = ['observation', 'action'])


def get_batches(env, net, batch_size):
    batch = []

    episode_reward = 0.0
    episode_steps = []

    obs = env.reset()
    sm = nn.Softmax(dim=1)
    while True:
        obs_v = torch.FloatTensor([obs])
        act_probs_v = sm(net(obs_v))
        act_probs = act_probs_v.data.numpy()[0]
        action = np.random.choice(len(act_probs), p=act_probs)

        next_obs, reward, is_done, _ = env.step(action)

        episode_reward += reward
        step = EpisodeStep(observation=obs, action=action)
        episode_steps.append(step)
        
        if is_done:
            e = Episode(reward=episode_reward, steps=episode_steps)
            batch.append(e)
            
            episode_reward = 0.0
            episode_steps = []
            next_obs = env.reset()

            if len(batch) == batch_size:
                yield batch
                batch = []
        obs = next_obs

def filter_batch(batch, percentile):
    rewards = list(map(lambda s: s.reward, batch))
    reward_bound = np.percentile(rewards, percentile)
    
    reward_mean = float(np.mean(rewards))

    train_obs = []
    train_act = []
    for reward, steps in batch:
        if reward < reward_bound:
            continue
        train_obs.extend(map(lambda step: step.observation, steps))
        train_act.extend(map(lambda step: step.action, steps))

    train_obs_v = torch.FloatTensor(train_obs)
    train_act_v = torch.LongTensor(train_act)
    return train_obs_v, train_act_v, reward_bound, reward_mean

#%%
if __name__ == "__main__":
    #env = gym.make("CartPole-v1")  
    env = gym.make("LunarLander-v2")  
    
    #train_mode = True
    train_mode = False
    if train_mode:
        obs_size = env.observation_space.shape[0]
        n_actions = env.action_space.n
        net = Net(obs_size, HIDDEN_SIZE, n_actions)
        
        objective = nn.CrossEntropyLoss()
        optimizer = optim.Adam(params=net.parameters(), lr=0.01)
        
        for iter_no, batch in enumerate(get_batches(env, net, BATCH_SIZE)):
            obs_v, acts_v, reward_b, reward_m = filter_batch(batch, PERCENTILE)
            
            optimizer.zero_grad()
            action_scores_v = net(obs_v)
            loss_v = objective(action_scores_v, acts_v)
            loss_v.backward()
            optimizer.step()

            print("%d: loss=%.3f, reward_mean=%.1f, reward_bound=%.1f" % (iter_no, loss_v.item(), reward_m, reward_b))
        
            if reward_m > 499: # for CartPole-v1
                torch.save(net,'trained_net_' + str(HIDDEN_SIZE) + 'neurons.pt') # qNOTE: save ONLY 1 var/file
                print("Solved! Saved the model.")
                break

    else: # use the trained network
        env = gym.wrappers.Monitor(env, directory="solved_cartpole", force=True)
        obs = env.reset()

        #net = torch.load('trained_net_' + str(HIDDEN_SIZE) + 'neurons.pt')
        net = torch.load('trained_net_LunarLander-v2_20neurons.pt')
       
        sm = nn.Softmax(dim=1)
        total_reward = 0
        while True:
            obs_v = torch.FloatTensor([obs])
            act_probs_v = sm(net(obs_v))
            act_probs = act_probs_v.data.numpy()[0]
            action = np.random.choice(len(act_probs), p=act_probs)

            obs, reward, done, _ = env.step(action)
            
            env.render()
            #time.sleep(0.01)
            total_reward += reward

            if done:
                env.close()
                break

        print("Model %d (%d neurons). Total reward: %.2f" % (model, HIDDEN_SIZE, total_reward))



# %%