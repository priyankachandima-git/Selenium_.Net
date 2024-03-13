using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Selenium_CSharp
{
    public class FirstTest : BaseUtil
    {
        [Test]
        public void FirstTestCase()
        {
            Console.WriteLine("First Test");
        }
    }
}

