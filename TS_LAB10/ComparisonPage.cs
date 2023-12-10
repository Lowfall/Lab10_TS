using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TS_LAB10
{
    public class ComparisonPage
    {
        private IWebDriver driver;
        private readonly By cleanComparisonListButton =By.XPath("//*[@id=\"tygh_main_container\"]/div[3]/div/div[2]/div/div/div/div/div[1]/div/a[3]");
        private readonly By noItemsElement = By.ClassName("ty-no-items");

        public ComparisonPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void CleanComparisonList()
        {
            driver.FindElement(cleanComparisonListButton).Click();
        }
        public void VerifyClearComparisonList()
        {
            Assert.IsTrue(driver.FindElement(noItemsElement) != null);
        }
    }
}
