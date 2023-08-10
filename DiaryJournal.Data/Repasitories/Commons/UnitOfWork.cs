using DiaryJournal.Data.Contexts;
using DiaryJournal.Data.IReapasitories.Commons;
using DiaryJournal.Domain.Entitys.DiaryJournal;
using DiaryJournal.Domain.Entitys.Users;

namespace DiaryJournal.Data.Repasitories.Commons;

public class UnitOfWork : IUnitOfWork
{
    private readonly AppDbContext dbContext;

    public IRepasitory<User> UserRepasitory { get; }
    public IRepasitory<Journal> JournalRepasitory { get; }


    public UnitOfWork(AppDbContext appDbContext)
    {
        dbContext = appDbContext;
        UserRepasitory = new Repasitory<User>(dbContext);
        JournalRepasitory = new Repasitory<Journal>(dbContext);
    }

    public void Dispose()
    {
        GC.SuppressFinalize(true);
    }

    //public async Task SaveAsync()
    //{
    //    var i = await dbContext.SaveChangesAsync();
    //    Console.WriteLine(i);
    //}
    
}
