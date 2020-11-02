using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace AOTechnicalTtest
{
    [Binding]

     class AOHomepageSteps
    {
        IWebDriver driver;

        [Given(@"When i Navigate to AO homepage")]
        public void GivenWhenINavigateToAOHomepage()
        {
           SearchProductHmPage AOSearchProdhmPage = new SearchProductHmPage();
          // driver = new ChromeDriver();
          // driver.Navigate().GoToUrl("https://ao.com/");
           //driver.Manage().Window.Maximize();

        }

        [Given(@"i enter the Search Keyword in the Search Text Box")]
        public void GivenIEnterTheSearchKeywordInTheSearchTextBox(Table table)
        {

            SearchProductHmPage AOSearchProdhmPage = new SearchProductHmPage();
            AOSearchProdhmPage.AOSearchInput();
           
           //string searchText = table.Rows[0]["Keyword"].ToString();
           // Thread.Sleep(5000);
          // driver.FindElement(By.XPath("//input[@id='siteSearch-input']")).SendKeys(searchText);

        }

        [Given(@"I should Click on Search Button")]
        public void GivenIShouldClickOnSearchButton()
        {
             SearchProductHmPage AOSearchProdhmPage = new SearchProductHmPage();
             AOSearchProdhmPage.Searchbtn();

            //Thread.Sleep(5000);
            //driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/header[1]/div[1]/div[1]/div[1]/div[2]/div[3]/div[1]/div[1]/div[1]/div[2]/ul[2]/li[1]")).Click();
        }


        [Then(@"i should select a Brand Name ""(.*)"" to navigate to Lister page")]
        public void ThenIShouldSelectABrandNameToNavigateToListerPage(string p0)
        {
            SearchProductHmPage AOSearchProdhmPage = new SearchProductHmPage();
            Thread.Sleep(10000);
            AOSearchProdhmPage.ClickonBrand();




            // Thread.Sleep(10000);
            // driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/header[1]/div[1]/div[1]/div[1]/div[2]/div[3]/div[1]/div[1]/div[1]/div[1]/div[1]/button[1]/span[1]")).Click();

        }

        [Then(@"i Filter the product by its ""(.*)""")]
        public void ThenIFilterTheProductByIts(string p0)
        {
            SearchProductHmPage AOSearchProdhmPage = new SearchProductHmPage();
            ListerPage FilterProductonListPage = new ListerPage();
            Thread.Sleep(5000);
            FilterProductonListPage.Filterlist.Click();
            

            // Thread.Sleep(5000);
            // driver.FindElement(By.XPath("//span[contains(text(),'Medium: 7-9kg')]")).Click();
        }

        [Then(@"i Verify the results are successfully filtered based on your selection criteria")]
        public void ThenIVerifyTheResultsAreSuccessfullyFilteredBasedOnYourSelectionCriteria()
        {
            SearchProductHmPage AOSearchProdhmPage = new SearchProductHmPage();
            ListerPage FilterProductonListPage = new ListerPage();
            Thread.Sleep(5000);
            FilterProductonListPage.SelectionResultBasedonCriteria("Hotpoint Washing Machines with 7 Kg, 8 Kg, 9 Kg wash load");
           // Thread.Sleep(5000);
           // Assert.AreEqual("Hotpoint Washing Machines with 7 Kg, 8 Kg, 9 Kg wash load", driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/main[1]/div[2]/div[1]/div[2]/header[1]/h1[1]")).Text);

        }

       // [Then(@"i click on Add to Basket Button")]
      //  public void ThenIClickOnAddToBasketButton()
      //  {
         //   Thread.Sleep(10000);
         //   driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/main[1]/div[2]/div[1]/div[2]/section[1]/ul[1]/li[1]/div[1]/div[2]/div[1]/div[1]/div[1]/div[3]/div[2]/div[1]/button[1]")).Click();
      //  }

      //  [Then(@"i click on CheckOut Button")]
       // public void ThenIClickOnCheckOutButton()
      //  {
         //   Thread.Sleep(10000);
         //   IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
          //  js.ExecuteScript("window. scrollBy(0,750)", "");
         //   driver.FindElement(By.CssSelector("#basket > div.checkoutNowHolder.bottomButton > a.primaryButton.checkoutNowButton.hasArrow.after-hidden.cta.cta-lg.flex.justify-around.pb-1")).Click();
       // }



    }
}
