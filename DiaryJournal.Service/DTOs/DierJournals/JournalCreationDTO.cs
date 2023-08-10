namespace DiaryJournal.Service.DTOs.DierJournals;

public class JournalCreationDTO
{
    public ICollection<string> Note { get; set; }
    public long UserId { get; set; }
}
