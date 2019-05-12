﻿// <auto-generated />
using System;
using DotnetGraphQL.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DotnetGraphQL.Data.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20190512171829_ReInit")]
    partial class ReInit
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DotnetGraphQL.Core.Entities.Assignment", b =>
                {
                    b.Property<int>("EmployeeId");

                    b.Property<int>("TaskId");

                    b.HasKey("EmployeeId", "TaskId");

                    b.HasIndex("TaskId");

                    b.ToTable("Assignments");
                });

            modelBuilder.Entity("DotnetGraphQL.Core.Entities.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DeptName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("DotnetGraphQL.Core.Entities.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("DepartmentId");

                    b.Property<DateTime>("Dob");

                    b.Property<string>("EmpName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("Salary");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("DotnetGraphQL.Core.Entities.Task", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TaskName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Tasks");
                });

            modelBuilder.Entity("DotnetGraphQL.Core.Entities.Assignment", b =>
                {
                    b.HasOne("DotnetGraphQL.Core.Entities.Employee", "Employee")
                        .WithMany("Assignments")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DotnetGraphQL.Core.Entities.Task", "AssignedTask")
                        .WithMany("Assignments")
                        .HasForeignKey("TaskId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DotnetGraphQL.Core.Entities.Employee", b =>
                {
                    b.HasOne("DotnetGraphQL.Core.Entities.Department", "Department")
                        .WithMany("Employees")
                        .HasForeignKey("DepartmentId");
                });
#pragma warning restore 612, 618
        }
    }
}
