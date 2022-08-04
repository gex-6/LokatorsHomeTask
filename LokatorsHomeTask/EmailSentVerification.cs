namespace LokatorsHomeTask
{
    public class Tests
    {
        IWebDriver driver;

        [OneTimeSetUp]
        public void Setup()
        {
            driver = new ChromeDriver(@"C:\Users\kmbs\source\repos\LokatorsHomeTask\LokatorsHomeTask\drivers");
        }

        [Test]
        public void Test1()
        {
            // implicit wait 30 sec
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            // navigating to log in page
            // Locator type 1 : finding element with an Attribute 
            driver.Navigate().GoToUrl("https://www.google.com/intl/uk/gmail/about/");
            driver.Manage().Window.Maximize();
            var logIn = driver.FindElement(By.XPath($"//a[@data-action='sign in']"));
            logIn.Click();

            // inserting the mail and password
            // Locator type 2 : Combining the Descendant and ID Selectors
            var mailField = driver.FindElement(By.XPath($"//div[@class='Xb9hP']/input"));
            mailField.SendKeys("trs.stpnk999");
            mailField.SendKeys(Keys.Enter);
            
            var passField = driver.FindElement(By.XPath($"//div[@class='Xb9hP']/input[@type='password']"));
            passField.SendKeys("Test_1234");
            passField.SendKeys(Keys.Enter);

            // writing mail
            // Locator type 3 : selecting last element inside another element
            var letterBotoon = driver.FindElement(By.XPath($"(//div[@class='z0'])[last()]"));
            letterBotoon.Click();

            // Locator type 4 : Attribute Selector
            var typeLetter = driver.FindElement(By.XPath($"//*[@id=':bb']"));
            typeLetter.Click();
            typeLetter.SendKeys("taras.stepanyuk@gmail.com");
            
            typeLetter.SendKeys(Keys.Tab + Keys.Tab + "Topic" + Keys.Tab + "Letter body" + Keys.Tab + Keys.Enter);
            
            Assert.Pass();
        }
    }
}