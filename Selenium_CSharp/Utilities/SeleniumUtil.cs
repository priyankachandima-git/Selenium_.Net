using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;


namespace Selenium_CSharp
{
    public class SeleniumUtil : BaseUtil
    {
        public void Open(string url="'")
        {
           driver.Navigate().GoToUrl(baseUrl+url);
        }
        public void AmOn(By pageIdentifire)
        {
            try
            {
               driver.FindElement(pageIdentifire);
            }
            catch (NoSuchElementException ex)
            {
                Console.WriteLine("Element not found: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
        
        public void See(By locatorBy)
        {
            try
            {
               Assert.That(driver.FindElement(locatorBy).Displayed, Is.True, "Element is not visible");;
            }
            catch (NoSuchElementException ex)
            {
                Console.WriteLine("Element not found: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }

        public void SeeAttributeValue(By locatorBy, string attribute, string expectedValue)
        {
            try
            {
                string actualValue = driver.FindElement(locatorBy).GetAttribute(attribute);
                Assert.That(actualValue, Is.EqualTo(expectedValue), "Expected "+expectedValue+" But found "+actualValue+". ");
            }
            catch (StaleElementReferenceException ex)
            {
                Console.WriteLine("Issue with element: " + ex.Message);
            }
            catch (NoSuchElementException ex)
            {
                Console.WriteLine("Element not found: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }

        public void Click(By locatorBy)
        {
            try
            {
               driver.FindElement(locatorBy).Click();
            }
            catch (NoSuchElementException ex)
            {
                Console.WriteLine("Element not found: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
        public void DontSeet(By locatorBy)
        {
            try
            {
                //Wait(4).Until(ExpectedConditions.InvisibilityOfElementLocated(locatorBy));
            }
            catch (NoSuchElementException)
            {
                return;
            }
            Assert.Fail("Element exists when it shouldn't");
        }
    
        public WebDriverWait Wait(int seconds)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(seconds));
            return wait;
        }

        public void Fill(By locatorBy, string text)
        {
            try
            {
              driver.FindElement(locatorBy).SendKeys(text);
            }
            catch (NoSuchElementException ex)
            {
                Console.WriteLine("Element not found: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }   
        }

        public void ClearAndFill(By locatorBy, string text)
        {
            try
            {
                driver.FindElement(locatorBy).Clear();
                driver.FindElement(locatorBy).SendKeys(text);
            }
            catch (NoSuchElementException ex)
            {
                Console.WriteLine("Element not found: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }   
        }

        public void Clear(By locatorBy, string text)
        {
            try
            {
                driver.FindElement(locatorBy).Clear();
            }
            catch (NoSuchElementException ex)
            {
                Console.WriteLine("Element not found: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }   
        }
        public void MouseHover(By locatorBy)
        {
        
        }
        public void SeeText(By locatorBy, string expectedText)
        {
            try
            {
                string actualText = driver.FindElement(locatorBy).Text;
                Assert.That(actualText, Is.EqualTo(expectedText), "Expected "+expectedText+" But found "+actualText+". ");
            }
            catch (StaleElementReferenceException ex)
            {
                Console.WriteLine("Issue with element: " + ex.Message);
            }
            catch (NoSuchElementException ex)
            {
                Console.WriteLine("Element not found: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
        public void DontSeeText(By locatorBy, string expectedText)
        {

        }
    }
}

