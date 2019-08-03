using Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace DataAccess
{
    public class NoteDbContext:DbContext
    {
        public NoteDbContext() { }

        public NoteDbContext(DbContextOptions<NoteDbContext> options):base(options)
        {
            Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Note>().HasKey(n => new { n.NoteId });
            modelBuilder.Entity<Note>().Property(n => n.Title).IsRequired();
            modelBuilder.Entity<Note>().Property(n => n.Text).IsRequired();
            modelBuilder.Entity<Note>().HasAlternateKey("Title");
            modelBuilder.Entity<Label>().HasKey(l => new { l.LabelId });
        }
        public DbSet<Note> Notes { get; set; }
        public DbSet<Label> Labels { get; set; }
    }
}
