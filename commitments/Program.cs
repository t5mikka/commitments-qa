// Version: 1.0.0.20815
// C:\Users\User\Documents\Visual Studio 2015\Projects\commitments\commitments


// NUnit
// Selenium.Firefox.WebDriver
// Selenium.Support
// Selenium.WebDriver
// Selenium.WebDriver.ChromeDriver
// Selenium.WebDriver.IEDriver



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.Extensions;
using System.Drawing.Imaging;
using System.IO;
using System.Collections;

namespace Commitments
{

    public static class Apprentices
    {
        public static int debugOutput;
        public static int mainErrorLogCount;
        public static int errorCount;
        public static int delayTime;
        public static int timeOutSeconds;
        public static String urlEmployer;
        public static String urlProvider;
        public static String urlBlank;
        public static String leavy;
        public static String cohort;
        public static String apprentice;
        public static String providerId;
        public static FileStream logFile;
        public static StreamWriter logFileSW;
        public static int browser;
        public static IWebDriver driver;
        public static DesiredCapabilities capability;
        public static Uri server;

        public static int stepCount = 1;
        public static String errorList;
        public static String elementClassText;
        public static String currentURL;
        public static String currentSource;

        public static int PageLoadTimeout;
        public static String imageFolder;
        public static int blankUrlWait;
        public static int findWait;
        public static int exceptionWait;
        public static int errorWait;
        public static String automationGrid;
        public static String outputLog;
        public static int totalTestRuns;
        public static int findTry;
        public static int errorTry;
        public static int includeNegTest;
        public static String signInProviderCSV;
        public static String signInEmployerCSV;
        public static int screenShots;
        public static int ShowconsoleOutput;
        public static int logOutput;

        // run automation
        static void Main(string[] args)
        {
            getProperties();
            openLog(outputLog, "txt");
            selectBrowser();
            common("Opening browser to full screen");
            driver.Manage().Window.Maximize();

            // run full end to end
            testFullClass.testFull();

            closeLog();
            driver.Quit();

        }

        public static void getProperties()
        {
            getPropertiesFile[] properties = getPropertiesFile.LoadProperties(@"C:\SFAdata\properties.csv");
            debugOutput = Convert.ToInt32(properties[3].dataValue);
            mainErrorLogCount = Convert.ToInt32(properties[4].dataValue);
            errorCount = Convert.ToInt32(properties[5].dataValue);
            delayTime = Convert.ToInt32(properties[6].dataValue);
            timeOutSeconds = Convert.ToInt32(properties[7].dataValue);
            PageLoadTimeout = Convert.ToInt32(properties[17].dataValue);
            urlEmployer = properties[10].dataValue;
            urlProvider = properties[11].dataValue;
            urlBlank = properties[12].dataValue;
            browser = Convert.ToInt32(properties[15].dataValue);
            imageFolder = properties[18].dataValue;
            blankUrlWait = Convert.ToInt32(properties[19].dataValue);
            findWait = Convert.ToInt32(properties[20].dataValue);
            exceptionWait = Convert.ToInt32(properties[20].dataValue);
            errorWait = Convert.ToInt32(properties[20].dataValue);
            automationGrid = properties[23].dataValue;
            outputLog = properties[24].dataValue;
            totalTestRuns = Convert.ToInt32(properties[25].dataValue);
            findTry = Convert.ToInt32(properties[26].dataValue);
            errorTry = Convert.ToInt32(properties[27].dataValue);
            includeNegTest = Convert.ToInt32(properties[28].dataValue);
            signInProviderCSV = properties[29].dataValue;
            signInEmployerCSV = properties[30].dataValue;
            screenShots = Convert.ToInt32(properties[31].dataValue);
            ShowconsoleOutput = Convert.ToInt32(properties[32].dataValue);
            logOutput = Convert.ToInt32(properties[33].dataValue);
        }

        public static void openEmployer()
        {
            common("Opening URL " + urlEmployer);
            try
            {
                driver.Url = urlEmployer;
            }
            catch
            {
                outputInfo("ERROR: Unable to open URL");
            }
        }

        public static void openLog(String filename, String fileExtention)
        {
            logFile = new FileStream(filename + "." + fileExtention, FileMode.OpenOrCreate);
            logFileSW = new StreamWriter(logFile);
            outputInfo("Log file opened: " + filename + "." + fileExtention);
        }

        public static void writeToLog(String value)
        {
            if (logOutput == 1)
            {
                logFileSW.WriteLine(value);
                logFileSW.Flush();
            }
        }

        public static void outputInfo(String value)
        {
            if (ShowconsoleOutput == 1)
            {
                Console.WriteLine(value);
            }
            writeToLog(value);
        }

        public static void closeLog()
        {
            logFileSW.Close();
        }

        // Browser select
        public static void selectBrowser()
        {
            switch (browser)
            {
                case 1:
                    {
                        outputInfo("Using local Firefox");
                        driver = new FirefoxDriver();
                        break;
                    }
                case 2:
                    {
                        outputInfo("Using local Chrome");
                        driver = new ChromeDriver();
                        break;
                    }
                case 3:
                    {
                        outputInfo("Using local Internet explorer");
                        driver = new InternetExplorerDriver();
                        break;
                    }
                case 4:
                    {
                        outputInfo("Using grid");
                        DesiredCapabilities capability = DesiredCapabilities.Firefox();
                        Uri server = new Uri(automationGrid);
                        IWebDriver driver = new RemoteWebDriver(server, capability);
                        break;
                    }
            }

        }

        // Common code
        public static void common(String consoleOutput)
        {
            if (screenShots == 1)
            {
                driver.TakeScreenshot().SaveAsFile(imageFolder + "step" + (stepCount - 1) + ".jpg", ImageFormat.Jpeg);
            }
            driver.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(PageLoadTimeout));
            Thread.Sleep(delayTime);
            outputInfo("\nStep: " + stepCount);
            outputInfo(consoleOutput);
            stepCount = stepCount + 1;
        }

        // Report
        public static void report()
        {
            outputInfo("\nCheck point errors count = " + errorCount);
            outputInfo("\nErrors list:");
            outputInfo(errorList);
        }

        public static void getBlankURL()
        {
            driver.Url = urlBlank;
            Thread.Sleep(blankUrlWait);
        }

        public static void getURL()
        {
            currentURL = driver.Url;
        }

        public static void getSource()
        {
            currentSource = driver.PageSource;
        }

        public static void getApprenticeCodes()
        {
            getURL();
            string[] currentURLparts = currentURL.Split('/');
            leavy = currentURLparts[4];
            cohort = currentURLparts[6];
            apprentice = currentURLparts[8];
        }

        public static void getProviderId()
        {
            getURL();
            string[] currentURLparts = currentURL.Split('/');
            providerId = currentURLparts[3];
        }

        public static void debug(String debugMessage = null)
        {
            if (debugOutput == 1)
            {
                outputInfo(debugMessage);
            }
        }

        public static void checkValue(String elementName, String elementValue, String descriptionText)
        {
            int Vis = 0;
            int Exists = 0;
            int textMatch = 0;
            int textMatchCount = 0;
            int errorLogCount = 0;
            String elementClassText = "";

            try
            {
                new WebDriverWait(driver, TimeSpan.FromSeconds(timeOutSeconds)).Until(ExpectedConditions.ElementExists((By.Id(elementName))));
                debug(elementName + " Exists = 1");
                Exists = 1;
            }
            catch (Exception ex)
            {
                debug(elementName + " Exists = 0");
                debug("Exists ERROR: " + ex.Message);
            }
            try
            {
                new WebDriverWait(driver, TimeSpan.FromSeconds(timeOutSeconds)).Until(ExpectedConditions.ElementIsVisible((By.Id(elementName))));
                debug(elementName + " Visible = 1");
                Vis = 1;
            }
            catch (Exception ex)
            {
                debug(elementName + " Visible = 0");
                debug("Visible ERROR: " + ex.Message);
            }
            if (Exists == 1 || Vis == 1)
            {
                while (textMatch != 1 && textMatchCount < findTry)
                {
                    debug(" textMatch = " + textMatch);
                    debug(" textMatchCount = " + textMatchCount);
                    try
                    {
                        IWebElement elementClass = driver.FindElement(By.Id(elementName));
                        elementClassText = elementClass.GetAttribute("value"); ;
                    }
                    catch (Exception ex)
                    {
                        outputInfo("Find Element ERROR: " + ex.Message);
                        Thread.Sleep(exceptionWait);
                    }
                    debug("Exists || Visible = 1");
                    debug("Text Website: " + elementClassText);
                    debug("Text Search: " + elementValue);

                    if (elementClassText.Equals(elementValue, StringComparison.Ordinal))
                    {
                        outputInfo("PASS: " + descriptionText + " found");
                        textMatch = 1;
                    }
                    else
                    {
                        if (errorLogCount > mainErrorLogCount)
                        {
                            errorLog(descriptionText);
                        }
                    }

                    textMatchCount++;
                    Thread.Sleep(findWait);
                }
            }
        }

        public static void getApprentice(String elementName)
        {

            int Vis = 0;
            int Exists = 0;

            try
            {
                new WebDriverWait(driver, TimeSpan.FromSeconds(timeOutSeconds)).Until(ExpectedConditions.ElementExists((By.XPath($".//*[@aria-label=\"Edit {elementName}\"]"))));
                debug(elementName + " Exists = 1");
                Exists = 1;
            }
            catch (Exception ex)
            {
                debug(elementName + " Exists = 0");
                debug("ERROR: " + ex.Message);
            }
            try
            {
                new WebDriverWait(driver, TimeSpan.FromSeconds(timeOutSeconds)).Until(ExpectedConditions.ElementIsVisible((By.XPath($".//*[@aria-label=\"Edit {elementName}\"]"))));
                debug(elementName + " Visible = 1");
                Vis = 1;
            }
            catch (Exception ex)
            {
                debug(elementName + " Visible = 0");
                debug("ERROR: " + ex.Message);
            }
            if (Exists == 1 || Vis == 1)
            {
                try
                {
                    IWebElement elementClass = driver.FindElement(By.XPath($".//*[@aria-label=\"Edit {elementName}\"]"));
                    elementClass.Click();
                }
                catch (Exception ex)
                {
                    outputInfo("ERROR: " + ex.Message);
                    Thread.Sleep(exceptionWait);
                }
            }
        }

        public static void clickLabel(String elementName)
        {

            int Vis = 0;
            int Exists = 0;

            try
            {
                new WebDriverWait(driver, TimeSpan.FromSeconds(timeOutSeconds)).Until(ExpectedConditions.ElementExists((By.XPath($".//*[@aria-label=\"{elementName}\"]"))));
                debug(elementName + " Exists = 1");
                Exists = 1;
            }
            catch (Exception ex)
            {
                debug(elementName + " Exists = 0");
                debug("ERROR: " + ex.Message);
            }
            try
            {
                new WebDriverWait(driver, TimeSpan.FromSeconds(timeOutSeconds)).Until(ExpectedConditions.ElementIsVisible((By.XPath($".//*[@aria-label=\"{elementName}\"]"))));
                debug(elementName + " Visible = 1");
                Vis = 1;
            }
            catch (Exception ex)
            {
                debug(elementName + " Visible = 0");
                debug("ERROR: " + ex.Message);
            }
            if (Exists == 1 || Vis == 1)
            {
                try
                {
                    IWebElement elementClass = driver.FindElement(By.XPath($".//*[@aria-label=\"{elementName}\"]"));
                    elementClass.Click();
                }
                catch (Exception ex)
                {
                    outputInfo("ERROR: " + ex.Message);
                    Thread.Sleep(exceptionWait);
                }
            }
        }

        public static void clickFor(String elementName)
        {

            int Vis = 0;
            int Exists = 0;

            try
            {
                new WebDriverWait(driver, TimeSpan.FromSeconds(timeOutSeconds)).Until(ExpectedConditions.ElementExists((By.XPath($".//*[@for=\"{elementName}\"]"))));
                debug(elementName + " Exists = 1");
                Exists = 1;
            }
            catch (Exception ex)
            {
                debug(elementName + " Exists = 0");
                debug("ERROR: " + ex.Message);
            }
            try
            {
                new WebDriverWait(driver, TimeSpan.FromSeconds(timeOutSeconds)).Until(ExpectedConditions.ElementIsVisible((By.XPath($".//*[@for=\"{elementName}\"]"))));
                debug(elementName + " Visible = 1");
                Vis = 1;
            }
            catch (Exception ex)
            {
                debug(elementName + " Visible = 0");
                debug("ERROR: " + ex.Message);
            }
            if (Exists == 1 || Vis == 1)
            {
                try
                {
                    IWebElement elementClass = driver.FindElement(By.XPath($".//*[@for=\"{elementName}\"]"));
                    elementClass.Click();
                }
                catch (Exception ex)
                {
                    outputInfo("ERROR: " + ex.Message);
                    Thread.Sleep(exceptionWait);
                }
            }
        }

        public static int checkTextH1(String elementName, String searchText, String descriptionText)
        {
            int classNameVis = 0;
            int classNameExists = 0;
            int textMatch = 0;
            int textMatchCount = 0;
            int errorLogCount = 0;
            String elementClassText = "";

            try
            {
                new WebDriverWait(driver, TimeSpan.FromSeconds(timeOutSeconds)).Until(ExpectedConditions.ElementExists((By.XPath($".//*[h1]"))));
                debug(elementName + " Exists = 1");
                classNameExists = 1;
            }
            catch (Exception ex)
            {
                debug(elementName + " Exists = 0");
                debug("ERROR: " + ex.Message);
            }
            try
            {
                new WebDriverWait(driver, TimeSpan.FromSeconds(timeOutSeconds)).Until(ExpectedConditions.ElementIsVisible((By.XPath($".//*[h1]"))));
                debug(elementName + " Visible = 1");
                classNameVis = 1;
            }
            catch (Exception ex)
            {
                debug(elementName + " Visible = 1");
                debug("ERROR: " + ex.Message);
            }
            if (classNameExists == 1 || classNameVis == 1)
            {
                while (textMatch != 1 && textMatchCount < findTry)
                {
                    debug(" textMatch = " + textMatch);
                    debug(" textMatchCount = " + textMatchCount);
                    try
                    {
                        IWebElement elementClass = driver.FindElement(By.XPath($".//*[h1]"));
                        elementClassText = elementClass.Text;
                    }
                    catch (Exception ex)
                    {
                        outputInfo("ERROR: " + ex.Message);
                        Thread.Sleep(exceptionWait);
                    }
                    debug("Exists || Visible = 1");
                    debug("Text Website: " + elementClassText);
                    debug("Text Search: " + searchText);

                    if (elementClassText.Equals(searchText, StringComparison.Ordinal))
                    {
                        outputInfo("PASS: " + descriptionText + " found");
                        textMatch = 1;
                    }
                    else
                    {
                        if (errorLogCount > mainErrorLogCount)
                        {
                            errorLog(descriptionText);
                        }
                    }

                    textMatchCount++;
                    Thread.Sleep(findWait);
                }
            }
            return textMatch;
        }

        public static int checkTextClassName(String elementName, String searchText, String descriptionText)
        {
            int classNameVis = 0;
            int classNameExists = 0;
            int textMatch = 0;
            int textMatchCount = 0;
            int errorLogCount = 0;
            String elementClassText = "";

            try
            {
                new WebDriverWait(driver, TimeSpan.FromSeconds(timeOutSeconds)).Until(ExpectedConditions.ElementExists((By.ClassName(elementName))));
                debug(elementName + " Exists = 1");
                classNameExists = 1;
            }
            catch (Exception ex)
            {
                debug(elementName + " Exists = 0");
                debug("ERROR: " + ex.Message);
            }
            try
            {
                new WebDriverWait(driver, TimeSpan.FromSeconds(timeOutSeconds)).Until(ExpectedConditions.ElementIsVisible((By.ClassName(elementName))));
                debug(elementName + " Visible = 1");
                classNameVis = 1;
            }
            catch (Exception ex)
            {
                debug(elementName + " Visible = 1");
                debug("ERROR: " + ex.Message);
            }
            if (classNameExists == 1 || classNameVis == 1)
            {
                while (textMatch != 1 && textMatchCount < findTry)
                {
                    debug(" textMatch = " + textMatch);
                    debug(" textMatchCount = " + textMatchCount);
                    try
                    {
                        IWebElement elementClass = driver.FindElement(By.ClassName(elementName));
                        elementClassText = elementClass.Text;
                    }
                    catch (Exception ex)
                    {
                        outputInfo("ERROR: " + ex.Message);
                        Thread.Sleep(exceptionWait);
                    }
                    debug("Exists || Visible = 1");
                    debug("Text Website: " + elementClassText);
                    debug("Text Search: " + searchText);

                    if (elementClassText.Equals(searchText, StringComparison.Ordinal))
                    {
                        outputInfo("PASS: " + descriptionText + " found");
                        textMatch = 1;
                    }
                    else
                    {
                        if (errorLogCount > mainErrorLogCount)
                        {
                            errorLog(descriptionText);
                        }
                    }

                    textMatchCount++;
                    Thread.Sleep(findWait);
                }
            }
            return textMatch;
        }

        public static void checkTextXPath(String elementName, String searchText, String descriptionText)
        {
            int classNameVis = 0;
            int classNameExists = 0;
            int textMatch = 0;
            int textMatchCount = 0;
            int errorLogCount = 0;
            String elementClassText = "";

            try
            {
                new WebDriverWait(driver, TimeSpan.FromSeconds(timeOutSeconds)).Until(ExpectedConditions.ElementExists((By.XPath(elementName))));
                debug(elementName + " Exists = 1");
                classNameExists = 1;
            }
            catch (Exception ex)
            {
                debug(elementName + " Exists = 0");
                debug("ERROR: " + ex.Message);
            }
            try
            {
                new WebDriverWait(driver, TimeSpan.FromSeconds(timeOutSeconds)).Until(ExpectedConditions.ElementIsVisible((By.XPath(elementName))));
                debug(elementName + " Visible = 1");
                classNameVis = 1;
            }
            catch (Exception ex)
            {
                debug(elementName + " Visible = 1");
                debug("ERROR: " + ex.Message);
            }
            if (classNameExists == 1 || classNameVis == 1)
            {
                while (textMatch != 1 && textMatchCount < findTry)
                {
                    debug(" textMatch = " + textMatch);
                    debug(" textMatchCount = " + textMatchCount);
                    try
                    {
                        IWebElement elementClass = driver.FindElement(By.XPath(elementName));
                        elementClassText = elementClass.Text;
                    }
                    catch (Exception ex)
                    {
                        outputInfo("ERROR: " + ex.Message);
                        Thread.Sleep(exceptionWait);
                    }
                    debug("Exists || Visible = 1");
                    debug("Text Website: " + elementClassText);
                    debug("Text Search: " + searchText);

                    if (elementClassText.Equals(searchText, StringComparison.Ordinal))
                    {
                        outputInfo("PASS: " + descriptionText + " found");
                        textMatch = 1;
                    }
                    else
                    {
                        if (errorLogCount > mainErrorLogCount)
                        {
                            errorLog(descriptionText);
                        }
                    }

                    textMatchCount++;
                    Thread.Sleep(findWait);
                }
            }
        }

        public static void checkTextId(String elementName, String searchText, String descriptionText)
        {
            int classNameVis = 0;
            int classNameExists = 0;
            int textMatch = 0;
            int textMatchCount = 0;
            int errorLogCount = 0;
            String elementClassText = "";

            try
            {
                new WebDriverWait(driver, TimeSpan.FromSeconds(timeOutSeconds)).Until(ExpectedConditions.ElementExists((By.Id(elementName))));
                debug(elementName + " Exists = 1");
                classNameExists = 1;
            }
            catch (Exception ex)
            {
                debug(elementName + " Exists = 0");
                debug("ERROR: " + ex.Message);
            }
            try
            {
                new WebDriverWait(driver, TimeSpan.FromSeconds(timeOutSeconds)).Until(ExpectedConditions.ElementIsVisible((By.Id(elementName))));
                debug(elementName + " Visible = 1");
                classNameVis = 1;
            }
            catch (Exception ex)
            {
                debug(elementName + " Visible = 1");
                debug("ERROR: " + ex.Message);
            }
            if (classNameExists == 1 || classNameVis == 1)
            {
                while (textMatch != 1 && textMatchCount < findTry)
                {
                    debug(" textMatch = " + textMatch);
                    debug(" textMatchCount = " + textMatchCount);
                    try
                    {
                        IWebElement elementClass = driver.FindElement(By.Id(elementName));
                        elementClassText = elementClass.Text;
                    }
                    catch (Exception ex)
                    {
                        outputInfo("ERROR: " + ex.Message);
                        Thread.Sleep(exceptionWait);
                    }
                    debug("Exists || Visible = 1");
                    debug("Text Website: " + elementClassText);
                    debug("Text Search: " + searchText);

                    if (elementClassText.Equals(searchText, StringComparison.Ordinal))
                    {
                        outputInfo("PASS: " + descriptionText + " found");
                        textMatch = 1;
                    }
                    else
                    {
                        if (errorLogCount > mainErrorLogCount)
                        {
                            errorLog(descriptionText);
                        }
                    }

                    textMatchCount++;
                    Thread.Sleep(findWait);
                }
            }
        }

        public static void clearInput(String elementName)
        {
            try
            {
                new WebDriverWait(driver, TimeSpan.FromSeconds(timeOutSeconds)).Until(ExpectedConditions.ElementExists((By.Id(elementName))));
                if (debugOutput == 1)
                {
                    outputInfo(elementName + " Exists = true");
                }
            }
            catch (Exception ex)
            {
                if (debugOutput == 1)
                {
                    outputInfo(elementName + " Exists = false");
                    outputInfo("ERROR: " + ex.Message);
                }
            }
            try
            {
                new WebDriverWait(driver, TimeSpan.FromSeconds(timeOutSeconds)).Until(ExpectedConditions.ElementIsVisible((By.Id(elementName))));
                if (debugOutput == 1)
                {
                    outputInfo(elementName + " Visible = true");
                }
            }
            catch (Exception ex)
            {
                if (debugOutput == 1)
                {
                    outputInfo(elementName + " Visible = false");
                    outputInfo("ERROR: " + ex.Message);
                }
            }
            driver.FindElement(By.Id(elementName)).Clear();
            outputInfo("Cleared input field");
        }

        public static void sendKey(String elementName, String keyText)
        {
            try
            {
                new WebDriverWait(driver, TimeSpan.FromSeconds(timeOutSeconds)).Until(ExpectedConditions.ElementExists((By.Id(elementName))));
                if (debugOutput == 1)
                {
                    outputInfo(elementName + " Exists = true");
                }
            }
            catch (Exception ex)
            {
                if (debugOutput == 1)
                {
                    outputInfo(elementName + " Exists = false");
                    outputInfo("ERROR: " + ex.Message);
                }
            }
            try
            {
                new WebDriverWait(driver, TimeSpan.FromSeconds(timeOutSeconds)).Until(ExpectedConditions.ElementIsVisible((By.Id(elementName))));
                if (debugOutput == 1)
                {
                    outputInfo(elementName + " Visible = true");
                }
            }
            catch (Exception ex)
            {
                if (debugOutput == 1)
                {
                    outputInfo(elementName + " Visible = false");
                    outputInfo("ERROR: " + ex.Message);
                }
            }

            if (keyText == "RETURN")
            {
                driver.FindElement(By.Id(elementName)).SendKeys(Keys.Return);
                outputInfo("Pressed Return");
            }
        }


        public static void sendKeys(String elementName, String keyText)
        {
            try
            {
                new WebDriverWait(driver, TimeSpan.FromSeconds(timeOutSeconds)).Until(ExpectedConditions.ElementExists((By.Id(elementName))));
                if (debugOutput == 1)
                {
                    outputInfo(elementName + " Exists = true");
                }
            }
            catch (Exception ex)
            {
                if (debugOutput == 1)
                {
                    outputInfo(elementName + " Exists = false");
                    outputInfo("ERROR: " + ex.Message);
                }
            }
            try
            {
                new WebDriverWait(driver, TimeSpan.FromSeconds(timeOutSeconds)).Until(ExpectedConditions.ElementIsVisible((By.Id(elementName))));
                if (debugOutput == 1)
                {
                    outputInfo(elementName + " Visible = true");
                }
            }
            catch (Exception ex)
            {
                if (debugOutput == 1)
                {
                    outputInfo(elementName + " Visible = false");
                    outputInfo("ERROR: " + ex.Message);
                }
            }
            driver.FindElement(By.Id(elementName)).SendKeys(keyText);
            outputInfo("Typed: " + keyText);
        }

        public static void clickClassName(String elementName)
        {
            int vis = 0;
            int exists = 0;
            int error = 0;
            int pass = 0;

            while (pass == 0 && error < errorTry)
            {
                try
                {
                    new WebDriverWait(driver, TimeSpan.FromSeconds(timeOutSeconds)).Until(ExpectedConditions.ElementExists((By.ClassName(elementName))));
                    debug(elementName + " Exists = 1");
                    vis = 1;
                }
                catch (Exception ex)
                {
                    debug(elementName + " Exists = 0");
                    debug("ERROR: " + ex.Message);
                }
                try
                {
                    new WebDriverWait(driver, TimeSpan.FromSeconds(timeOutSeconds)).Until(ExpectedConditions.ElementIsVisible((By.ClassName(elementName))));
                    debug(elementName + " Visible = 1");
                    exists = 1;
                }
                catch (Exception ex)
                {
                    debug(elementName + " Visible = 0");
                    debug("ERROR: " + ex.Message);
                }

                if (exists == 1 || vis == 1)
                {
                    try
                    {
                        driver.FindElement(By.ClassName(elementName)).Click();
                        pass = 1;
                    }
                    catch
                    {
                        debug($"ERROR Click Class Name {elementName}");
                    }
                }

                error++;
                Thread.Sleep(errorWait);
            }
            if (pass == 1)
            {
                outputInfo("PASS: Click");
            }
            else
            {
                outputInfo($"ERROR: to many tries Click Class Name {elementName}");
            }

        }

        public static void clickLinkText(String elementName)
        {
            int vis = 0;
            int exists = 0;
            int error = 0;
            int pass = 0;

            while (pass == 0 && error < errorTry)
            {
                try
                {
                    new WebDriverWait(driver, TimeSpan.FromSeconds(timeOutSeconds)).Until(ExpectedConditions.ElementExists((By.LinkText(elementName))));
                    debug(elementName + " Exists = 1");
                    vis = 1;
                }
                catch (Exception ex)
                {
                    debug(elementName + " Exists = 0");
                    debug("ERROR: " + ex.Message);
                }
                try
                {
                    new WebDriverWait(driver, TimeSpan.FromSeconds(timeOutSeconds)).Until(ExpectedConditions.ElementIsVisible((By.LinkText(elementName))));
                    debug(elementName + " Visible = 1");
                    exists = 1;
                }
                catch (Exception ex)
                {
                    debug(elementName + " Visible = 0");
                    debug("ERROR: " + ex.Message);
                }

                if (exists == 1 || vis == 1)
                {
                    try
                    {
                        driver.FindElement(By.LinkText(elementName)).Click();
                        pass = 1;
                    }
                    catch
                    {
                        debug($"ERROR Click Class Name {elementName}");
                    }
                }

                error++;
                Thread.Sleep(errorWait);
            }
            if (pass == 1)
            {
                outputInfo("PASS: Click");
            }
            else
            {
                outputInfo($"ERROR: to many tries Click Class Name {elementName}");
            }

        }

        public static void clickId(String elementName)
        {
            int vis = 0;
            int exists = 0;
            int error = 0;
            int pass = 0;

            while (pass == 0 && error < errorTry)
            {
                try
                {
                    new WebDriverWait(driver, TimeSpan.FromSeconds(timeOutSeconds)).Until(ExpectedConditions.ElementExists((By.Id(elementName))));
                    debug(elementName + " Exists = 1");
                    vis = 1;
                }
                catch (Exception ex)
                {
                    debug(elementName + " Exists = 0");
                    debug("ERROR: " + ex.Message);
                }
                try
                {
                    new WebDriverWait(driver, TimeSpan.FromSeconds(timeOutSeconds)).Until(ExpectedConditions.ElementIsVisible((By.Id(elementName))));
                    debug(elementName + " Visible = 1");
                    exists = 1;
                }
                catch (Exception ex)
                {
                    debug(elementName + " Visible = 0");
                    debug("ERROR: " + ex.Message);
                }

                if (exists == 1 || vis == 1)
                {
                    try
                    {
                        driver.FindElement(By.Id(elementName)).Click();
                        pass = 1;
                    }
                    catch
                    {
                        debug($"ERROR Click Class Name {elementName}");
                    }
                }

                error++;
                Thread.Sleep(errorWait);
            }
            if (pass == 1)
            {
                outputInfo("PASS: Click");
            }
            else
            {
                outputInfo($"ERROR: to many tries Click Class Name {elementName}");
            }

        }

        public static void clickName(String elementName)
        {
            int vis = 0;
            int exists = 0;
            int error = 0;
            int pass = 0;

            while (pass == 0 && error < errorTry)
            {
                try
                {
                    new WebDriverWait(driver, TimeSpan.FromSeconds(timeOutSeconds)).Until(ExpectedConditions.ElementExists((By.Name(elementName))));
                    debug(elementName + " Exists = 1");
                    vis = 1;
                }
                catch (Exception ex)
                {
                    debug(elementName + " Exists = 0");
                    debug("ERROR: " + ex.Message);
                }
                try
                {
                    new WebDriverWait(driver, TimeSpan.FromSeconds(timeOutSeconds)).Until(ExpectedConditions.ElementIsVisible((By.Name(elementName))));
                    debug(elementName + " Visible = 1");
                    exists = 1;
                }
                catch (Exception ex)
                {
                    debug(elementName + " Visible = 0");
                    debug("ERROR: " + ex.Message);
                }

                if (exists == 1 || vis == 1)
                {
                    try
                    {
                        driver.FindElement(By.Name(elementName)).Click();
                        pass = 1;
                    }
                    catch
                    {
                        debug($"ERROR Click Class Name {elementName}");
                    }
                }

                error++;
                Thread.Sleep(errorWait);
            }
            if (pass == 1)
            {
                outputInfo("PASS: Click");
            }
            else
            {
                outputInfo($"ERROR: to many tries Click Class Name {elementName}");
            }

        }

        public static void clickXpath(String elementName)
        {
            int vis = 0;
            int exists = 0;
            int error = 0;
            int pass = 0;

            while (pass == 0 && error < errorTry)
            {
                try
                {
                    new WebDriverWait(driver, TimeSpan.FromSeconds(timeOutSeconds)).Until(ExpectedConditions.ElementExists((By.XPath(elementName))));
                    debug(elementName + " Exists = 1");
                    vis = 1;
                }
                catch (Exception ex)
                {
                    debug(elementName + " Exists = 0");
                    debug("ERROR: " + ex.Message);
                }
                try
                {
                    new WebDriverWait(driver, TimeSpan.FromSeconds(timeOutSeconds)).Until(ExpectedConditions.ElementIsVisible((By.XPath(elementName))));
                    debug(elementName + " Visible = 1");
                    exists = 1;
                }
                catch (Exception ex)
                {
                    debug(elementName + " Visible = 0");
                    debug("ERROR: " + ex.Message);
                }

                if (exists == 1 || vis == 1)
                {
                    try
                    {
                        driver.FindElement(By.XPath(elementName)).Click();
                        pass = 1;
                    }
                    catch
                    {
                        debug($"ERROR Click Class Name {elementName}");
                    }
                }

                error++;
                Thread.Sleep(errorWait);
            }
            if (pass == 1)
            {
                outputInfo(("PASS: Click"));
            }
            else
            {
                outputInfo($"ERROR: to many tries Click Class Name {elementName}");
            }

        }

        public static void errorLog(String errorLogText)
        {
            outputInfo("FAILURE: " + errorLogText + " NOT FOUND");
            errorList = errorList + "\n Step " + (stepCount - 1);
            errorCount = errorCount + 1;
        }




        public static void journey1TescoEmployerCheck()
        {

        }

    }
}