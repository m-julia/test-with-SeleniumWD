using NUnit.Framework;
using SeleniumTests;
using SeleniumTests.Data;
using SeleniumTests.PageObjects;

namespace TestProject1
{
    [TestFixture]
    public class VacanciesPageTests : BaseTest
    {
        [Test]
        public void FilterVacancies_ByDepartmentAndLanguage_ReturnVoid()
        {
            VacanciesPageObject vacancies = new(_webDriver);
            vacancies.SelectDepartment(DepartmentsName.ProductDevelopment);
            vacancies.RelectLanguage(LanguagesName.English);

            int actualVacanciesAmount = vacancies.GetVacanciesAmount();
            Assert.AreEqual(ExpectedParameters.ExpectedVacanciesAmount, actualVacanciesAmount, "The expected result is not equal to the actual result");
        }
    }
}
