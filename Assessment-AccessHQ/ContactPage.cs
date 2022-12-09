using OpenQA.Selenium;

namespace AccessHQ_Test
{
    internal class ContactPage
    {
        private IWebDriver driver;
        public ContactPage(IWebDriver driver)
        {
            this.driver = driver;
        }
    


        internal void SelectContact()
        {
            driver.FindElement(By.CssSelector("[aria-label=contact]")).Click();
        }

        internal void SelectSubmit()
        {
            driver.FindElement(By.CssSelector("[aria-label=submit]")).Click();
        }

        internal void SetEmail()
        {
            driver.FindElement(By.Id("email")).SendKeys("dan@abc.com");
        }

        internal void SetName()
        {
            driver.FindElement(By.Id("forename")).SendKeys("Dan");
            
        }

        internal void VerifyNoEmailError()
        {
            Assert.AreEqual(expected: "", actual: driver.FindElement(By.ClassName("v-text-field__details")).Text);
        }

        internal void VerifyErrorMessages()
        {
            Assert.AreEqual(expected: "Forename is required", actual: driver.FindElement(By.Id("forename-err")).Text);
            Assert.AreEqual(expected: "Email is required", actual: driver.FindElement(By.Id("email-err")).Text);
            Assert.AreEqual(expected: "Message is required", actual: driver.FindElement(By.Id("message-err")).Text);
        }

        internal void VerifyMessageError()
        {
            Assert.AreEqual(expected: "", actual: driver.FindElement(By.ClassName("v-text-field__details")).Text);
        }

        internal void VerifyNoNameError()
        {
            Assert.AreEqual(expected: "", actual: driver.FindElement(By.ClassName("v-text-field__details")).Text);
        }

        internal void SetMessage()
        {
            driver.FindElement(By.Id("message")).SendKeys("Nice Pizza");
        }
    }
    
}