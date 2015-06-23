using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
namespace Notepad
{
	[Binding]
	public class WebBrowser
	{
		public static IWebDriver Current
		{
					
			get
			{
				if (!ScenarioContext.Current.ContainsKey("browser"))
				{
					ScenarioContext.Current["browser"] = new ChromeDriver();
				}
				return (IWebDriver)ScenarioContext.Current["browser"];
			}
		}

	}
}