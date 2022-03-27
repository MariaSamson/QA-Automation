using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestProject
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
           
        }

        [Test]
        public void Test1()
        {
            //open browser
            IWebDriver webDriver = new ChromeDriver();
            //navigate to site 
            webDriver.Navigate().GoToUrl("https://politrip.com/account/sign-up");

            webDriver.FindElement(By.Name("first-name")).SendKeys("Maria");
            webDriver.FindElement(By.Name("last-name")).SendKeys("Samson");
            webDriver.FindElement(By.Name("email")).SendKeys("samson.andreea@ac.tuiasi.ro");
            webDriver.FindElement(By.Id("sign-up-password-input")).SendKeys("Samson1997");
            webDriver.FindElement(By.Id("sign-up-confirm-password-input")).SendKeys("Samson1997");
            webDriver.FindElement(By.Name("heard")).SendKeys("Web-Search");
            webDriver.FindElement(By.XPath("//button[@type='submit']")).SendKeys(Keys.Enter);
    
        }
    }
}