
using DiaryJournal.Domain.Entitys.DiaryJournal;
using DiaryJournal.Domain.Entitys.Users;
using Microsoft.EntityFrameworkCore;
using Npgsql.EntityFrameworkCore.PostgreSQL.Infrastructure.Internal;

namespace DiaryJournal.Data.Contexts;

public class AppDbContext:DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string stringConnection = "Host=localhost;Port=5432;User Id=postgres; Database=JournalDiary; Password=2004;";
        optionsBuilder.UseNpgsql(stringConnection);
    }
    public DbSet<User> Users { get; set; }
    public DbSet<Journal> Journals { get; set; }

}