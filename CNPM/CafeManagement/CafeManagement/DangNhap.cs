﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
using DAL;

namespace CafeManagement
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();

        }

        private void checkShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkShowPass.Checked)
            {
                txtPassword.PasswordChar = (char)0;
            }
            else
            {
                txtPassword.PasswordChar = Convert.ToChar("*");
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn thoát ?","Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(dialogResult == DialogResult.Yes)
            {
                this.Close();
            }    
        }
        public bool Kiemtra()
        {
            if(txtUser.Text.Length == 0)
            {

                MessageBox.Show("Vui lòng nhập tên tài khoản !!", "Lỗi");
                txtUser.Focus();
                return false;
            }    
            else if (txtPassword.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập mật khẩu !!", "Lỗi");
                txtPassword.Focus();
                return false;
            }
            return true;
        }

        private void ClearBox()
        {
            txtUser.Clear();
            txtPassword.Clear();
            rdoNhanVien.Checked = false;
            rdoQuanLy.Checked = false;
            checkShowPass.Checked = false;
        }

        private void LoiDangNhap()
        {
            MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!!", "Lỗi");
            txtUser.Clear();
            txtPassword.Clear();
        }
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = Convert.ToChar("*");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DB_DangNhap db = new DB_DangNhap();
            if (rdoQuanLy.Checked == true)
            {
                DataTable dt = db.KiemTraTaiKhoanHopLe(txtUser.Text, txtPassword.Text);
                if (Kiemtra() && dt.Rows.Count >= 1)
                {
                    if (dt.Rows[0][2].ToString() == "Quản lý")
                    {
                        ChucNangQuanLy chucNangQuanLy = new ChucNangQuanLy();
                        chucNangQuanLy.Show();
                    }
                    else
                    {
                        LoiDangNhap();
                    }

                }
                else
                {
                    LoiDangNhap();
                }
            }
            else if (rdoNhanVien.Checked == true)
            {
                DataTable dt = db.KiemTraTaiKhoanHopLe(txtUser.Text, txtPassword.Text);
                if (Kiemtra() && dt.Rows.Count >= 1)
                {
                    if (dt.Rows[0][2].ToString() != "Quản lý")
                    {
                        DataTable NhanVien = db.GetNhanVien(txtUser.Text, txtPassword.Text);
                        SaleOrder saleOrder = new SaleOrder(NhanVien.Rows[0][0].ToString(),NhanVien.Rows[0][1].ToString());
                        saleOrder.Show();
                    }
                    else
                    {
                        LoiDangNhap();
                    }

                }
                else
                {
                    LoiDangNhap();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn chức vụ để đăng nhập!!", "Thông báo");
            }
            ClearBox();
        }
    }
}
