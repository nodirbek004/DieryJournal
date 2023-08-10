using DiaryJournal.Data.IReapasitories.Commons;
using DiaryJournal.Domain.Entitys.DiaryJournal;
using DiaryJournal.Domain.Entitys.Users;

namespace DiaryJournal.Data.IReapasitories;

public interface IUnitOfWork:IDisposable
{
    IUserRepasitory UserRepasitory { get; }
    IRepasitory<Journal> JournalRepasitory { get; }


}
