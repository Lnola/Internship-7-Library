﻿// <auto-generated />
using System;
using Library.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Library.Data.Migrations
{
    [DbContext(typeof(LibraryContext))]
    [Migration("20190217193430_TotalBooks")]
    partial class TotalBooks
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Library.Data.Entities.Models.Author", b =>
                {
                    b.Property<int>("AuthorId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.HasKey("AuthorId");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("Library.Data.Entities.Models.Book", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BookAuthorAuthorId");

                    b.Property<int?>("BookPublisherPublisherId");

                    b.Property<int>("Genre");

                    b.Property<string>("Name");

                    b.Property<int>("NumberOfPages");

                    b.Property<int>("TotalNumberOfBooks");

                    b.HasKey("BookId");

                    b.HasIndex("BookAuthorAuthorId");

                    b.HasIndex("BookPublisherPublisherId");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("Library.Data.Entities.Models.BookBorrow", b =>
                {
                    b.Property<int>("BookBorrowId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BookId");

                    b.Property<DateTime>("BorrowDate");

                    b.Property<DateTime?>("ReturnDate");

                    b.Property<int>("StudentId");

                    b.HasKey("BookBorrowId");

                    b.HasIndex("BookId");

                    b.HasIndex("StudentId");

                    b.ToTable("BookBorrows");
                });

            modelBuilder.Entity("Library.Data.Entities.Models.Publisher", b =>
                {
                    b.Property<int>("PublisherId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("PublisherId");

                    b.ToTable("Publishers");
                });

            modelBuilder.Entity("Library.Data.Entities.Models.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<string>("FirstName");

                    b.Property<int>("Gender");

                    b.Property<string>("LastName");

                    b.Property<string>("StudentGrade");

                    b.HasKey("StudentId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("Library.Data.Entities.Models.Book", b =>
                {
                    b.HasOne("Library.Data.Entities.Models.Author", "BookAuthor")
                        .WithMany("BooksByAuthor")
                        .HasForeignKey("BookAuthorAuthorId");

                    b.HasOne("Library.Data.Entities.Models.Publisher", "BookPublisher")
                        .WithMany("PublishedBooks")
                        .HasForeignKey("BookPublisherPublisherId");
                });

            modelBuilder.Entity("Library.Data.Entities.Models.BookBorrow", b =>
                {
                    b.HasOne("Library.Data.Entities.Models.Book", "Book")
                        .WithMany("BookBorrows")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Library.Data.Entities.Models.Student", "Student")
                        .WithMany("BookBorrows")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}