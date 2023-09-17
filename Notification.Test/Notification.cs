using Notification.Email;
using Notification.Sms;
using A = Notification.Email;
namespace Notification.Test
{
    public class Notification
    {
        INotification? notification;
        [Fact]
        public void Test_Email_Send_Without_CC()
        {
            //Arrange
           
             notification = new A.Email("Hello there", "Mohamed", "Ahmed");
            //Act
            bool result=notification.Send(new GmailConfig());
            //Assert
            Assert.True(result);

        }
        [Fact]
        public void Test_Email_Send_With_CC() {
            //Arrange
            string[] CC = { "mo", "so" };
            notification = new A.Email("Hello there", "Mohamed", "Ahmed",CC);
            //Act
            bool result = notification.Send(new OutlookConfig());
            //Assert
            Assert.True(result);
        }

      

      

        [Fact]
        public void Test_Message_send() {
            //Arrange
            string messsage = "You Got Message";
            notification =new SMS(messsage);
            //Act
            bool result=notification.Send(new WeConfig());
            //Assert
            Assert.True(result);
        
        }

        
    }
}
