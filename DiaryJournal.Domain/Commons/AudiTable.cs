﻿using DiaryJournal.Domain.Entitys.Users;
namespace DiaryJournal.Domain.Commons;

public class AudiTable
{
    public long Id { get; set; }
    public DateTime CreateAt { get; set; }
    public DateTime UpdateAt { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}
