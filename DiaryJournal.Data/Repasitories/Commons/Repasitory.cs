using DiaryJournal.Data.Contexts;
using DiaryJournal.Data.IReapasitories;
using DiaryJournal.Domain.Commons;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace DiaryJournal.Data.Repasitories;

public class Repasitory<T> : IRepasitory<T> where T : AudiTable
{
    private readonly AppDbContext dbContext;
    public Repasitory(AppDbContext dbContext)
    {
        this.dbContext = dbContext;
    }
    public async Task CreateAsync(T entity)
    {
        entity.CreateAt = DateTime.Now;
        await this.dbContext.Set<T>().AddAsync(entity);
    }

    public void Delete(T entity)
    {
        this.dbContext.Set<T>().Remove(entity);
    }

    public IQueryable<T> SelectAll()
        =>this.dbContext.Set<T>().AsNoTracking().AsQueryable();
    

    public async Task<T> SelectByIdAsync(long id)
        => await this.dbContext.Set<T>().FirstOrDefaultAsync(x=> x.Id == id);

    public void Update(T entity)
    {
        entity.UpdateAt = DateTime.Now;
        this.dbContext.Entry(entity).State = EntityState.Modified;
    }
}
