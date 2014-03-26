using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support;
using NUnit.Framework;

namespace FRCSearchTests
{
	public class Class1
	{
		public IWebDriver driver;
		[SetUp]
		public void setup()
		{
			driver = new FirefoxDriver();
		}
		[TearDown]
		public void Teardown()
		{
			driver.Quit();
		}
		[TestCase]
		public void MyFRCTest1(string MyFRCTest1)
		{
			driver.Navigate().GoToUrl("http://www.forrent.com");
			System.Threading.Thread.Sleep(500);

			driver.FindElement(By.Id("cityState")).SendKeys("Valencia Park");
			System.Threading.Thread.Sleep(500);

			driver.FindElement(By.Id("searchMatch0-hcard")).Click();
			System.Threading.Thread.Sleep(500);

			driver.FindElement(By.XPath("//div[@class='bvMediaTrayIcon']"));


			Assert.True(driver.Url.Equals("http://thumbs.frmonline.com/imgs/fr/propertyFiles/408/000/1/resized/01_138514015508240950142008275001000.jpg"));

		}
	}
}
