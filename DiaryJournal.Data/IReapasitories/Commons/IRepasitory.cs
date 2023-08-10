using DiaryJournal.Domain.Commons;
using DiaryJournal.Domain.Entitys.DiaryJournal;
using DiaryJournal.Domain.Entitys.Users;
using System.Linq.Expressions;

namespace DiaryJournal.Data.IReapasitories.Commons;

public interface IRepasitory<T> where T : AudiTable
{
    Task<T> CreateAsync(T entity);
    T Update(T entity);
    void Delete(T entity);
    Task<T> SelectAsync(Expression<Func<T, bool>> expression);
    IQueryable<T> SelectAll();
}

