using DiaryJournal.Data.IReapasitories;
using DiaryJournal.Data.Repasitories.Commons;
using DiaryJournal.Domain.Entitys.Users;

namespace DiaryJournal.Data.Repasitories;

public class UserRepasitory : Repasitory<User>, IUserRepasitory
{
    public Task<User> GetByNumber(string number)
    {
        throw new NotImplementedException();
    }
}
