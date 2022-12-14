// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Store_Maintaince_Assignment.DataContext;

namespace Store_Maintaince_Assignment.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Store_Maintaince_Assignment.Model.Bharat_City1", b =>
                {
                    b.Property<int>("CityId1")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("CityName1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("State1StateId1")
                        .HasColumnType("int");

                    b.HasKey("CityId1");

                    b.HasIndex("State1StateId1");

                    b.ToTable("Bharat_City1s");
                });

            modelBuilder.Entity("Store_Maintaince_Assignment.Model.Bharat_City2", b =>
                {
                    b.Property<int>("CityIdd")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("CityName2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("State2StateId1")
                        .HasColumnType("int");

                    b.HasKey("CityIdd");

                    b.HasIndex("State2StateId1");

                    b.ToTable("Bharat_City2s");
                });

            modelBuilder.Entity("Store_Maintaince_Assignment.Model.Bharat_State1", b =>
                {
                    b.Property<int>("StateId1")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("StateName1")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StateId1");

                    b.ToTable("Bharat_State1s");
                });

            modelBuilder.Entity("Store_Maintaince_Assignment.Model.Bharat_State2", b =>
                {
                    b.Property<int>("StateId2")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("StateName2")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StateId2");

                    b.ToTable("Bharat_State2s");
                });

            modelBuilder.Entity("Store_Maintaince_Assignment.Model.Bharat_Store", b =>
                {
                    b.Property<int>("StoreNumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Address1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Address2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CurrentAccountPeroid")
                        .HasColumnType("int");

                    b.Property<DateTime>("CycleBeginDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOfLastArchive")
                        .HasColumnType("datetime2");

                    b.Property<float>("DefaultFinanceCharge")
                        .HasColumnType("real");

                    b.Property<int>("DefaultNumberOfDays")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Ext")
                        .HasColumnType("int");

                    b.Property<int>("Fax")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Phone")
                        .HasColumnType("int");

                    b.Property<int?>("State1StateId1")
                        .HasColumnType("int");

                    b.Property<int?>("State2StateId2")
                        .HasColumnType("int");

                    b.Property<int>("Zip")
                        .HasColumnType("int");

                    b.HasKey("StoreNumber");

                    b.HasIndex("State1StateId1");

                    b.HasIndex("State2StateId2");

                    b.ToTable("Bharat_Stores");
                });

            modelBuilder.Entity("Store_Maintaince_Assignment.Model.Bharat_City1", b =>
                {
                    b.HasOne("Store_Maintaince_Assignment.Model.Bharat_State1", "State1")
                        .WithMany()
                        .HasForeignKey("State1StateId1");

                    b.Navigation("State1");
                });

            modelBuilder.Entity("Store_Maintaince_Assignment.Model.Bharat_City2", b =>
                {
                    b.HasOne("Store_Maintaince_Assignment.Model.Bharat_State1", "State2")
                        .WithMany()
                        .HasForeignKey("State2StateId1");

                    b.Navigation("State2");
                });

            modelBuilder.Entity("Store_Maintaince_Assignment.Model.Bharat_Store", b =>
                {
                    b.HasOne("Store_Maintaince_Assignment.Model.Bharat_State1", "State1")
                        .WithMany()
                        .HasForeignKey("State1StateId1");

                    b.HasOne("Store_Maintaince_Assignment.Model.Bharat_State2", "State2")
                        .WithMany()
                        .HasForeignKey("State2StateId2");

                    b.Navigation("State1");

                    b.Navigation("State2");
                });
#pragma warning restore 612, 618
        }
    }
}
