﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OSharp.Entity;

#nullable disable

namespace Liuliu.Demo.Web.Migrations.TenantDb
{
    [DbContext(typeof(TenantDbContext))]
    partial class TenantDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.2")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Liuliu.Demo.MultiTenancy.Entities.Tenant", b =>
                {
                    b.Property<long>("Id")
                        .HasColumnType("bigint")
                        .HasComment("编号");

                    b.Property<string>("ConnectionString")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)")
                        .HasComment("连接字符串");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime2")
                        .HasComment("创建时间");

                    b.Property<string>("CustomJson")
                        .HasColumnType("nvarchar(max)")
                        .HasComment("自定义配置数据");

                    b.Property<DateTime?>("DeletedTime")
                        .HasColumnType("datetime2")
                        .HasComment("DeletedTime");

                    b.Property<DateTime?>("ExpireDate")
                        .HasColumnType("datetime2")
                        .HasComment("到期时间");

                    b.Property<string>("Host")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasComment("租户主机");

                    b.Property<bool>("IsEnabled")
                        .HasColumnType("bit")
                        .HasComment("是否启用");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasComment("租户名称");

                    b.Property<string>("ShortName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasComment("租户简称");

                    b.Property<string>("TenantKey")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasComment("租户标识");

                    b.Property<DateTime?>("UpdatedTime")
                        .HasColumnType("datetime2")
                        .HasComment("更新时间");

                    b.HasKey("Id");

                    b.ToTable("MultiTenancy_Tenant", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
