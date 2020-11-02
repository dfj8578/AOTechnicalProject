using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AOTechnicalTtest
{
    class ListerPage
    {
        public ListerPage()
        {
            PageFactory.InitElements(PropertiesCollections.driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Medium: 7-9kg')]")]
        public IWebElement Filterlist { get; set; }

        public void NavigateToListerPage()
        {
            Filterlist.Click();
        }

        /* Assert The Results AreSuccessfully FilteredBased OnYourSelectionCriteriae */

        public void SelectionResultBasedonCriteria(string SelectionCriteria)
        {
            var FilterBasedonSelection = PropertiesCollections.driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/main[1]/div[2]/div[1]/div[2]/header[1]/h1[1]")).Text;
            Assert.AreEqual(FilterBasedonSelection, SelectionCriteria);
        }
    }
}
