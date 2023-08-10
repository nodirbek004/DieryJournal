using DiaryJournal.Domain.Commons;
using DiaryJournal.Domain.Entitys.Users;

namespace DiaryJournal.Domain.Entitys.DiaryJournal;

public class Journal:AudiTable
{
    public string Name { get; set; }
    public string Note { get; set; }
    public long UserId { get; set; }
    public User User { get; set; }

}
