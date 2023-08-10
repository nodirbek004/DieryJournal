using DiaryJournal.Service.Services.Journals;
using DiaryJournal.Service.Services.Users;

namespace DiaryJournal.Wiew.DiaryJournalWindow;

public class SignUp 
{
    public async void Signup()
    {
        UserService userService = new UserService();
        Console.WriteLine("Telefon Raqamingizni Kiriting");
        string number = Console.ReadLine();
        var result=await userService.GetByNumberAsync(number);
        if (result==null)
        {
            Console.WriteLine("bunday user topilmadi");
        }
        else
        {
            Console.WriteLine(@$"

                     1.Note Yozish
                     2.Noteni Uchirish
                     3.Notelarni korish
                     4.Notelarni Uzgartrsih
");
            JournalServive journalServive = new JournalServive();
            int a=int.Parse(Console.ReadLine());
            switch (a)
            {
                case 1:
                    break;

            }
        }
       

    }

}
