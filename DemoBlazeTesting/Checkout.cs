using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DemoBlazeTesting
{
    [TestClass]

    public class Checkout
    {
        [TestMethod]
        public void CompleteCheckout()
        {
            TestSetup.NavigateToUrl(TestSetup.driver, TestSetup.url);
            System.Threading.Thread.Sleep(5000);

            TestSetup.Login();

            // Click on the "Phones" link 
            IWebElement phonesLink = TestSetup.driver.FindElement(By.XPath("//div//a[@id='itemc'][1]"));
            TestSetup.HighlightElement(TestSetup.driver, phonesLink);
            phonesLink.Click();


            System.Threading.Thread.Sleep(5000);

            // Get a list of all the items 
            IList<IWebElement> phoneItems = TestSetup.driver.FindElements(By.XPath("//div//a/img[@class='card-img-top img-fluid']"));

            System.Threading.Thread.Sleep(5000);

            // Choose a random item to add to the cart
            Random random = new Random();
            int randomIndex = random.Next(0, phoneItems.Count - 1);
            IWebElement selectedItem = phoneItems[randomIndex];
            System.Threading.Thread.Sleep(5000);

            selectedItem.Click();


            System.Threading.Thread.Sleep(5000);

            // Click on the "Add to cart" button for the selected item
            IWebElement addToCartButton = TestSetup.driver.FindElement(By.XPath("//div/a[@class='btn btn-success btn-lg']"));
            TestSetup.HighlightElement(TestSetup.driver, addToCartButton);
            addToCartButton.Click();


            System.Threading.Thread.Sleep(2000);

            IAlert alert = TestSetup.driver.SwitchTo().Alert();
            alert.Accept();


            // Click on cart 
            IWebElement cartLink = TestSetup.driver.FindElement(By.XPath("//div//li/a[@id='cartur']"));
            TestSetup.HighlightElement(TestSetup.driver, cartLink);
            cartLink.Click();

            System.Threading.Thread.Sleep(5000);


            IWebElement orderBtn = TestSetup.driver.FindElement(By.XPath("//button[text()='Place Order']"));
            TestSetup.HighlightElement(TestSetup.driver, orderBtn);
            orderBtn.Click();

            System.Threading.Thread.Sleep(5000);

            IWebElement nameInput = TestSetup.driver.FindElement(By.XPath("//div/input[@id='name']"));
            TestSetup.HighlightElement(TestSetup.driver, nameInput);
            nameInput.SendKeys("Laith Smairat");
            System.Threading.Thread.Sleep(1000);


            IWebElement countryInput = TestSetup.driver.FindElement(By.XPath("//div/input[@id='country']"));
            TestSetup.HighlightElement(TestSetup.driver, countryInput);
            countryInput.SendKeys("Jordan");
            System.Threading.Thread.Sleep(1000);

            IWebElement cityInput = TestSetup.driver.FindElement(By.XPath("//div/input[@id='city']"));
            TestSetup.HighlightElement(TestSetup.driver, cityInput);
            cityInput.SendKeys("Amman");
            System.Threading.Thread.Sleep(1000);

            IWebElement cardInput = TestSetup.driver.FindElement(By.XPath("//div/input[@id='card']"));
            TestSetup.HighlightElement(TestSetup.driver, cardInput);
            cardInput.SendKeys("374245455400126");
            System.Threading.Thread.Sleep(1000);

            IWebElement monthInput = TestSetup.driver.FindElement(By.XPath("//div/input[@id='month']"));
            TestSetup.HighlightElement(TestSetup.driver, monthInput);
            monthInput.SendKeys("April");
            System.Threading.Thread.Sleep(1000);


            IWebElement yearInput = TestSetup.driver.FindElement(By.XPath("//div/input[@id='year']"));
            TestSetup.HighlightElement(TestSetup.driver, yearInput);
            yearInput.SendKeys("2023");
            System.Threading.Thread.Sleep(1000);



            IWebElement purchaseBtn = TestSetup.driver.FindElement(By.XPath("//button[text()='Purchase']"));
            TestSetup.HighlightElement(TestSetup.driver, purchaseBtn);
            purchaseBtn.Click();
            System.Threading.Thread.Sleep(1000);

            IWebElement okBtn = TestSetup.driver.FindElement(By.XPath("//button[text()='OK']"));
            TestSetup.HighlightElement(TestSetup.driver, okBtn);
            okBtn.Click();
            System.Threading.Thread.Sleep(1000);


        }

    }
}
