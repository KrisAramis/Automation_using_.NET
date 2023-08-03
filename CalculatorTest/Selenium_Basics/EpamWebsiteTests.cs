using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Selenium_Basics;

public class EpamWebsitesTests
{
    private IWebDriver _driver;
    private const string _url = "https://www.epam.com";
    
    [SetUp]
    public void SetupBrowser()
    {
        _driver = new ChromeDriver();
        _driver.Manage().Window.Maximize();
    }

    [Test]
    public void VerifyStartPageUrl()
    {
        _driver.Navigate().GoToUrl(_url);
        string currentUrl;
        string expectedUrl = "https://www.epam.com";
        currentUrl = _driver.Url;
        Assert.That(currentUrl, Is.EqualTo(expectedUrl));
    }

    [Test]
    public void VerifyHowWeDoItOurWork()
    {
        string urlHowWeDoIt = "https://www.epam.com/how-we-do-it";
        string ourWork = "https://www.epam.com/our-work";
        _driver.Url = "https://www.epam.com" ;
        _driver.Navigate().GoToUrl(_url);
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