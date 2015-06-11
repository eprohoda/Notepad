using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
        
        [When(@"I enter text in Notepad")]
        public void WhenIEnterTextInNotepad()
        {
			IWebElement query = driver.FindElement(By.Id("area"));
			query.SendKeys("text123");
	        //Thread.Sleep(5000);
	        

        }

		[When(@"I click Save button")]
		public void WhenIClickSaveButton()
		{
			IWebElement savebutton = driver.FindElement(By.Name("B3"));
			savebutton.Click();
			Thread.Sleep(5000);
		}


		[Then(@"I see Filename field")]
		public void ThenISeeFilenameField()
		{
			//IWebElement savefield = driver.FindElement(By.Id("filename"));
		}

		
		[When(@"I enter File Name")]
		public void WhenIEnterFileName()
		{
			IWebElement savefield = driver.FindElement(By.Id("filename"));
			savefield.Click();
			savefield.SendKeys("text");
		}


		[When(@"I click Save button to save File")]
		public void WhenIClickSaveButtonToSaveFile()
		{
			IWebElement savebutton = driver.FindElement(By.Id("save"));
			savebutton.Click();

		}

		[When(@"I wait some time")]
		public void WhenIWaitSomeTime()
		{
			//driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.(1));
			Thread.Sleep(5000);
		}


		[When(@"I close browser")]
	    public void WhenICloseBrowser()
	    {
		    driver.Close();
	    }



	    ///// Test2 definitions //////

	    [Then(@"I see button New")]
	    public void ThenISeeButtonNew()
	    {
		    driver.FindElement(By.Name("B1"));
	    }

	    [Then(@"I see button Open")]
		public void ThenISeeButtonOpen()
		{
			driver.FindElement(By.Name("B2"));
		}

		[Then(@"I see button Save")]
		public void ThenISeeButtonSave()
		{
			driver.FindElement(By.Name("B3"));
		}


		[When(@"I click New button")]
		public void WhenIClickNewButton()
		{
			IWebElement newbutton = driver.FindElement(By.Name("B1"));
			newbutton.Click();
		}

		[When(@"I click Undo button")]
		public void WhenIClickUndoButton()
		{
			IWebElement undobutton = driver.FindElement(By.Name("B7"));
			undobutton.Click();
		}

		[When(@"I click Redo button")]
		public void WhenIClickRedoButton()
		{
			IWebElement redobutton = driver.FindElement(By.Name("B8"));
			redobutton.Click();
		}


	}
}
