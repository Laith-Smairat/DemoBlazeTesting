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

    public class CategoryChecker
    {
        [TestMethod]

        public void CategoryItems()
        {

            TestSetup.NavigateToUrl(TestSetup.driver, TestSetup.url);
            System.Threading.Thread.Sleep(5000);

            TestSetup.Login();

            // Define a list of categories to check
            List<string> categories = new List<string> { "Phones", "Laptops", "Monitors" };

            // Loop through each category
            foreach (string category in categories)
            {

                // Check if the category has items
                IList<IWebElement> itemElements = TestSetup.driver.FindElements(By.XPath("//div//a/img[@class='card-img-top img-fluid']"));


                if (itemElements.Count > 0)
                {
                    Console.WriteLine(category + " has items");
                }
                else
                {
                    Console.WriteLine(category + " has no items");
                }

                // Navigate back to the main page
                TestSetup.driver.Navigate().Back();
            }
            // Close the browser
            TestSetup.driver.Quit();

        }

    }
}
