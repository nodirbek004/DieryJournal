namespace DiaryJournal.Wiew.DiaryJournalWindow;

public class FirstWindow
{
    public FirstWindow()
    {
        Console.WriteLine(@$"
                  -------ASSALOMU ALEYKUM-------
                  QAYSI BOLIMDAN FOYDALANMOQCHISIZ!
                           1.KIRISH
                           2.RO'YXATDAN UTISH

");
        int a=int.Parse(Console.ReadLine());
        switch (a)
        {
            case 1:
                break;
            case 2:
                LogIn logIn = new LogIn();
                logIn.Login();
                break;
        }
    }
}
