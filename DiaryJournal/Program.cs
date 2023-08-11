using DiaryJournal.Data.Contexts;
using DiaryJournal.Domain.Entitys.Users;
using DiaryJournal.Service.DTOs.DierJournals;
using DiaryJournal.Service.DTOs.Users;
using DiaryJournal.Service.Services.Journals;
using DiaryJournal.Service.Services.Users;
using DiaryJournal.Wiew.DiaryJournalWindow;

UserService userService = new UserService();

var userUpdateDto = new UserCreationDTO()
{
    FirstName = "asdasdasd",
    LastName = "asdas",
    DateOfBirth = DateTimeOffset.Parse(DateTime.Parse("2004-02-20").ToString()).UtcDateTime,
    PhoneNumber = "+asdasdasd"
};
    
await userService.CreateAsync(userUpdateDto);



//JournalCreationDTO journalCreationDTO = new JournalCreationDTO()
//{
//    Name = "name",
//    Note = "kajsdn",
//    UserId = 2

//};
//JournalServive journalServive = new JournalServive();
//    await journalServive.CreateAsync(journalCreationDTO);
//User user = new User()
//{
//    FirstName = "nodir",
//    LastName = "akjedfb",
//    DateOfBirth = DateTime.UtcNow,
//    PhoneNumber = "ksdjfkds"
//};
//AppDbContext appDbContext = new AppDbContext();
//appDbContext.Add(user);













//Console.WriteLine((await userService.CreateAsync(userCreationDTO)).Data.FirstName);