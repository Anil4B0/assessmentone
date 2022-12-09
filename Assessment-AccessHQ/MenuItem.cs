using OpenQA.Selenium;

namespace AccessHQ_Test
{
    internal class MenuItem
    {
        private IWebDriver driver;
        public MenuItem(IWebDriver driver)
        {
            this.driver = driver;
        }

        internal void SelectChunkyChipsAioli()
        {
            foreach (var chipsTile in driver.FindElements(By.ClassName("v-sheet")))
            {
                if (chipsTile.FindElement(By.ClassName("description")).Text.ToLower() == "Chunky cut chips served with aioli dipping sauce") ;
                {
                    Assert.AreEqual(expected: chipsTile.FindElement(By.ClassName("kilojoules")).Text.ToString(), actual: "3273");
                    Assert.AreEqual(expected: chipsTile.FindElement(By.ClassName("price")).Text.ToString(), actual: "9.99");
                }
            }
        }

        internal void SelectMenu()
        {
            driver.FindElement(By.CssSelector("[aria-label=menu]")).Click();
        }

        internal void SelectSides()
        {
            foreach(var tabsTile in driver.FindElements(By.ClassName("v-slide-group__content")))
            {
                if (tabsTile.FindElement(By.CssSelector("[role=tab]")).Text.ToLower() == "sides")
                {
                    tabsTile.FindElement(By.ClassName("v-icon")).Click();
                }
            }

        }
    }
}