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
    private readonly DbSet<T> dbSet;
    public Repasitory(AppDbContext dbContext)
    {
        this.dbContext = dbContext;
        dbSet = dbContext.Set<T>();
    }
    public async Task<T> CreateAsync(T entity)
    {
        var temp = (await dbSet.AddAsync(entity)).Entity;
        return temp;
    }

    public void Delete(T entity)
    {
        dbSet.Remove(entity);
    }

    public IQueryable<T> SelectAll()
        => dbSet.AsQueryable();

    public Task<T> SelectAsync(Expression<Func<T, bool>> expression)
        => dbContext.Set<T>().FirstOrDefaultAsync(expression);

    public T Update(T entity)
        =>dbSet.Update(entity).Entity;

}
