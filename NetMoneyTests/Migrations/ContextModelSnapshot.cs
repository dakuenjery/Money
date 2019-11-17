﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NetMoneyTests;

namespace NetMoneyTests.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0");

            modelBuilder.Entity("NetMoneyTests.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("NetMoneyTests.Product", b =>
                {
                    b.OwnsOne("NetMoney.Money", "Price", b1 =>
                        {
                            b1.Property<int>("ProductId")
                                .HasColumnType("INTEGER");

                            b1.Property<decimal>("Amount")
                                .HasColumnName("Price")
                                .HasColumnType("TEXT");

                            b1.HasKey("ProductId");

                            b1.ToTable("Products");

                            b1.WithOwner()
                                .HasForeignKey("ProductId");

                            b1.OwnsOne("NetMoney.Currency", "Currency", b2 =>
                                {
                                    b2.Property<int>("MoneyProductId")
                                        .HasColumnType("INTEGER");

                                    b2.Property<string>("IsoCode")
                                        .IsRequired()
                                        .HasColumnName("Currency")
                                        .HasColumnType("TEXT");

                                    b2.HasKey("MoneyProductId");

                                    b2.ToTable("Products");

                                    b2.WithOwner()
                                        .HasForeignKey("MoneyProductId");
                                });
                        });
                });
#pragma warning restore 612, 618
        }
    }
}