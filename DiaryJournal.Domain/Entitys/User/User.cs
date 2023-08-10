using DiaryJournal.Domain.Commons;
using System.Globalization;

namespace DiaryJournal.Domain.Entitys.User;

public class User:AudiTable
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string PhoneNumber { get; set; }
    
}
