using DiaryJournal.Domain.Entitys.Users;
using DiaryJournal.Service.DTOs.Users;
using DiaryJournal.Service.Services.Users;

UserService userService = new UserService();

UserCreationDTO userCreationDTO = new UserCreationDTO()
{
    FirstName = "Nodirbek",
    LastName = "Ollonazarov",
    DateOfBirth = DateTimeOffset.Parse(DateTime.Parse("2004-02-20").ToString()).UtcDateTime,
    PhoneNumber = "+998881813525"
};


Console.WriteLine((await userService.CreateAsync(userCreationDTO)).Data.FirstName);