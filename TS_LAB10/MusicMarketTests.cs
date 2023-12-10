using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using NUnit.Framework;

namespace TS_LAB10
{
    [TestClass]
    public class MusicMarketTests
    {
        private IWebDriver driver;

        [TestInitialize]
        public void TestInitialize()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://musicmarket.by/");
        }

        
        [TestMethod]
        public void ADD_SAMEPRODUCTTOCOMPARE_RETURNEDNOTIFICATION()
        {
            HomePage homePage = new HomePage(driver);
            CurrentGuitarPage currentGuitarPage = new CurrentGuitarPage(driver);
            GuitarsPage guitarsPage = new GuitarsPage(driver);
            ComparisonPage comparisonPage = new ComparisonPage(driver);
            homePage.OpenGuitarsPage();
            guitarsPage.OpenCurrentGuitar();
            currentGuitarPage.AddToComparison();
            homePage.OpenComparisonPage();
            comparisonPage.CleanComparisonList();
            comparisonPage.VerifyClearComparisonList();
        }


        [TestMethod]
        public void ADD_BIGAMOUNTOFPRODUCT_RETURNEDNOTIFICATION()
        {
            HomePage homePage = new HomePage(driver);
            CurrentGuitarPage currentGuitarPage = new CurrentGuitarPage(driver);
            GuitarsPage guitarsPage = new GuitarsPage(driver);
            homePage.OpenGuitarsPage();
            guitarsPage.OpenCurrentGuitar();
            currentGuitarPage.WriteAmountOfProduct("99999");
            homePage.VerifyPopedUpWarningNotification();
        }


        [TestCleanup]
        public void TestCleanup()
        {
            driver.Quit();
        }
    }
}