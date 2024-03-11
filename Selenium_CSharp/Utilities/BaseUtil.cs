using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Selenium_DotNe_FrmWrk
{
    public class BaseUtil
    {

        public IWebDriver driver;

        public string baseUrl = ConfigurationHelper.GetAppSetting("BaseUrl");

        [SetUp]
        public void TestSetup()
        {
            if (string.IsNullOrEmpty(baseUrl))
            {
                throw new InvalidOperationException("Base URL is missing or empty in the configuration.");
            }
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl(baseUrl);
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(30);
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
            driver.Dispose();
        }

        public void Open(string pageName, string url="'")
        {
            if(url.Contains("https://"))
                driver.Navigate().GoToUrl(url);
            else{
                driver.Navigate().GoToUrl(baseUrl+ PagesUrlMapping(pageName));
            }
        }
        public bool AmOn(string pageName)
        {
            try
            {
                if (driver.FindElement(By.TagName("body")).GetAttribute("class").Contains(PagesIdentifierMapping(pageName)))
                    return true;
            }
            catch (NoSuchElementException ex)
            {
                Console.WriteLine("Element not found: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
            return false;
        }

        // public void See(locator)
        // {
        //     if(locator.includes('/')) {
        //         cy.xpath(locator, {timeout: 20000}).then(($element) => {
        //             if($element.is(':visible'))
        //                 return
        //             else
        //                 assert.isTrue(false, "Element: " + locator.toString() + " is not visible")
        //         })
        //     }
        //     else {
        //         cy.get(locator, {timeout: 20000}).then(($element) => {
        //             if($element.is(':visible'))
        //                 return
        //             else
        //                 assert.isTrue(false, "Element: " + locator.toString() + " is not visible")
        //         })
        //     }
        // }
// /**
//  * @param locator : string element
//  *  @summary :Verify web element not exist
//  */
// public void DontSee(locator) {
//     if (locator.includes('//'))
//         cy.xpath(locator).should('not.exist')
//     else
//         cy.get(locator).should('not.exist')
// }
// /**
//  * @param locator : string web element
//  * @param attribute : html attribute
//  * @param value : attribute value
//  *  @summary :Verify web element attribute has given value
//  */
// public void SeeAttributeValue(locator, attribute, value)
// {
//     if(locator.includes('/')) {
//         cy.xpath(locator, {timeout: 20000}).then(($element) => {
//             if($element.invoke('attr', attribute).should('eq', value))
//                 return
//             else
//                 assert.isTrue(false, "Element: " + locator.toString() + "attribute "+attribute.toString()+ " is not present")
//         })
//     }
//     else {
//         cy.get(locator, {timeout: 20000}).then(($element)=> {
//             if(cy.get(locator).invoke('attr', attribute).should('eq', value))
//                 return
//             else
//                 assert.isTrue(false, "Element: " + locator.toString() + "attribute "+attribute.toString()+ " is not present")
//         })
//     }
// }

// /**
//  * @param locator : Web element
//  * @param text : input text
//  *  @summary :type given input value and press enter key
//  */
// public void FillAndPressEnter(locator, text){
//     cy.get(locator).type(text+"{enter}")
// }

// /**
//  * @param locator : string element
//  *  @summary :click on given web element
//  */
// public void Click(locator)
// {
//     if(locator.includes('//')) {
//         cy.xpath(locator).then(($element) => {
//             if($element.is(":visible"))
//                 cy.xpath(locator).click()
//             else
//                 cy.xpath(locator).click({force:true})
//         })
//     }
//     else
//     {
//         cy.get(locator).then(($element) => {
//             if($element.is(":visible"))
//                 cy.get(locator).click()
//             else
//                 cy.get(locator).click({force:true})
//         })
//     }
// }

// /**
//  * @param miliSeconds : number of millisecond to wait
//  *  @summary : pause execution upto given time
//  */
// public void Wait(miliSeconds)
// {
//     cy.wait(miliSeconds)
// }

// /**
//  * @param locator : web element
//  * @param text : input text
//  * @summary : insert text to given web element
//  */
// public void Fill(locator, text)
// {
//     if(locator.includes('//')) {
//         cy.xpath(locator).then(($element) => {
//             if($element.is(":visible"))
//                 cy.xpath(locator).type(text)
//             else
//                 cy.xpath(locator).type(text,{force:true})
//         })
//     }
//     else
//     {
//         cy.get(locator).then(($element) => {
//             if($element.is(":visible"))
//                 cy.get(locator).type(text)
//             else
//                 cy.get(locator).type(text,{force:true})
//         })
//     }
// }

// public void ClearAndFill(locator, text)
// {
//     if(locator.includes('//'))
//     {
//         cy.xpath(locator).then(($element) => {
//             if($element.is(":visible"))
//                 cy.xpath(locator).clear()
//             else
//                 cy.xpath(locator).clear({force:true})
//         })
//         cy.xpath(locator).then(($element) => {
//             if($element.is(":visible"))
//                 cy.xpath(locator).type(text)
//             else
//                 cy.xpath(locator).type(text,{force:true})
//         })
//     }
//     else
//     {
//         cy.get(locator).then(($element) => {
//             if($element.is(":visible"))
//                 cy.get(locator).clear()
//             else
//                 cy.get(locator).clear({force:true})
//         })
//         cy.get(locator).then(($element) => {
//             if($element.is(":visible"))
//                 cy.get(locator).type(text)
//             else
//                 cy.get(locator).type(text,{force:true})
//         })
//     }
// }

// public void MouseHover(locator)
// {
//     if(locator.includes('//'))
//         cy.xpath(locator).trigger('mouseover')
//     else
//         cy.get(locator).trigger('mouseover')
// }

// public void SeeText(locator, expectedText)
// {
//     if(locator.includes('//'))
//         cy.xpath(locator).eq(0).should('have.text', expectedText)
//     else
//         cy.get(locator).eq(0).should('have.text', expectedText)
// }

// public void SeeValue(locator, expectedValue)
// {
//     if(locator.includes('//'))
//         cy.xpath(locator).should('have.attr', 'value').should('contain', expectedValue)
//     else
//         cy.get(locator).should('have.attr', 'value').should('contain', expectedValue)
// }

// public void DontSeeText(locator, expectedText)
// {
//     if(locator.includes('//'))
//         cy.xpath(locator).eq(0).should('not.have.text', expectedText)
//     else
//         cy.get(locator).eq(0).should('not.have.text', expectedText)
// }

// public void Check(locator, option)
// {
//     if(locator.includes('//'))
//         cy.xpath(locator).check(option)
//     else
//         cy.get(locator).check(option)
// }

public string PagesUrlMapping(string pageName)
{
    switch(pageName)
    {
        case "MainScreen":
            return "";
    }
    return "";
}

public string PagesIdentifierMapping(string pageName)
{
    switch(pageName)
    {
        case "MainScreen":
            return "";
    }
    return "";
}
 }


}

