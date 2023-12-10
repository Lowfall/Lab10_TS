using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TS_LAB10
{
    internal class CurrentGuitarPage
    {
        private IWebDriver driver;
        private readonly By addToCompareButton = By.XPath("//*[@id=\"add_to_cart_update_29807\"]/a[2]");
        private readonly By amountTextBox = By.XPath("//*[@id=\"qty_count_29807\"]");
        private readonly By addToCartButton = By.XPath("//*[@id=\"button_cart_29807\"]");
        public CurrentGuitarPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void AddToComparison()
        {
            driver.FindElement(addToCompareButton).Click();
            Thread.Sleep(9000);
            //WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(9));
            //wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.InvisibilityOfElementLocated(popUpWindow));
        }

        public void WriteAmountOfProduct(string amount)
        {
            driver.FindElement(amountTextBox).SendKeys(amount);
            driver.FindElement(addToCartButton).Click();
            Thread.Sleep(2000);
        }
    }
}
