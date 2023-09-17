using Notification.Sms;


namespace Notification
{
    public static class Print
    {

        public static void PrintEmail(Email.Email email) {
            if (email.CC != null)
            {
                Console.WriteLine($"From:{email.From}\n" +
                           $"TO:{email.To} \n" +
                           $"CC:{string.Join(",", email.CC)}\n" +
                           $"Body:{email.Body} \n" +
                           $"Email SENT");
            }
            else
            {

                Console.WriteLine($"From:{email.From}\n" +
                           $"TO:{email.To} \n" +
                           $"Body:{email.Body} \n" +
                           $"Email SENT");
            }
        }

        public static void PrintSMS(SMS sms)
        {
            Console.WriteLine($"Message:{sms.Message}\n" +
                    $"SMS SENT");
        }
    }
}
