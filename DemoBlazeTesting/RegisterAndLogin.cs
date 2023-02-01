using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DemoBlazeTesting
{
    [TestClass]
    public class RegisterAndLogin
    {
        [TestMethod]

        public void RegisterLogin()
        {

            // Register

            TestSetup.NavigateToUrl(TestSetup.driver, TestSetup.url);
            System.Threading.Thread.Sleep(5000);


            IWebElement register = TestSetup.driver.FindElement(By.XPath("//div//a[@id='signin2']"));
            TestSetup.HighlightElement(TestSetup.driver, register);
            register.Click();
            System.Threading.Thread.Sleep(1000);

            IWebElement signUpUsername = TestSetup.driver.FindElement(By.XPath("//div//input[@id='sign-username']"));
            TestSetup.HighlightElement(TestSetup.driver, signUpUsername);
            signUpUsername.SendKeys("Laith-Nabil-Smairat");
            System.Threading.Thread.Sleep(1000);

            IWebElement signUpPassword = TestSetup.driver.FindElement(By.XPath("//div//input[@id='sign-password']"));
            TestSetup.HighlightElement(TestSetup.driver, signUpPassword);
            signUpPassword.SendKeys("000000");
            System.Threading.Thread.Sleep(1000);

            IWebElement signUpBtn = TestSetup.driver.FindElement(By.XPath("//div//button[@onclick='register()']"));
            TestSetup.HighlightElement(TestSetup.driver, signUpBtn);
            signUpBtn.Click();
            System.Threading.Thread.Sleep(5000);

            IAlert alert = TestSetup.driver.SwitchTo().Alert();
            alert.Accept();



            // Login

            IWebElement login = TestSetup.driver.FindElement(By.XPath("//div//a[@id='login2']"));
            TestSetup.HighlightElement(TestSetup.driver, login);
            login.Click();
            System.Threading.Thread.Sleep(1000);

            IWebElement loginUsername = TestSetup.driver.FindElement(By.XPath("//div//input[@id='loginusername']"));
            TestSetup.HighlightElement(TestSetup.driver, loginUsername);
            loginUsername.SendKeys("Laith-Nabil-Smairat");
            System.Threading.Thread.Sleep(1000);

            IWebElement loginPassword = TestSetup.driver.FindElement(By.XPath("//div//input[@id='loginpassword']"));
            TestSetup.HighlightElement(TestSetup.driver, loginPassword);
            loginPassword.SendKeys("000000");
            System.Threading.Thread.Sleep(1000);

            IWebElement loginBtn = TestSetup.driver.FindElement(By.XPath("//div//button[@onclick='logIn()']"));
            TestSetup.HighlightElement(TestSetup.driver, loginBtn);
            loginBtn.Click();
            System.Threading.Thread.Sleep(5000);




        }



    }    

} 





        


                

                


   
    

      
