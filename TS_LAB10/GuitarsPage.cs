using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TS_LAB10
{
    public class GuitarsPage
    {
        private IWebDriver driver;
        private readonly By currentGuitarButton = By.XPath("//*[@id=\"categories_view_pagination_contents\"]/div[1]/div/form/div/div[1]/a");

        public GuitarsPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void OpenCurrentGuitar()
        {
            driver.FindElement(currentGuitarButton).Click();
        }
    }
}
