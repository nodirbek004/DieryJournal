using DiaryJournal.Domain.Entitys.User;
namespace DiaryJournal.Domain.Commons;

public class AudiTable
{
    public long Id { get; set; }
    public DateTime CreateAt { get; set; }
    public DateTime UpdateAt { get; set; }
    public User User { get; set; }
}
