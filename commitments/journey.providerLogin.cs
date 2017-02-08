using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commitments
{
    internal class providerLogin
    {
        public static void login()
        {
            providerLoginCredentials[] contacts = providerLoginCredentials.LoadContacts(Apprentices.signInProviderCSV);

            // [Provider] Click "Requests in progress" link
            Apprentices.common("[Provider] Open Provider application");
            Apprentices.driver.Url = Apprentices.urlProvider;

            // [Provider] Click "Sign in" button
            Apprentices.common("[Provider] Click \"Sign in\" button");
            Apprentices.clickClassName("button");

            // [Provider] Check Heading displays "Instructions sent"
            Apprentices.common("[Instructions sent] Check Heading displays \"Sign in\"");
            Apprentices.checkTextClassName("pageTitle", "Sign in", "Check Heading displays \"Sign in\"");

            // [Provider] Enter ISP\dastest1a into "the User ID or email address" input field
            Apprentices.common("[Provider] Enter ISP\\dastest1a into \"the User ID or email address\" input field");
            Apprentices.sendKeys("username", contacts[1].email);

            // [Provider] Enter ISP\dastest1a into "Password" input field
            Apprentices.common("[Provider] Enter ISP\\dastest1a into \"Password\" input field");
            Apprentices.sendKeys("password", contacts[1].password);

            // [Provider] Click "Sign in" button
            Apprentices.common("[Provider] Click \"Sign in\" button");
            Apprentices.clickClassName("btn-ml");

            // [Provider] Check Heading displays "BARNFIELD COLLEGE"
            Apprentices.common("[Provider] Check Heading displays \"BARNFIELD COLLEGE\"");
            Apprentices.checkTextClassName("heading-xlarge", "BARNFIELD COLLEGE", "Check Heading displays \"BARNFIELD COLLEGE\"");

        }
    }
}
