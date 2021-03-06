﻿// <auto-generated />
using JayAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace JayAPI.Migrations
{
    [DbContext(typeof(JayContexto))]
    [Migration("20180602011216_JayMigration")]
    partial class JayMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026");

            modelBuilder.Entity("JayAPI.Models.Cliente", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("cnpj");

                    b.Property<int?>("enderecoCobrancaid");

                    b.Property<int?>("enderecoEntregaid");

                    b.Property<int?>("enderecoid");

                    b.Property<string>("ie");

                    b.Property<string>("nomeFantasia");

                    b.Property<bool>("pessoaJuridica");

                    b.Property<string>("razaoSocial");

                    b.HasKey("id");

                    b.HasIndex("enderecoCobrancaid");

                    b.HasIndex("enderecoEntregaid");

                    b.HasIndex("enderecoid");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("JayAPI.Models.Endereco", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("bairro");

                    b.Property<string>("cep");

                    b.Property<string>("cidade");

                    b.Property<string>("endereco");

                    b.Property<string>("numero");

                    b.Property<string>("uf");

                    b.HasKey("id");

                    b.ToTable("Endereco");
                });

            modelBuilder.Entity("JayAPI.Models.Fornecedor", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("cnpj");

                    b.Property<int?>("enderecoCobrancaid");

                    b.Property<int?>("enderecoEntregaid");

                    b.Property<int?>("enderecoid");

                    b.Property<string>("ie");

                    b.Property<string>("nomeFantasia");

                    b.Property<bool>("pessoaJuridica");

                    b.Property<string>("razaoSocial");

                    b.HasKey("id");

                    b.HasIndex("enderecoCobrancaid");

                    b.HasIndex("enderecoEntregaid");

                    b.HasIndex("enderecoid");

                    b.ToTable("Fornecedores");
                });

            modelBuilder.Entity("JayAPI.Models.Cliente", b =>
                {
                    b.HasOne("JayAPI.Models.Endereco", "enderecoCobranca")
                        .WithMany()
                        .HasForeignKey("enderecoCobrancaid");

                    b.HasOne("JayAPI.Models.Endereco", "enderecoEntrega")
                        .WithMany()
                        .HasForeignKey("enderecoEntregaid");

                    b.HasOne("JayAPI.Models.Endereco", "endereco")
                        .WithMany()
                        .HasForeignKey("enderecoid");
                });

            modelBuilder.Entity("JayAPI.Models.Fornecedor", b =>
                {
                    b.HasOne("JayAPI.Models.Endereco", "enderecoCobranca")
                        .WithMany()
                        .HasForeignKey("enderecoCobrancaid");

                    b.HasOne("JayAPI.Models.Endereco", "enderecoEntrega")
                        .WithMany()
                        .HasForeignKey("enderecoEntregaid");

                    b.HasOne("JayAPI.Models.Endereco", "endereco")
                        .WithMany()
                        .HasForeignKey("enderecoid");
                });
#pragma warning restore 612, 618
        }
    }
}
