using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commitments
{
    internal class employerLogin
    {
        public static void login()
        {
            Apprentices.outputInfo("Running login()");

            employerLoginCredentials[] contacts = employerLoginCredentials.LoadContacts(Apprentices.signInEmployerCSV);

            Apprentices.driver.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(20));
            Apprentices.outputInfo("\n\nUser Journey (or BDD notation):\nAdd an Apprentice to the Tesco Employer account");

            // [Manage apprenticeships] Check heading displays "Manage apprenticeships"
            Apprentices.common("Check heading displays \"Manage apprenticeships\"");
            Apprentices.checkTextClassName("heading-xlarge", "Manage apprenticeships", "Check \"Manage apprenticeships\" is displayed");

            // [Manage apprenticeships] Click the Start button"
            Apprentices.common("[Manage apprenticeships] Click the Start button");
            Apprentices.clickId("service-start");

            // [Home Page] Check heading displays Have you used this service before
            Apprentices.common("Check text 'Have you used this service before?' on/in heading-xlarge");
            Apprentices.checkTextClassName("heading-xlarge", "Have you used this service before?", "Check Have you used this service before? is displayed");

            // [Home page] Click Yes, Ive used this service before
            Apprentices.common("[Home page] Click Yes, Ive used this service before");
            Apprentices.clickFor("used-service-before");

            // [Home Page] Click Continue button
            Apprentices.common("[Home Page] Click Continue button");
            Apprentices.clickId("submit-button");

            // [Sign In] Check heading displays Sign In
            Apprentices.common("[Sign In] Check heading displays Sign In");
            Apprentices.checkTextClassName("heading-xlarge", "Sign in", "Check \"Sign in\" is displayed");

            // [Sign In] Enter email address
            Apprentices.common("[Sign In] Enter email address");
            Apprentices.sendKeys("EmailAddress", contacts[1].email);

            // [Sign In] Enter password
            Apprentices.common("[Sign In] Enter password");
            Apprentices.sendKeys("Password", contacts[1].password);

            // [Sign In] Click the sign in button
            Apprentices.common("[Sign In] Click the sign in button");
            Apprentices.clickClassName("button");

        }
    }
}
