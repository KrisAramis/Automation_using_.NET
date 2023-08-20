using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Selenium_Basics;

public class EpamNavigationTests
{
    private IWebDriver _driver;
    private const string _epamLandingUrl = "https://www.epam.com";
    
    [SetUp]
    public void SetupBrowser()
    {
        _driver = new ChromeDriver();
        _driver.Manage().Window.Maximize();
    }

    [Test]
    public void VerifyStartPageUrl()
    {
        _driver.Navigate().GoToUrl(_epamLandingUrl);
        var currentUrl = _driver.Url;
        Assert.That(currentUrl, Is.EqualTo(_epamLandingUrl),"Page URL isn't correct");
    }

    [Test]
    public void VerifyNavigationBackTest()
    {
        string urlHowWeDoIt = "https://www.epam.com/how-we-do-it";
        string ourWork = "https://www.epam.com/our-work";
        _driver.Navigate().GoToUrl(urlHowWeDoIt);
        _driver.Navigate().GoToUrl(ourWork);
        _driver.Navigate().Refresh();
        _driver.Navigate().Back();
        string currentUrl = _driver.Url;
        Assert.That(currentUrl, Is.EqualTo(urlHowWeDoIt));
    }

    [TearDown]
    public void TearDown()
    {
        _driver.Close();
        _driver.Quit();
    }
}