using DiaryJournal.Service.DTOs.DierJournals;

namespace DiaryJournal.Service.Interfaces.DiaryJournals;

public interface IJournalService
{
    Task<JournalResultDTO> CreateAsync(JournalCreationDTO dto);
    Task<JournalResultDTO> UpdateAsync(JournalUpdateDTO dto);
    Task<bool> DeleteAsync(long id);
    Task<JournalResultDTO> GetByNameAsync(long id);
    Task<IEnumerable<JournalResultDTO>> GetAllAsync();

}
