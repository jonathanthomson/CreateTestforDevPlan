using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using NUnit.Framework;

namespace MyGoogleSearchTest
{
    public class Class1
    {
		public IWebDriver driver;
	[SetUp]
	public void setup()
	{
		driver = new ChromeDriver();
	}
	[TearDown]
	public void Teardown()
	{
		driver.Quit();
	}
	//[TestCase("Gmail - Email from Google")]  //searchString = Google
	//public void MyGoogleTest(string MyGoogleTest)
	//{
	//	driver.Navigate().GoToUrl("http://www.google.com");
	//	System.Threading.Thread.Sleep(500);
	//	driver.FindElement(By.XPath("//a[@href='https://mail.google.com/mail/?tab=wm']")).Click();
	//	System.Threading.Thread.Sleep(500);

	//	Assert.True(driver.Title.Contains("Gmail - Email from Google"));
	//}
	[TestCase("charlie bit me - Google Search")]
	public void MyGoogleTest2(string MyGoogleTest2)
	{
		driver.Navigate().GoToUrl("http://www.google.com");
		System.Threading.Thread.Sleep(500);
		driver.FindElement(By.Id("gbqfq")).SendKeys("Charlie Bit Me");
		System.Threading.Thread.Sleep(500);
		driver.FindElement(By.Id("gsr"));

		Assert.True(driver.Title.Contains("Google"));

	}




    }
}
