using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTest;

public class EpamRandomTests
{
    IWebDriver Driver;
    private WebDriverWait Wait;
    private string _epamUrl = "https://www.epam.com/";

    [SetUp]
    public void SetupBrowser()
    {
        Driver = new ChromeDriver();
        var action = new Actions(Driver);
        //Wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
        Driver.Manage().Window.Maximize();
        Driver.Navigate().GoToUrl(_epamUrl);
        //Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        Driver.FindElement(By.Id("onetrust-accept-btn-handler")).Click();
        // var button = Wait.Until(f => f.FindElement(By.Id(coockisAcceptLocator)));
        //action.MoveToElement(coockisAcceptLocator).Click().Build().Perform();
    }
    
    [Test]
    public void CheckIfHeaderPresent()
    {
            var header = Driver.FindElement(By.XPath("//*[@class ='header__inner']"));
            Assert.IsTrue(header.Displayed, "No header present");
    }
    
    [Test]
    public void CheckLocationsPageAndApplyButton()
    {
        IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)Driver;
        var action = new Actions(Driver);
        var careers = Driver.FindElement(By.XPath("//*[@href='/careers' and contains(@class, 'top-navigation__item-link')]"));
        action.MoveToElement(careers).Build().Perform();
        var hiringLocationsElement =Driver.FindElement( By.XPath("//*[@href = '/careers/job-listings' and contains(@class, 'bold-underlined-hover add-arrow' )]"));
        hiringLocationsElement.Click();
        var applyButton =Driver.FindElement(By.XPath( "//*[@href = '/careers/job-listings' and contains(@class, 'bod-underlined-hover add-arrow' )]"));
        jsExecutor.ExecuteScript("arguments[0].scrollIntoView(true);", applyButton);
        Assert.IsTrue(applyButton.Displayed, "No Apply button displayed");
    }
    
    
    [TearDown]
    public void TearDown()
    {
        Driver.Close();
        Driver.Quit();
    }
}