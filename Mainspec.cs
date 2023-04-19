using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager;


namespace SeleniumCsharpNunit
{
    public class MainSpec
    {
        private IWebDriver wDriver;

        [SetUp]
        public void Setup()
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
            wDriver = new ChromeDriver();
        }

        [Test]
        public void Test1()
        {
            wDriver.Navigate().GoToUrl("https://www.google.com");
            Assert.AreEqual(wDriver.Title,"Google");
        }
    }
}