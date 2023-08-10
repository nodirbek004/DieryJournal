using DiaryJournal.Data.Contexts;
using DiaryJournal.Data.IReapasitories.Commons;
using DiaryJournal.Domain.Commons;
using DiaryJournal.Domain.Entitys.DiaryJournal;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System.Linq.Expressions;

namespace DiaryJournal.Data.Repasitories.Commons;

public class Repasitory<T> : IRepasitory<T> where T : AudiTable
{
    private readonly AppDbContext dbContext;
    public Repasitory(AppDbContext dbContext)
    {
        this.dbContext = dbContext;
    }
    public async Task CreateAsync(T entity)
    {
        entity.CreateAt = DateTime.UtcNow;
        await dbContext.Set<T>().AddAsync(entity);
    }

    public void Delete(T entity)
    {
        dbContext.Set<T>().Remove(entity);
    }

    public IQueryable<T> SelectAll()
        => dbContext.Set<T>().AsQueryable();

    public Task<T> SelectAsync(Expression<Func<T, bool>> expression)
        => dbContext.Set<T>().FirstOrDefaultAsync(expression);

    public void Update(T entity)
    {
        entity.UpdateAt = DateTime.Now;
        dbContext.Entry(entity).State = EntityState.Modified;
    }
}
