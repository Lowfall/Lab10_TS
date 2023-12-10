using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TS_LAB10
{
    public class HomePage
    {
        private IWebDriver driver;

        private readonly By guitarCategoryButton = By.XPath("//*[@id=\"tygh_main_container\"]/div[2]/div/div[2]/div/div/div/div/div/div/ul/div[1]/li[1]/a");
        private readonly By comparisonButton = By.XPath("//*[@id=\"abt__ut2_compared_products\"]/a");
        private readonly By cartButton = By.XPath("//*[@id=\"cart_icon_1288\"]");
        private readonly By warningNotification = By.XPath("//*[@id=\"tygh_container\"]/div[3]/div");

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void OpenGuitarsPage()
        {
            driver.FindElement(guitarCategoryButton).Click();
        }

        public void OpenComparisonPage()
        {
            driver.FindElement(comparisonButton).Click();
        }

        public void OpenCartPage()
        {
            driver.FindElement(cartButton).Click();
        }

        public void VerifyPopedUpWarningNotification()
        {
            Assert.IsTrue(driver.FindElement(warningNotification) != null);
        }

    }
}
