using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using LibraryDAL.Model;

#nullable disable

namespace LibraryDAL.Context
{
    public partial class LibraryContext : DbContext
    {

        public LibraryContext(DbContextOptions<LibraryContext> options): base(options)
        {
            Database.EnsureCreated();
        }

        public virtual DbSet<ListType> ListTypes { get; set; }
        public virtual DbSet<Title> Titles { get; set; }
        public virtual DbSet<TitleList> TitleLists { get; set; }
        public virtual DbSet<TitleListItem> TitleListItems { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=localhost;Database=Library;Trusted_Connection=True;");
            }
        }
    }
}
