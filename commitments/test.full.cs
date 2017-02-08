using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;

namespace Commitments
{
    internal class testFullClass
    {
        public static void testFull()
        {
            int testRuns = 0;

            // Get URL employer application
            Apprentices.openEmployer();

            // Log into employer application
            employerLogin.login();

            while (testRuns < Apprentices.totalTestRuns)
            {

                int yourAccountsSetUp = 0;

                Apprentices.driver.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(Apprentices.PageLoadTimeout));
                try
                {
                    new WebDriverWait(Apprentices.driver, TimeSpan.FromSeconds(Apprentices.timeOutSeconds)).Until(ExpectedConditions.ElementExists((By.ClassName("heading-xlarge"))));
                }
                catch (Exception ex)
                {
                    Apprentices.debug("heading-xlarge Visible = 0");
                    Apprentices.debug("ERROR: " + ex.Message);
                }

                try
                {
                    new WebDriverWait(Apprentices.driver, TimeSpan.FromSeconds(Apprentices.timeOutSeconds)).Until(ExpectedConditions.ElementIsVisible((By.ClassName("heading-xlarge"))));
                }
                catch (Exception ex)
                {
                    Apprentices.debug("heading-xlarge Visible = 0");
                    Apprentices.debug("ERROR: " + ex.Message);
                }

                while (yourAccountsSetUp != 1)
                {
                    try
                    {

                        IWebElement elementClass = Apprentices.driver.FindElement(By.ClassName("heading-xlarge"));
                        Apprentices.elementClassText = elementClass.Text;
                        Apprentices.debug("Check for: Your accounts OR Set up your account");
                        Apprentices.debug("Website text: " + Apprentices.elementClassText);

                        if (Apprentices.elementClassText == "Your accounts")
                        {
                            Apprentices.journey1TescoEmployerCheck();
                            yourAccountsSetUp = 1;
                            journey1TescoEmployerCreateCohortClass.journey1TescoEmployerCreateCohort();

                            Apprentices.common("[Blank] Clear browser screen");
                            Apprentices.getBlankURL();

                            providerLogin.login();
                            journey1TescoProviderApproveCohortClass.journey1TescoProviderApproveCohort();
                            
                            // Display report
                            Apprentices.report();
                            Thread.Sleep(5000);
                        }
                        else if (Apprentices.elementClassText == "Set up your account")
                        {
                            yourAccountsSetUp = 1;
                            setUpTescoAccountClass.setUpTescoAccount();

                        }
                        else
                        {
                            Apprentices.debug("Text: " + Apprentices.elementClassText);
                            Thread.Sleep(Apprentices.findWait);
                        }
                    }
                    catch (Exception ex)
                    {
                        Apprentices.outputInfo("Error " + Apprentices.elementClassText);
                        Apprentices.outputInfo("ERROR: " + ex.Message);
                        Thread.Sleep(Apprentices.exceptionWait);
                    }

                }

                // Get URL web application
                Apprentices.common("Opening URL " + Apprentices.urlEmployer);

                try
                {
                    Apprentices.driver.Url = Apprentices.urlEmployer;
                }
                catch
                {
                    Apprentices.outputInfo("ERROR: Unable to open URL");
                }
                testRuns++;
            }

        }
    }
}
