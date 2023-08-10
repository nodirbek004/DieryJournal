using DiaryJournal.Data.Contexts;
using DiaryJournal.Data.IReapasitories;
using DiaryJournal.Data.Repasitories.Commons;
using DiaryJournal.Domain.Entitys.Users;
using Microsoft.EntityFrameworkCore;

namespace DiaryJournal.Data.Repasitories;

public class UserRepasitory : Repasitory<User>, IUserRepasitory
{
    private readonly AppDbContext appDbContext;

    public UserRepasitory(AppDbContext dbContext) : base(dbContext)
    {
        this.appDbContext = dbContext;
    }

    public async Task<User> GetByNumberAsync(string number)
    {
        var user = await appDbContext.Users.FirstOrDefaultAsync(p => p.PhoneNumber.Equals(number));
        return user;
    }
}
