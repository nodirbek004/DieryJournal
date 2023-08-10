using DiaryJournal.Domain.Commons;

namespace DiaryJournal.Data.IReapasitories;

public interface IRepasitory<T> where T : AudiTable
{
    Task CreateAsync(T entity);
    void Update(T entity);
    void Delete(T entity);
    Task<T> SelectByIdAsync(long id);
    IQueryable<T> SelectAll();
}

