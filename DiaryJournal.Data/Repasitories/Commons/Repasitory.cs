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
        entity.CreatedAt = DateTime.UtcNow;
        await this.dbContext.Set<T>().AddAsync(entity);
        await dbContext.SaveChangesAsync();
    }

    public  void Delete(T entity)
    {
         this.dbContext.Set<T>().Remove(entity);
    }

    public async void SaveChangesAsync()
    {
        await dbContext.SaveChangesAsync();
    }

    public IQueryable<T> SelectAll()
        => this.dbContext.Set<T>().AsQueryable();

    public async Task<T> SelectAsync(Expression<Func<T, bool>> expression)
        => await dbContext.Set<T>().FirstOrDefaultAsync(expression);

    public void Update(T entity)
    {
        entity.UpdatedAt = DateTime.UtcNow;
        this.dbContext.Entry(entity).State = EntityState.Modified;
    }

}
