﻿

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace CuoiKi
{

using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

using System.Data.Entity.Core.Objects;
using System.Linq;


public partial class ManagementDFContext : DbContext
{
    public ManagementDFContext()
        : base("name=ManagementDFContext")
    {

    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        throw new UnintentionalCodeFirstException();
    }


    public virtual DbSet<Account> Accounts { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<Item> Items { get; set; }

    public virtual DbSet<Lineitem> Lineitems { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<Voucher> Vouchers { get; set; }


    [DbFunction("ManagementDFContext", "Doanhthu_thang")]
    public virtual IQueryable<Doanhthu_thang_Result> Doanhthu_thang(Nullable<int> year)
    {

        var yearParameter = year.HasValue ?
            new ObjectParameter("year", year) :
            new ObjectParameter("year", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<Doanhthu_thang_Result>("[ManagementDFContext].[Doanhthu_thang](@year)", yearParameter);
    }


    [DbFunction("ManagementDFContext", "Doanhthu_thang1")]
    public virtual IQueryable<Doanhthu_thang1_Result> Doanhthu_thang1(Nullable<int> year)
    {

        var yearParameter = year.HasValue ?
            new ObjectParameter("year", year) :
            new ObjectParameter("year", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<Doanhthu_thang1_Result>("[ManagementDFContext].[Doanhthu_thang1](@year)", yearParameter);
    }


    [DbFunction("ManagementDFContext", "Doanhthu_thang2")]
    public virtual IQueryable<Doanhthu_thang2_Result> Doanhthu_thang2(Nullable<int> year)
    {

        var yearParameter = year.HasValue ?
            new ObjectParameter("year", year) :
            new ObjectParameter("year", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<Doanhthu_thang2_Result>("[ManagementDFContext].[Doanhthu_thang2](@year)", yearParameter);
    }

}

}

