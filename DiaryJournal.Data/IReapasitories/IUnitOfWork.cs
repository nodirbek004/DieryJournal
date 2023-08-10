using DiaryJournal.Domain.Entitys.DiaryJournal;
using DiaryJournal.Domain.Entitys.User;

namespace DiaryJournal.Data.IReapasitories;

public interface IUnitOfWork:IDisposable
{
    IRepasitory<User> UserRepasitory { get; }
    IRepasitory<Journal> JournalRepasitory { get; }
    Task SaveAsync();

}
