﻿namespace DiaryJournal.Service.DTOs.DierJournals;

public class JournalResultDTO
{
    public ICollection<string> Note { get; set; }
    public long UserId { get; set; }
}
