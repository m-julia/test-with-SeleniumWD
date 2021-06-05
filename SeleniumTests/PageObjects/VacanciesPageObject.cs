using OpenQA.Selenium;
using System.Linq;

namespace SeleniumTests.PageObjects
{
    public class VacanciesPageObject
    {
        private IWebDriver _webDriver;

        private readonly By _allDepartmentsButton = By.XPath("//button[text()='Все отделы']");
        private readonly By _drpDepartmentsSelect = By.CssSelector("a.dropdown-item");
        private readonly By _allLanguagesButton = By.XPath("//button[text()='Все языки']");
        private readonly By _drpLanguagesSelect = By.CssSelector("label.custom-control-label");
        private readonly By _allVacancies = By.CssSelector("a.card");
        public VacanciesPageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }
        public void SelectDepartment(string departmentName)
        {
            _webDriver.FindElement(_allDepartmentsButton).Click();
            _webDriver.FindElements(_drpDepartmentsSelect).First(x => x.Text == departmentName).Click(); ;
        }
        public void RelectLanguage(string languageName)
        {
            _webDriver.FindElement(_allLanguagesButton).Click();
            _webDriver.FindElements(_drpLanguagesSelect).First(x => x.Text == languageName).Click();

        }
        public int GetVacanciesAmount()
        {
            int vacanciesAmount = _webDriver.FindElements(_allVacancies).Count();
            return vacanciesAmount;
        }
    }
}
