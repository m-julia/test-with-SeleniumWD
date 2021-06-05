using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumTests
{
    public class BaseTest
    {
        protected IWebDriver _webDriver;

        [OneTimeSetUp]
        protected void ExecuteBeforeAllTests()
        {
            _webDriver = new ChromeDriver(@"C:");
        }

        [SetUp]
        protected void ExecuteBeforeEachTest()
        {
            _webDriver.Manage().Cookies.DeleteAllCookies();
            _webDriver.Navigate().GoToUrl(TestSettings.VacanciesURL);
            _webDriver.Manage().Window.Maximize();
        }

        [TearDown]
        protected void ExecuteAfterEachTest()
        {
            _webDriver.Quit();
        }
    }
}
