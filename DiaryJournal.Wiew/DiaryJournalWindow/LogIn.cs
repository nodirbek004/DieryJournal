using DiaryJournal.Domain.Entitys.Users;
using DiaryJournal.Service.DTOs.Users;
using DiaryJournal.Service.Services.Users;

namespace DiaryJournal.Wiew.DiaryJournalWindow;

public class LogIn
{
    public async void Login (){
        Console.WriteLine("Isminigizni Kiriting");
        string FirstName = Console.ReadLine();
        Console.WriteLine("Familyangizni Kiritng");
        string LastName = Console.ReadLine();
        Console.WriteLine("Telefon Raqamingizni Kiriting Exammple:+998881813525");
        string PhoneNumber = Console.ReadLine();
        Console.WriteLine("Tugilgan kuningizni kiriting");
        string DateOfBirth = Console.ReadLine();
        UserCreationDTO userCretionDTO = new UserCreationDTO()
        {
            FirstName = FirstName,
            LastName = LastName,
            DateOfBirth = DateTimeOffset.Parse(DateTime.Parse(DateOfBirth).ToString()).UtcDateTime,
            PhoneNumber = PhoneNumber
        };

    UserService userService = new UserService();
        await userService.CreateAsync(userCretionDTO);
    }
}
