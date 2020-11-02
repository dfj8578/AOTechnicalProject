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
   public class SearchProductHmPage
    {
        public SearchProductHmPage()
        {
            PageFactory.InitElements(PropertiesCollections.driver, this);

        }

        [FindsBy(How = How.XPath, Using = "//input[@id='siteSearch-input']")]
        public IWebElement SearchProductinput { get; set; }

        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/div[1]/div[1]/header[1]/div[1]/div[1]/div[1]/div[2]/div[3]/div[1]/div[1]/div[1]/div[2]/ul[2]/li[1]")]
        public IWebElement SearchButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//body/div[@id='holder']/div[@id='container']/div[@id='contentholder']/div[@id='nocolumns']/div[@id='categoryPage']/section[@id='category-brands']/div[1]/div[1]/ul[1]/li[2]/a[1]")]
        public IWebElement SelectBrand { get; set; }





        public void AOSearchInput()
        {
            SearchProductinput.SendKeys("Washing Machines");
            Thread.Sleep(10000);
        }

        public void Searchbtn()
        {
            
            SearchButton.Click();
        }



        public void ClickonBrand()
        {

            Thread.Sleep(10000);
            SelectBrand.Click();


        }
    }
}
