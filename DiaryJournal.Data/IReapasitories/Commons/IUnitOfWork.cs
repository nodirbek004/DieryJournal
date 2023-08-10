using DiaryJournal.Domain.Entitys.DiaryJournal;
using DiaryJournal.Domain.Entitys.Users;

namespace DiaryJournal.Data.IReapasitories.Commons;

public interface IUnitOfWork : IDisposable
{
    IRepasitory<User> UserRepasitory { get; }
    IRepasitory<Journal> JournalRepasitory { get; }
    //Task SaveAsync();

}
