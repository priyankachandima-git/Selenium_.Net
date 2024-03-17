using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Safari;
using OpenQA.Selenium.Support.UI;

namespace Selenium_CSharp
{
    public class BaseUtil
    {
        public static IWebDriver driver;
        public static string baseUrl = ConfigurationHelper.GetAppSetting("BaseUrl");
        public static string browser = ConfigurationHelper.GetAppSetting("Browser");
        public static SeleniumUtil I = new SeleniumUtil();
        public static TodoAppFrontPage todoAppFrontPage = new TodoAppFrontPage();

        [SetUp]
        public void TestSetup()
        {  
            if (string.IsNullOrEmpty(baseUrl))
            {
                throw new InvalidOperationException("Base URL is missing or empty in the configuration.");
            }
            if (browser != null) {
                switch (browser) {
                    case "chrome":
                        driver = new ChromeDriver();
                        break;
                    case "chrome-headless":
                        var chromeOptions = new ChromeOptions();
                        chromeOptions.AddArgument("--headless");
                        driver = new ChromeDriver(chromeOptions);
                        break;
                    case "firefox":
                        driver = new FirefoxDriver();
                        break;
                    case "firefox-headless":
                        var firefoxOptions = new FirefoxOptions();
                        firefoxOptions.AddArgument("--headless");
                        driver = new FirefoxDriver(firefoxOptions);
                        break;
                    case "safari":
                        driver = new SafariDriver();
                        break;
                    case "":
                        throw new Exception("browser parameter should be either \"chrome \\ safari \\ firefox\" in appsettings.jso");
                }
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(baseUrl);
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(30);
            }else{
                throw new Exception("browser parameter is not configured in testng.xml");
            }
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
            driver.Dispose();
        }
    }
}

