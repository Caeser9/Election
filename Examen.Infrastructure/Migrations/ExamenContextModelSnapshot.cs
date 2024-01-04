﻿// <auto-generated />
using System;
using Examen.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Examen.Infrastructure.Migrations
{
    [DbContext(typeof(ExamenContext))]
    partial class ExamenContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ElecteurElection", b =>
                {
                    b.Property<int>("ElecteursElecteurId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ElectionsDateElection")
                        .HasColumnType("datetime2");

                    b.HasKey("ElecteursElecteurId", "ElectionsDateElection");

                    b.HasIndex("ElectionsDateElection");

                    b.ToTable("ParticipationElection", (string)null);
                });

            modelBuilder.Entity("Examen.ApplicationCore.Domain.Electeur", b =>
                {
                    b.Property<int>("ElecteurId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ElecteurId"));

                    b.Property<string>("CIN")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<DateTime>("DateNaissance")
                        .HasColumnType("datetime2");

                    b.Property<int>("MonGenre")
                        .HasColumnType("int");

                    b.HasKey("ElecteurId");

                    b.ToTable("Electeurs");
                });

            modelBuilder.Entity("Examen.ApplicationCore.Domain.Election", b =>
                {
                    b.Property<DateTime>("DateElection")
                        .HasColumnType("datetime2");

                    b.Property<int>("MonTypeElection")
                        .HasColumnType("int");

                    b.HasKey("DateElection");

                    b.ToTable("Elections");
                });

            modelBuilder.Entity("Examen.ApplicationCore.Domain.PartiePolitique", b =>
                {
                    b.Property<int>("PartiePolitiqueId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PartiePolitiqueId"));

                    b.Property<DateTime>("DateFondation")
                        .HasColumnType("datetime2");

                    b.Property<string>("Details")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("PartiePolitiqueId");

                    b.ToTable("PartiePolitiques");
                });

            modelBuilder.Entity("Examen.ApplicationCore.Domain.Vote", b =>
                {
                    b.Property<DateTime>("DateElection")
                        .HasColumnType("datetime2");

                    b.Property<int>("PartiePolitiqueId")
                        .HasColumnType("int");

                    b.Property<int>("VoteId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateVote")
                        .HasColumnType("datetime2");

                    b.HasKey("DateElection", "PartiePolitiqueId", "VoteId");

                    b.HasIndex("PartiePolitiqueId");

                    b.ToTable("Votes");
                });

            modelBuilder.Entity("ElecteurElection", b =>
                {
                    b.HasOne("Examen.ApplicationCore.Domain.Electeur", null)
                        .WithMany()
                        .HasForeignKey("ElecteursElecteurId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Examen.ApplicationCore.Domain.Election", null)
                        .WithMany()
                        .HasForeignKey("ElectionsDateElection")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Examen.ApplicationCore.Domain.Electeur", b =>
                {
                    b.OwnsOne("Examen.ApplicationCore.Domain.MonBureauVote", "MonBureauVote", b1 =>
                        {
                            b1.Property<int>("ElecteurId")
                                .HasColumnType("int");

                            b1.Property<string>("Ecole")
                                .IsRequired()
                                .HasMaxLength(250)
                                .HasColumnType("nvarchar(250)");

                            b1.Property<string>("Gouvernerat")
                                .IsRequired()
                                .HasMaxLength(250)
                                .HasColumnType("nvarchar(250)");

                            b1.Property<int>("NumSalle")
                                .HasColumnType("int");

                            b1.Property<string>("Ville")
                                .IsRequired()
                                .HasMaxLength(250)
                                .HasColumnType("nvarchar(250)");

                            b1.HasKey("ElecteurId");

                            b1.ToTable("Electeurs");

                            b1.WithOwner()
                                .HasForeignKey("ElecteurId");
                        });

                    b.Navigation("MonBureauVote")
                        .IsRequired();
                });

            modelBuilder.Entity("Examen.ApplicationCore.Domain.Vote", b =>
                {
                    b.HasOne("Examen.ApplicationCore.Domain.Election", "Election")
                        .WithMany("Votes")
                        .HasForeignKey("DateElection")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Examen.ApplicationCore.Domain.PartiePolitique", "PartiePolitique")
                        .WithMany("Votes")
                        .HasForeignKey("PartiePolitiqueId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.OwnsOne("Examen.ApplicationCore.Domain.MonBureauVote", "MonBureauVote", b1 =>
                        {
                            b1.Property<DateTime>("VoteDateElection")
                                .HasColumnType("datetime2");

                            b1.Property<int>("VotePartiePolitiqueId")
                                .HasColumnType("int");

                            b1.Property<int>("VoteId")
                                .HasColumnType("int");

                            b1.Property<string>("Ecole")
                                .IsRequired()
                                .HasMaxLength(250)
                                .HasColumnType("nvarchar(250)");

                            b1.Property<string>("Gouvernerat")
                                .IsRequired()
                                .HasMaxLength(250)
                                .HasColumnType("nvarchar(250)");

                            b1.Property<int>("NumSalle")
                                .HasColumnType("int");

                            b1.Property<string>("Ville")
                                .IsRequired()
                                .HasMaxLength(250)
                                .HasColumnType("nvarchar(250)");

                            b1.HasKey("VoteDateElection", "VotePartiePolitiqueId", "VoteId");

                            b1.ToTable("Votes");

                            b1.WithOwner()
                                .HasForeignKey("VoteDateElection", "VotePartiePolitiqueId", "VoteId");
                        });

                    b.Navigation("Election");

                    b.Navigation("MonBureauVote")
                        .IsRequired();

                    b.Navigation("PartiePolitique");
                });

            modelBuilder.Entity("Examen.ApplicationCore.Domain.Election", b =>
                {
                    b.Navigation("Votes");
                });

            modelBuilder.Entity("Examen.ApplicationCore.Domain.PartiePolitique", b =>
                {
                    b.Navigation("Votes");
                });
#pragma warning restore 612, 618
        }
    }
}
