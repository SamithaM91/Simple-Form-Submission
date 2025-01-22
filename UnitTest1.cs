using NUnit;
using NUnit.Framework.Internal;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;

namespace Form_Submission
{
    public class Tests   
    {
        IWebDriver driver;
       

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://demoqa.com/automation-practice-form";
            Assert.That(driver.Title, Is.EqualTo("DEMOQA"));
        }

        [Test]
        public void Test_FormSubmission()
        {
            driver.Navigate().GoToUrl(driver.Url);
            
            driver.FindElement(By.Id("firstName")).Clear();
            IWebElement first_nameTextbox = new WebDriverWait(driver, TimeSpan.FromSeconds(10)).Until(ExpectedConditions.ElementIsVisible(By.Id("firstName")));
            first_nameTextbox.SendKeys("Samitha");

            driver.FindElement(By.Id("lastName")).Clear();
            IWebElement last_nameTextbox = new WebDriverWait(driver, TimeSpan.FromSeconds(5)).Until(ExpectedConditions.ElementIsVisible(By.Id("lastName")));
            last_nameTextbox.SendKeys("Maddekanda");

            driver.FindElement(By.Id("userEmail")).Clear();
            IWebElement email = new WebDriverWait(driver, TimeSpan.FromSeconds(5)).Until(ExpectedConditions.ElementIsVisible(By.Id("userEmail")));
            email.SendKeys("smaddekanda91@gmail.com");
            //Assert.Pass();

          //  driver.FindElement(By.Name("gender")).Click();


            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
        }

        [TearDown]
        public void TearDown() { 
        
            driver.Dispose();
        }
    }
}