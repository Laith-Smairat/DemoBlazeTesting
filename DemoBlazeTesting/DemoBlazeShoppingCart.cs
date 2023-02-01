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
    public class DemoBlazeShoppingCart
    {
        [TestMethod]

        public void AddRemoveFromShoppingCart ()
         {

            TestSetup.NavigateToUrl(TestSetup.driver, TestSetup.url);
            System.Threading.Thread.Sleep(5000);

            TestSetup.Login();

            // Click on the "Laptops" link
            IWebElement laptopsLink = TestSetup.driver.FindElement(By.XPath("//div//a[@id='itemc'][2]"));  
            TestSetup.HighlightElement(TestSetup.driver, laptopsLink);
            laptopsLink.Click();


            // Get a list of all the items 
            System.Threading.Thread.Sleep(5000);

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


            // Click on cart to remove item
            IWebElement cartLink = TestSetup.driver.FindElement(By.XPath("//div//li/a[@id='cartur']"));
            TestSetup.HighlightElement(TestSetup.driver, cartLink);
            cartLink.Click();

            System.Threading.Thread.Sleep(5000);


            // Click on delete button to remove item
            IWebElement deleteBtn = TestSetup.driver.FindElement(By.XPath("//div//td/a[@onclick]"));
            TestSetup.HighlightElement(TestSetup.driver, deleteBtn);
            deleteBtn.Click();



        }


    }

}









            
