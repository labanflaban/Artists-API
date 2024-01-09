﻿// <auto-generated />
using LangateWrapUpDbApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LangateWrapUpDbApi.Migrations
{
    [DbContext(typeof(AudioDbContext))]
    [Migration("20230926124321_addedNullables")]
    partial class addedNullables
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("LangateWrapUpDbApi.Artist", b =>
                {
                    b.Property<string>("idArtist")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("idLabel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("intBornYear")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("intCharted")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("intDiedYear")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("intFormedYear")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("intMembers")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("strArtist")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("strArtistAlternate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("strArtistBanner")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("strArtistClearart")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("strArtistCutout")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("strArtistFanart")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("strArtistFanart2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("strArtistFanart3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("strArtistFanart4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("strArtistLogo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("strArtistStripped")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("strArtistThumb")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("strArtistWideThumb")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("strBiographyCN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("strBiographyDE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("strBiographyEN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("strBiographyES")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("strBiographyFR")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("strBiographyHU")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("strBiographyIL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("strBiographyIT")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("strBiographyJP")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("strBiographyNL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("strBiographyNO")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("strBiographyPL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("strBiographyPT")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("strBiographyRU")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("strBiographySE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("strCountry")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("strCountryCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("strDisbanded")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("strFacebook")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("strGender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("strGenre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("strISNIcode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("strLabel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("strLastFMChart")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("strLocked")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("strMood")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("strMusicBrainzID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("strStyle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("strTwitter")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("strWebsite")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idArtist");

                    b.ToTable("Artists");
                });
#pragma warning restore 612, 618
        }
    }
}
