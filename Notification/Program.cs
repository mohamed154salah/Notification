using Notification.Configuration;
using Notification.Email;
using Notification.Sms;

string[] CC = { "khaled", "farag" };
string From = "mohamed Salah";
string To = "Ahmed";
string Message = " Think That Was Good";
Notification.INotification notification = null!;
IConfiguration configuration = null!;
int x = 1;
while (x != 0)
{
    Console.WriteLine("Want Message Enter 'M' Want Email Enter 'E'");
    string choice = Console.ReadLine();
    switch (choice.ToUpper().ElementAt(0))
    {
        case 'E':
            notification = new Email(Message, From, To, CC);
            Console.WriteLine("chose Email Config");
            string choice2 = Console.ReadLine();
            switch (choice2.ToUpper().ElementAt(0))
            {
                case 'G':
                    configuration = new GmailConfig();
                    break;
                case 'O':
                    configuration = new OutlookConfig();
                    break;
                default:
                    Console.WriteLine("Wrong Choice");
                    break;
            }
            break;
        case 'M':
            notification = new SMS(Message);
            Console.WriteLine("chose Message Config");
            string choice3 = Console.ReadLine();
            switch (choice3.ToUpper().ElementAt(0))
            {
                case 'V':
                    configuration = new VodafoneConfig();
                    break;
                case 'W':
                    configuration = new WeConfig();
                    break;
                default:
                    Console.WriteLine("Wrong Choice");
                    break;
            }
            break;
        default:
            Console.WriteLine("Wrong Choice");
            break;
    }
    if (configuration != null)
    {
        notification.Send(configuration);
    }

    Console.WriteLine("Enter 0 To Exit any number To Continue");
    x = int.Parse(Console.ReadLine());
}
