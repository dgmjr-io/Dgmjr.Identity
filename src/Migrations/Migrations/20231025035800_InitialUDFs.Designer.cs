﻿// <auto-generated />
using System;
using Dgmjr.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Dgmjr.Identity.EntityFrameworkCore.Migrations.Migrations
{
    [DbContext(typeof(IdentityDbContext))]
    [Migration("20231025035800_InitialUDFs")]
    partial class InitialUDFs
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.UseIdentityColumns();
#pragma warning restore 612, 618
        }
    }
}
