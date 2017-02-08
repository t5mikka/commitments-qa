using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Commitments
{
    class journey1TescoProviderApproveCohortClass
    {
        public static void journey1TescoProviderApproveCohort()
        {

            // [Provider] Click "Apprentices" link
            Apprentices.common("[Provider] Click \"Apprentices\" link");
            Apprentices.clickLinkText("Apprentices");

            // [Provider] Check Heading displays "Your cohorts"
            Apprentices.common("[Provider] Check Heading displays \"BARNFIELD COLLEGE\"");
            Apprentices.checkTextClassName("heading-xlarge", "Your cohorts", "Check Heading displays \"Your cohorts\"");

            // [Provider] Get Provider ID
            Apprentices.getProviderId();

            // INCORRECT  // INCORRECT  // INCORRECT  // INCORRECT  // INCORRECT
            // [Provider] Click "View all new requests that are ready for review" button
            Apprentices.common("[Provider] Click \"View all new requests that are ready for review\" button");
            Apprentices.clickLabel("View all new requests that are ready for review");

            int AgreementSigned = 0;

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

            while (AgreementSigned != 1)
            {
                try
                {

                    IWebElement elementClass = Apprentices.driver.FindElement(By.ClassName("heading-xlarge"));
                    Apprentices.elementClassText = elementClass.Text;
                    Apprentices.debug("Check for: Agreement not signed OR Set Review cohorts");
                    Apprentices.debug("Website text: " + Apprentices.elementClassText);

                    if (Apprentices.elementClassText == "Agreement not signed")
                    {

                        // [Provider] Click "Continue to cohort" link
                        AgreementSigned = 1;
                        Apprentices.common("[Provider] Click \"Continue to cohort\" link");
                        Apprentices.clickLinkText("Continue to cohort");

                        // [Provider] Check Heading displays "Review cohorts"
                        Apprentices.common("[Provider] Check Heading displays \"Review cohorts\"");
                        Apprentices.checkTextClassName("heading-xlarge", "Review cohorts", "Check Heading displays \"Review cohorts\"");

                    }
                    else if (Apprentices.elementClassText == "Review cohorts")
                    {
                        AgreementSigned = 1;
                        // [Provider] Check Heading displays "Review cohorts"
                        Apprentices.common("[Provider] Check Heading displays \"Review cohorts\"");
                        Apprentices.checkTextClassName("heading-xlarge", "Review cohorts", "Check Heading displays \"Review cohorts\"");

                        // [Provider] Approve the cohort
                        Apprentices.common("[Provider] Approve the cohort");
                        journey1TescoProviderApproveCohortAgreementSignedClass.journey1TescoProviderApproveCohortAgreementSigned();

                        Apprentices.common("[Blank] Clear browser screen");
                        Apprentices.getBlankURL();

                        Apprentices.driver.Url = Apprentices.urlEmployer;

                        journey1TescoEmployerApproveCohortClass.journey1TescoEmployerApproveCohort();

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
        }
    }
}
