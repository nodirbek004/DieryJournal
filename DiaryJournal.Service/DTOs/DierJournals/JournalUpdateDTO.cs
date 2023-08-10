namespace DiaryJournal.Service.DTOs.DierJournals;

public class JournalUpdateDTO
{
    public ICollection<string> Note { get; set; }
    public long UserId { get; set; }
}
