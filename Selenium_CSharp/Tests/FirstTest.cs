using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace Selenium_CSharp
{
    public class FirstTest : BaseUtil
    {
        [Test]
        [Description("As a user I should be able to access TODOS application")]
        public void Navigate_to_TODOS_application()
        {
            I.Open(todoAppFrontPage.Url);
            I.AmOn(todoAppFrontPage.Identifier);
        }
    }
}

