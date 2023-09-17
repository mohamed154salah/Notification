using Notification.Configuration;
using Notification.Email;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Notification.Factory;

namespace Notification.Test
{
    public class FactoryConfig
    {
        Factory.FactoryConfig? config;
        
        [Fact]
        public void Test_Factory_Email_With_Exist_Type()
        {
            //Arrange
            config = new ChooseEmail();
            //Act
            IConfiguration result = config.Choose("Gmail");


            //Assert
            Assert.Equivalent(result,new GmailConfig());


        }


        [Fact]
        public void Test_Factory_Email_With_Wrong_Type()
        {
            //Arrange
            config = new ChooseEmail();
            //Act
            IConfiguration result = config.Choose("Hotmail");


            //Assert
            Assert.Equivalent(result, new OutlookConfig());


        }
    }
}
