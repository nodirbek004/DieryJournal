using DiaryJournal.Domain.Commons;
using DiaryJournal.Domain.Entitys.User;

namespace DiaryJournal.Domain.Entitys.DiaryJournal;

public class Journal:AudiTable
{
    public string Name { get; set; }
    public string Note { get; set; }
    public long UserId { get; set; }

}
