﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NewsWebsite.Data;

namespace NewsWebsite.Data.Migrations
{
    [DbContext(typeof(NewsDBContext))]
    partial class NewsDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("NewsWebsite.Entities.Bookmark", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("NewsId");

                    b.HasKey("UserId", "NewsId");

                    b.HasIndex("NewsId");

                    b.ToTable("Bookmarks");
                });

            modelBuilder.Entity("NewsWebsite.Entities.Category", b =>
                {
                    b.Property<string>("CategoryId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CategoryName");

                    b.Property<string>("ParentCategoryId");

                    b.Property<string>("Url");

                    b.HasKey("CategoryId");

                    b.HasIndex("ParentCategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("NewsWebsite.Entities.Comment", b =>
                {
                    b.Property<string>("CommentId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Desription");

                    b.Property<string>("Email");

                    b.Property<bool>("IsConfirm");

                    b.Property<string>("Name");

                    b.Property<string>("NewsId");

                    b.Property<string>("ParentCommentId");

                    b.Property<DateTime?>("PostageDateTime");

                    b.HasKey("CommentId");

                    b.HasIndex("NewsId");

                    b.HasIndex("ParentCommentId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("NewsWebsite.Entities.Like", b =>
                {
                    b.Property<string>("NewsId");

                    b.Property<string>("IpAddress");

                    b.Property<bool>("IsLiked");

                    b.HasKey("NewsId", "IpAddress");

                    b.ToTable("Likes");
                });

            modelBuilder.Entity("NewsWebsite.Entities.News", b =>
                {
                    b.Property<string>("NewsId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("ImageName");

                    b.Property<bool>("IsInternal");

                    b.Property<bool>("IsPublish");

                    b.Property<DateTime?>("PublishDateTime")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("CONVERT(datetime,GetDate())");

                    b.Property<string>("Title");

                    b.Property<string>("Url");

                    b.Property<string>("UserId");

                    b.HasKey("NewsId");

                    b.HasIndex("UserId");

                    b.ToTable("News");
                });

            modelBuilder.Entity("NewsWebsite.Entities.NewsCategory", b =>
                {
                    b.Property<string>("CategoryId");

                    b.Property<string>("NewsId");

                    b.HasKey("CategoryId", "NewsId");

                    b.HasIndex("NewsId");

                    b.ToTable("NewsCategories");
                });

            modelBuilder.Entity("NewsWebsite.Entities.NewsImage", b =>
                {
                    b.Property<string>("NewsImageId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ImageName");

                    b.Property<string>("NewsId");

                    b.HasKey("NewsImageId");

                    b.HasIndex("NewsId");

                    b.ToTable("NewsImages");
                });

            modelBuilder.Entity("NewsWebsite.Entities.NewsTag", b =>
                {
                    b.Property<string>("TagId");

                    b.Property<string>("NewsId");

                    b.HasKey("TagId", "NewsId");

                    b.HasIndex("NewsId");

                    b.ToTable("NewsTags");
                });

            modelBuilder.Entity("NewsWebsite.Entities.Newsletter", b =>
                {
                    b.Property<string>("Email")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("IsActive");

                    b.Property<DateTime?>("RegisterDateTime");

                    b.HasKey("Email");

                    b.ToTable("Newsletters");
                });

            modelBuilder.Entity("NewsWebsite.Entities.Tag", b =>
                {
                    b.Property<string>("TagId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("TagName");

                    b.HasKey("TagId");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("NewsWebsite.Entities.Visit", b =>
                {
                    b.Property<string>("NewsId");

                    b.Property<string>("IpAddress");

                    b.Property<DateTime>("LastVisitDateTime");

                    b.Property<int>("NumberOfVisit");

                    b.HasKey("NewsId", "IpAddress");

                    b.ToTable("Visits");
                });

            modelBuilder.Entity("NewsWebsite.Entities.identity.Role", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Description");

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AppRoles");
                });

            modelBuilder.Entity("NewsWebsite.Entities.identity.RoleClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AppRoleClaim");
                });

            modelBuilder.Entity("NewsWebsite.Entities.identity.User", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<DateTime?>("BirthDate");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FirstName");

                    b.Property<int>("Gender");

                    b.Property<string>("Image");

                    b.Property<bool>("IsActive");

                    b.Property<string>("LastName");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<DateTime?>("RegisterDateTime");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AppUsers");
                });

            modelBuilder.Entity("NewsWebsite.Entities.identity.UserClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AppUserClaim");
                });

            modelBuilder.Entity("NewsWebsite.Entities.identity.UserRole", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AppUserRole");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("NewsWebsite.Entities.identity.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("NewsWebsite.Entities.identity.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("NewsWebsite.Entities.Bookmark", b =>
                {
                    b.HasOne("NewsWebsite.Entities.News", "News")
                        .WithMany("Bookmarks")
                        .HasForeignKey("NewsId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("NewsWebsite.Entities.identity.User", "User")
                        .WithMany("Bookmarks")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("NewsWebsite.Entities.Category", b =>
                {
                    b.HasOne("NewsWebsite.Entities.Category", "category")
                        .WithMany("Categories")
                        .HasForeignKey("ParentCategoryId");
                });

            modelBuilder.Entity("NewsWebsite.Entities.Comment", b =>
                {
                    b.HasOne("NewsWebsite.Entities.News", "News")
                        .WithMany("Comments")
                        .HasForeignKey("NewsId");

                    b.HasOne("NewsWebsite.Entities.Comment", "comment")
                        .WithMany("comments")
                        .HasForeignKey("ParentCommentId");
                });

            modelBuilder.Entity("NewsWebsite.Entities.Like", b =>
                {
                    b.HasOne("NewsWebsite.Entities.News", "News")
                        .WithMany("Likes")
                        .HasForeignKey("NewsId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("NewsWebsite.Entities.News", b =>
                {
                    b.HasOne("NewsWebsite.Entities.identity.User", "User")
                        .WithMany("News")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("NewsWebsite.Entities.NewsCategory", b =>
                {
                    b.HasOne("NewsWebsite.Entities.Category", "Category")
                        .WithMany("NewsCategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("NewsWebsite.Entities.News", "News")
                        .WithMany("NewsCategories")
                        .HasForeignKey("NewsId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("NewsWebsite.Entities.NewsImage", b =>
                {
                    b.HasOne("NewsWebsite.Entities.News", "News")
                        .WithMany("NewsImages")
                        .HasForeignKey("NewsId");
                });

            modelBuilder.Entity("NewsWebsite.Entities.NewsTag", b =>
                {
                    b.HasOne("NewsWebsite.Entities.News", "News")
                        .WithMany("NewsTags")
                        .HasForeignKey("NewsId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("NewsWebsite.Entities.Tag", "Tag")
                        .WithMany("NewsTags")
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("NewsWebsite.Entities.Visit", b =>
                {
                    b.HasOne("NewsWebsite.Entities.News", "News")
                        .WithMany("Visits")
                        .HasForeignKey("NewsId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("NewsWebsite.Entities.identity.RoleClaim", b =>
                {
                    b.HasOne("NewsWebsite.Entities.identity.Role", "Role")
                        .WithMany("Claims")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("NewsWebsite.Entities.identity.UserClaim", b =>
                {
                    b.HasOne("NewsWebsite.Entities.identity.User", "User")
                        .WithMany("Claims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("NewsWebsite.Entities.identity.UserRole", b =>
                {
                    b.HasOne("NewsWebsite.Entities.identity.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("NewsWebsite.Entities.identity.User", "User")
                        .WithMany("Roles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
