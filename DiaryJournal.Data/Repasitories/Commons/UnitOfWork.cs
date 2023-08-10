using DiaryJournal.Data.Contexts;
using DiaryJournal.Data.IReapasitories;
using DiaryJournal.Domain.Entitys.DiaryJournal;
using DiaryJournal.Domain.Entitys.User;

namespace DiaryJournal.Data.Repasitories;

public class UnitOfWork : IUnitOfWork
{
    private readonly AppDbContext dbContext;

    public IRepasitory<User> UserRepasitory { get; }
    public IRepasitory<Journal> JournalRepasitory { get; }


    public UnitOfWork()
    {
        this.dbContext = new AppDbContext();
        UserRepasitory = new Repasitory<User>(dbContext);
        JournalRepasitory =new Repasitory<Journal>(dbContext);
    }
    public async Task SaveAsync()
    {
        await this.dbContext.SaveChangesAsync();
    }

    public void Dispose()
    {
        GC.SuppressFinalize(true);
    }
}
