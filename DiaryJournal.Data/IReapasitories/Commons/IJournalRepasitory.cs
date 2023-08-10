using DiaryJournal.Domain.Entitys.DiaryJournal;

namespace DiaryJournal.Data.IReapasitories.Commons
{
    public interface IJournalRepasitory:IRepasitory<Journal>
    {
        Task<Journal> GetByName(string name);
    }
}