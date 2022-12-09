using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
namespace AccessHQ_Test
{
    [TestClass]
    public class TestOne
    {

        private IWebDriver driver;

        [TestInitialize]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Url = "https://d3nay7txmslpgb.cloudfront.net/";
            driver.Manage().Window.Maximize();
        }

        [TestMethod]
        public void NavigationHomePage()
        {
            var contactPage = new ContactPage(driver);
            contactPage.SelectContact();
            contactPage.SelectSubmit();
            contactPage.VerifyErrorMessages();
            contactPage.SetName();
            contactPage.VerifyNoNameError();
            contactPage.SetEmail();
            contactPage.VerifyNoEmailError();
            contactPage.SetMessage();
            contactPage.VerifyMessageError();
        }

        [TestMethod]
        public void NavigationMenuPage() 
        {
            var menuPage = new MenuItem(driver);
            menuPage.SelectMenu();
            menuPage.SelectSides();
            menuPage.SelectChunkyChipsAioli();

        }
    }
}

