using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using PcPdx.Models;

namespace PcPdx.Migrations
{
    [DbContext(typeof(PcPdxContext))]
    [Migration("20160422161748_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PcPdx.Models.Show", b =>
                {
                    b.Property<int>("ShowId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ShowTitle");

                    b.Property<int>("UserId");

                    b.HasKey("ShowId");

                    b.HasAnnotation("Relational:TableName", "Shows");
                });

            modelBuilder.Entity("PcPdx.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("UserName");

                    b.HasKey("UserId");

                    b.HasAnnotation("Relational:TableName", "Users");
                });

            modelBuilder.Entity("PcPdx.Models.Show", b =>
                {
                    b.HasOne("PcPdx.Models.User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });
        }
    }
}
