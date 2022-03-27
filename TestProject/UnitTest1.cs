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
        public void FirstTest()
        {
            //open browser
            IWebDriver webDriver = new ChromeDriver();
            //navigate to site 
            webDriver.Navigate().GoToUrl("https://politrip.com/account/sign-up");

            webDriver.FindElement(By.Name("first-name")).SendKeys("Maria");
            webDriver.FindElement(By.Name("last-name")).SendKeys("Peterson");
            webDriver.FindElement(By.Name("email")).SendKeys("peterson.adsa@ac.tuiasi.ro");
            webDriver.FindElement(By.Id("sign-up-password-input")).SendKeys("Samson1997");
            webDriver.FindElement(By.Id("sign-up-confirm-password-input")).SendKeys("Samson1997");
            webDriver.FindElement(By.Name("heard")).SendKeys("Web-Search");
            webDriver.FindElement(By.XPath("//button[@type='submit']")).SendKeys(Keys.Enter);


        }

        [Test]
        //Email validation
        //Check the Email text field that has an Email address without @ symbol. •
        public void SecondTest()
        {
            IWebDriver webDriver = new ChromeDriver();
            webDriver.Navigate().GoToUrl("https://politrip.com/account/sign-up");
            webDriver.FindElement(By.Name("first-name")).SendKeys("Maria");
            webDriver.FindElement(By.Name("last-name")).SendKeys("Peterson");
            webDriver.FindElement(By.Name("email")).SendKeys("samson.andra.tuiasi.ro");
            webDriver.FindElement(By.Id("sign-up-password-input")).SendKeys("Samson1997");
            webDriver.FindElement(By.Id("sign-up-confirm-password-input")).SendKeys("Samson1997");
            webDriver.FindElement(By.Name("heard")).SendKeys("Web-Search");
            webDriver.FindElement(By.XPath("//button[@type='submit']")).SendKeys(Keys.Enter);
        }

        [Test]
        //Password Validation
        //Check the password limit when enter value less than min
        public void ThirdTest()
        {
            IWebDriver webDriver = new ChromeDriver();
            webDriver.Navigate().GoToUrl("https://politrip.com/account/sign-up");
            webDriver.FindElement(By.Name("first-name")).SendKeys("Maria");
            webDriver.FindElement(By.Name("last-name")).SendKeys("Samson");
            webDriver.FindElement(By.Name("email")).SendKeys("samson.mary@tuiasi.ro");
            webDriver.FindElement(By.Id("sign-up-password-input")).SendKeys("Samson1");
            webDriver.FindElement(By.Id("sign-up-confirm-password-input")).SendKeys("Samson1");
            webDriver.FindElement(By.Name("heard")).SendKeys("Web-Search");
            webDriver.FindElement(By.XPath("//button[@type='submit']")).SendKeys(Keys.Enter);
        }

        [Test]
        //Password Validation
        //Check the password when passing only numbers
        public void FourthTest()
        {
            IWebDriver webDriver = new ChromeDriver();
            webDriver.Navigate().GoToUrl("https://politrip.com/account/sign-up");
            webDriver.FindElement(By.Name("first-name")).SendKeys("Maria");
            webDriver.FindElement(By.Name("last-name")).SendKeys("Samson");
            webDriver.FindElement(By.Name("email")).SendKeys("sam.andreeaac@tuiasi.ro");
            webDriver.FindElement(By.Id("sign-up-password-input")).SendKeys("12345678");
            webDriver.FindElement(By.Id("sign-up-confirm-password-input")).SendKeys("12345678");
            webDriver.FindElement(By.Name("heard")).SendKeys("Web-Search");
            webDriver.FindElement(By.XPath("//button[@type='submit']")).SendKeys(Keys.Enter);
        }

        [Test]
        //Password Validation
        //Check the Email text field that has an Email address without dot symbol. 
        public void FifthTest()
        {
            IWebDriver webDriver = new ChromeDriver();
            webDriver.Navigate().GoToUrl("https://politrip.com/account/sign-up");
            webDriver.FindElement(By.Name("first-name")).SendKeys("Maria");
            webDriver.FindElement(By.Name("last-name")).SendKeys("Samson");
            webDriver.FindElement(By.Name("email")).SendKeys("samson.mary@tuiasiro");
            webDriver.FindElement(By.Id("sign-up-password-input")).SendKeys("Samson1997");
            webDriver.FindElement(By.Id("sign-up-confirm-password-input")).SendKeys("Samson1997");
            webDriver.FindElement(By.Name("heard")).SendKeys("Web-Search");
            webDriver.FindElement(By.XPath("//button[@type='submit']")).SendKeys(Keys.Enter);
        }

        [Test]
        //Password Validation
        //Check if password and confirm password are different
        public void SixthTest()
        {
            IWebDriver webDriver = new ChromeDriver();
            webDriver.Navigate().GoToUrl("https://politrip.com/account/sign-up");
            webDriver.FindElement(By.Name("first-name")).SendKeys("Maria");
            webDriver.FindElement(By.Name("last-name")).SendKeys("Samson");
            webDriver.FindElement(By.Name("email")).SendKeys("sam.mary@tuiasi.ro");
            webDriver.FindElement(By.Id("sign-up-password-input")).SendKeys("Samson1997");
            webDriver.FindElement(By.Id("sign-up-confirm-password-input")).SendKeys("Samson1998");
            webDriver.FindElement(By.Name("heard")).SendKeys("Web-Search");
            webDriver.FindElement(By.XPath("//button[@type='submit']")).SendKeys(Keys.Enter);
        }


        [Test]
        // Check if email is empty
        public void SeventhTest()
        {
            IWebDriver webDriver = new ChromeDriver();
            webDriver.Navigate().GoToUrl("https://politrip.com/account/sign-up");
            webDriver.FindElement(By.Name("first-name")).SendKeys("Maria");
            webDriver.FindElement(By.Name("last-name")).SendKeys("Samson");
            webDriver.FindElement(By.Name("email")).SendKeys("");
            webDriver.FindElement(By.Id("sign-up-password-input")).SendKeys("Samson1997");
            webDriver.FindElement(By.Id("sign-up-confirm-password-input")).SendKeys("Samson1997");
            webDriver.FindElement(By.Name("heard")).SendKeys("Web-Search");
            webDriver.FindElement(By.XPath("//button[@type='submit']")).SendKeys(Keys.Enter);
        }

        //Verify if blank spaces are passed in last name field.
        [Test]
        public void EighthTest()
        {
            IWebDriver webDriver = new ChromeDriver();
            webDriver.Navigate().GoToUrl("https://politrip.com/account/sign-up");
            webDriver.FindElement(By.Name("first-name")).SendKeys("Maria");
            webDriver.FindElement(By.Name("last-name")).SendKeys("");
            webDriver.FindElement(By.Name("email")).SendKeys("petre.andreeaac@tuiasiro");
            webDriver.FindElement(By.Id("sign-up-password-input")).SendKeys("Samson1997");
            webDriver.FindElement(By.Id("sign-up-confirm-password-input")).SendKeys("Samson1997");
            webDriver.FindElement(By.Name("heard")).SendKeys("Web-Search");
            webDriver.FindElement(By.XPath("//button[@type='submit']")).SendKeys(Keys.Enter);
        }


        [Test]
        //Check the Email text field that has a random string instead of a real email.
        public void NinthTest()
        {
            IWebDriver webDriver = new ChromeDriver();
            webDriver.Navigate().GoToUrl("https://politrip.com/account/sign-up");
            webDriver.FindElement(By.Name("first-name")).SendKeys("Maria");
            webDriver.FindElement(By.Name("last-name")).SendKeys("Samson");
            webDriver.FindElement(By.Name("email")).SendKeys("@gmailcom");
            webDriver.FindElement(By.Id("sign-up-password-input")).SendKeys("Samson1997");
            webDriver.FindElement(By.Id("sign-up-confirm-password-input")).SendKeys("Samson1997");
            webDriver.FindElement(By.Name("heard")).SendKeys("Web-Search");
            webDriver.FindElement(By.XPath("//button[@type='submit']")).SendKeys(Keys.Enter);
        }

        [Test]
        // Check the First Name text field that has a number
        public void TenthTest()
        {
            IWebDriver webDriver = new ChromeDriver();
            webDriver.Navigate().GoToUrl("https://politrip.com/account/sign-up");
            webDriver.FindElement(By.Name("first-name")).SendKeys("123");
            webDriver.FindElement(By.Name("last-name")).SendKeys("Samson");
            webDriver.FindElement(By.Name("email")).SendKeys("tom@gmail.com");
            webDriver.FindElement(By.Id("sign-up-password-input")).SendKeys("Samson1997");
            webDriver.FindElement(By.Id("sign-up-confirm-password-input")).SendKeys("Samson1997");
            webDriver.FindElement(By.Name("heard")).SendKeys("Web-Search");
            webDriver.FindElement(By.XPath("//button[@type='submit']")).SendKeys(Keys.Enter);
        }
    }

}