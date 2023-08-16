using System.Text;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;

namespace Selenium_Basics;

public class EpamSearchTests
{
    private static IWebDriver _driver { get; set; }
    private string _epamUrl = "https://epam.com/";

    [SetUp, Order(1)]
    public void SetupBrowser()
    {
        _driver = new ChromeDriver();
        _driver.Manage().Window.Maximize();
        _driver.Navigate().GoToUrl(_epamUrl);
    }
    
    [SetUp, Order(2)]
    public void SetupCoockies()
    {
        var coockisAcceptLocator = _driver.FindElement(By.Id("onetrust-accept-btn-handler"));
        Thread.Sleep(3000);
        coockisAcceptLocator.Click();
    }

    [Test] 
    public void FindJobsEMEAAmericaApacInList()
    {
        _driver.FindElement(By.PartialLinkText("Careers")).Click();
        var findJobsButton = _driver.FindElement(By.XPath("//*[@class = 'arrow']//ancestor::*[contains (@href, 'job-listings') and @tabindex = '0']"));
        findJobsButton.Click();
        var regionesOnThePage = _driver.FindElements(By.XPath("//*[contains(@class,'tabs-23__title js-tabs-title')]"));
        var regionesOnThePageList = regionesOnThePage.Select(a => a.GetAttribute("outerText")).ToList();
        List<string> regionesShouldBePresent = new List<string>() { "AMERICAS", "EMEA", "APAC"};
        bool areRegionsPresent = regionesOnThePageList.SequenceEqual<string>(regionesShouldBePresent, StringComparer.OrdinalIgnoreCase);
        Assert.IsTrue(areRegionsPresent, $"regions AMERICAS, EMAE, APAC are NOT on 'Find Your Jobs' list");
    }
    
    [Test] 
    public void VerifySearchWorksCorrectly()
    {
        string linkToVerify = "https://www.epam.com/search?q=";
        string textToSearch = "Automation";
        var textToSearchinUrl = textToSearch.Replace(" ", "+");
        var searchIconLocator  = _driver.FindElement(By.XPath("//span[contains(@class,'dark-iconheader-search__search-icon')]"));
        searchIconLocator.Click();
        Thread.Sleep(2000);
        var searchInputLocator = _driver.FindElement(By.Id("new_form_search"));
        searchInputLocator.SendKeys(textToSearch);
        var findButtonLocator = _driver.FindElement(By.XPath("//button/*[@class='bth-text-layer' and contains(text(), 'Find')]"));  
        findButtonLocator.Click();
        string actualUrl = _driver.Url;
        Assert.That(actualUrl, Is.EqualTo(linkToVerify+textToSearchinUrl),"Link with search parameter is incorrect");
        var articleLocator = By.XPath("//article");
        var articleHeader = _driver.FindElement(articleLocator).GetDomProperty("outerText");
        var articlesHeaderwords = articleHeader.Split(' ');
        Assert.Contains(textToSearch, articlesHeaderwords, $"Article doesn't contain {textToSearch} word");
    }

    [Test]
    public void VerifyTitleOnSearchResultsMatchArticlePageTitle()
    {
        string textToSearch = "Business Analysis";
        var searchIconLocator  = _driver.FindElement(By.XPath("//span[contains(@class,'dark-iconheader-search__search-icon')]"));
        searchIconLocator.Click();
        var searchInputLocator = _driver.FindElement(By.Id("new_form_search"));
        searchInputLocator.SendKeys(textToSearch);
        Thread.Sleep(2000);
        var findButtonLocator = _driver.FindElement(By.XPath("//button/*[@class='bth-text-layer' and contains(text(), 'Find')]"));  
        findButtonLocator.Click();
        Thread.Sleep(2000);
        var linkToVerify = "https://www.epam.com/search?q=";
        var actualUrl = _driver.Url;
        var titleOfTheFirstArticleResultsLocator = _driver.FindElement(By.XPath("//article//a"));
        var titleOfTheFirstArticleResults = titleOfTheFirstArticleResultsLocator.Text;
        titleOfTheFirstArticleResultsLocator.Click();
        var titleOnTheArticlePage = _driver.FindElement(By.XPath("//*[@class='museo-sans-light']")).GetAttribute("innerText");
        Assert.AreEqual(titleOfTheFirstArticleResults,titleOnTheArticlePage, "Titles on the results page and on the article page don't match");
    }

    [TearDown]
    public void TearDown()
    {
        _driver.Close();
        _driver.Quit();
    }
}