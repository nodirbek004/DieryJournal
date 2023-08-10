namespace DiaryJournal.Service.DTOs.DierJournals;

public class JournalUpdateDTO
{
    public long Id { get; set; }
    public string Name { get; set; }
    public ICollection<string> Note { get; set; }
    public long UserId { get; set; }
}
