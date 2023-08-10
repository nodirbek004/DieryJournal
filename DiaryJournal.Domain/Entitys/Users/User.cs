using DiaryJournal.Domain.Commons;
using DiaryJournal.Domain.Entitys.DiaryJournal;
using System.Globalization;

namespace DiaryJournal.Domain.Entitys.Users;

public class User:AudiTable
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string PhoneNumber { get; set; }
    public ICollection<Journal> Journals { get; set; }
    
}
