using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace ScreenShotlemontree
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
         driver.Navigate().GoToUrl("https://werkenbijlemontree.nl/contact/#wpcf7-f16557-p15205-o1");
            IWebElement voornaam = driver.FindElement(By.Name("voornaam"));
            voornaam.SendKeys("priti");
            string value1 = voornaam.GetAttribute("value");
            Console.WriteLine(value1);

            IWebElement achternaam = driver.FindElement(By.Name("achternaam"));
            achternaam.SendKeys("vyawahare");
            var value2 = achternaam.GetAttribute("value");
            Console.WriteLine(value2);

          IWebElement email = driver.FindElement(By.Name("your-email"));
            email.SendKeys("pritiv.acem@gmail.com");
            string value3 = email.GetAttribute("value");
            Console.WriteLine(value3);

            IWebElement telefoon = driver.FindElement(By.Name("telefoon"));
     telefoon.SendKeys("0683130328");
            string value4 = email.GetAttribute("value");
            Console.WriteLine(value4);

            Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
            ss.SaveAsFile("C:\\Users\\Administrator\\OneDrive\\Documents\\Desktop\\lemontree.pnj", OpenQA.Selenium.ScreenshotImageFormat.Png);
            Console.Read();

        }
    }
}
