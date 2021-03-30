using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace UnitTestProject1
{
    [TestFixture]
    public class UnitTest1
    {
        private IWebDriver driver;
        private WebDriverWait wait;


        [SetUp]
        public void Start()
        {
            driver = new ChromeDriver(@"C:\\Tools");
            //wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        [Test]
        public void TestMethod1()
        {
            driver.Url = "https://www.yandex.ru/";
            driver.FindElement(By.Name("text")).SendKeys("Тестирование");
            driver.FindElement(By.Name("text")).SendKeys(Keys.Enter);
            //wait.Until(ExpectedConditions.TitleIs(""));
        }

        [TearDown]
        public void Stop()
        {
            driver.Quit();
            driver = null;
        }
    }
}
