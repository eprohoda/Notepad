using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Xml.Linq;
using TechTalk.SpecFlow;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.Extensions;

namespace Notepad
{
	[Binding]
    public class Notepad1steps
    {
		IWebDriver driver = new ChromeDriver();

        
		[Given(@"Notepad window is opened")]
        public void GivenNotepadWindowIsOpened()
        {
			driver.Navigate().GoToUrl("http://www.rapidtables.com/tools/notepad.htm");
			//Check that the Title is what we are expecting
			Assert.AreEqual("Online Notepad - free, no login required", driver.Title);
			Thread.Sleep(2000);
        }
        
        [When(@"I enter ""(.*)"" text")]
        public void WhenIEnterTextInNotepad(string text)
        {
			IWebElement query = driver.FindElement(By.Id("area"));
			query.SendKeys(text);
        }

		
		[When(@"I click ""(.*)"" button")]
		public void WhenIClickButton(string p0)
		{
			string p1="";
			if (p0 == "New") {p1 = "B1";}
			if (p0 == "Open") { p1 = "B2"; }
			if (p0 == "Save") { p1 = "B3"; }
			if (p0 == "Cut") { p1 = "B4"; }
			if (p0 == "Copy") { p1 = "B5"; }
			if (p0 == "Paste") { p1 = "B6"; }
			IWebElement button = driver.FindElement(By.Name(p1));
			button.Click();
		}

		[When(@"I enter File Name")]
		public void WhenIEnterFileName()
		{
			IWebElement savefield = driver.FindElement(By.Id("filename"));
			savefield.Click();
			savefield.SendKeys("FileName1");
			driver.FindElement(By.Id("save")).Click();
		}

	    
		[Then(@"I see ""(.*)"" button")]
		public void ThenISeeButton(string p0)
		{
			string p1 = "";
			if (p0 == "New") { p1 = "B1"; }
			if (p0 == "Open") { p1 = "B2"; }
			if (p0 == "Save") { p1 = "B3"; }
			if (p0 == "Cut") { p1 = "B4"; }
			if (p0 == "Copy") { p1 = "B5"; }
			if (p0 == "Paste") { p1 = "B6"; }
			driver.FindElement(By.Name(p1));
		}
 
	
		[When(@"I wait ""(.*)"" msec")]
		public void WhenIWaitSomeTime(int msec)
		{
			Thread.Sleep(msec);
		}


		[When(@"I close browser")]
		public void WhenICloseBrowser()
		{
			driver.Close();
		}


		public string Null { get; set; }
	}
}
