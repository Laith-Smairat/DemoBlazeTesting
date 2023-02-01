using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DemoBlazeTesting
{
    class TestSetup
    {
        public static IWebDriver driver = new ChromeDriver();
        public static string url = "https://www.demoblaze.com/";

        public static void NavigateToUrl(IWebDriver driver, string url)
        {
            driver.Manage().Window.Size = new Size(1500, 900);
            driver.Navigate().GoToUrl(url);
        }

        public static void HighlightElement(IWebDriver driver, IWebElement element)
        {
            IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;
            executor.ExecuteScript("arguments[0].setAttribute('style' , 'background: yellow !important')", element);

            System.Threading.Thread.Sleep(1000);
            executor.ExecuteScript("arguments[0].setAttribute('style' , 'border: solid 1px white !important')", element);

        }

        public static void Login()
        {
            // Login

            IWebElement login = TestSetup.driver.FindElement(By.XPath("//div//a[@id='login2']"));
            TestSetup.HighlightElement(TestSetup.driver, login);
            login.Click();
            System.Threading.Thread.Sleep(1000);

            IWebElement loginUsername = TestSetup.driver.FindElement(By.XPath("//div//input[@id='loginusername']"));
            TestSetup.HighlightElement(TestSetup.driver, loginUsername);
            loginUsername.SendKeys("Laith-Smairat");
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
