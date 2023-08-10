
using DiaryJournal.Domain.Entitys.DiaryJournal;
using DiaryJournal.Domain.Entitys.Users;
using Microsoft.EntityFrameworkCore;
using Npgsql.EntityFrameworkCore.PostgreSQL.Infrastructure.Internal;

namespace DiaryJournal.Data.Contexts;

public class AppDbContext:DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string stringConnection = "Host=localhost; Port=5432; User Id=postgres; Database=DiaryJournal; Password=2004;";
        optionsBuilder.UseNpgsql(stringConnection);
    }
    public DbSet<User> User { get; set; }
    public DbSet<Journal> Journal { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        #region FluntApi
        modelBuilder.Entity<Journal>()
        .HasOne(c => c.User)
        .WithMany(p => p.Journals)
        .HasForeignKey(c => c.UserId);
        #endregion
    }
}