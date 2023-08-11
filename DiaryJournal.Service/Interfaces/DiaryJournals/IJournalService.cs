using DiaryJournal.Data.Repasitories.Commons;
using DiaryJournal.Service.DTOs.DierJournals;
using DiaryJournal.Service.Helpers;

namespace DiaryJournal.Service.Interfaces.DiaryJournals;

public interface IJournalService
{
    Task<Responce<JournalResultDTO>> CreateAsync(JournalCreationDTO dto);
    Task<Responce<JournalResultDTO>> UpdateAsync(JournalUpdateDTO dto);
    Task<Responce<bool>> DeleteAsync(string name);
    Task<Responce<JournalResultDTO>> GetByNameAsync(string name);
    Responce<IEnumerable<JournalResultDTO>> GetAllAsync();

}
