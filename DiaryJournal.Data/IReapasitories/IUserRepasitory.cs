using DiaryJournal.Data.IReapasitories.Commons;
using DiaryJournal.Domain.Entitys.Users;

namespace DiaryJournal.Data.IReapasitories;

public interface IUserRepasitory: IRepasitory<User>
{
    Task<User> GetByNumberAsync(string number);

}
