// See https://aka.ms/new-console-template for more information
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

Console.WriteLine("Hello, World!");
IWebDriver driver = new FirefoxDriver();
driver.Navigate().GoToUrl("https://10fastfingers.com/typing-test/turkish");
driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
driver.FindElement(By.Id("CybotCookiebotDialogBodyButtonDecline")).Click();
driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
IWebElement box = driver.FindElement(By.XPath("//*[@id=\"inputfield\"]"));

for (int i = 1; i < 340; i++)
{
    string temp = driver.FindElement(By.XPath("/html/body/div[5]/div/div[4]/div/div[1]/div[7]/div[1]/div/span[" + i + "]")).Text;
    for (int j = 0; j < temp.Length; j++)
        box.SendKeys(temp[j].ToString());
    box.SendKeys(" ");
}