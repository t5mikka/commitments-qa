using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commitments
{
    public static void setUpTescoAccount()
    {
        Apprentices.outputInfo("Running setUpTescoAccount()");

        // [Set up your account] Check heading displays "Set up your account"
        Apprentices.common("[Set up your account] Check heading displays \"Set up your account\"");
        Apprentices.checkTextId("Levy-accounts", "Set up your account", "Check \"Set up your account\" is displayed");

        // [Set up your account] Click the Continue button"
        Apprentices.common("[Set up your account] Click the Continue button");
        Apprentices.clickId("add_new_account");

        // [Add an organisation] Check heading displays "Add an organisation"
        Apprentices.common("[Add an organisation] Check heading displays \"Add an organisation\"");
        Apprentices.checkTextClassName("heading-xlarge", "Add an organisation", "Check \"Add an organisation\" is displayed");

        // [Add an organisation] Click the Listed on Companies House radio button"
        Apprentices.common("[Set up your account] Click the Listed on Companies House radio button");
        Apprentices.clickXpath("//*[@id=\"content\"]/div/div/form/section[1]/label");

        // [Add an organisation] Enter email address
        Apprentices.common("[Add an organisation] Enter Companies House number");
        Apprentices.sendKeys("CompaniesHouseNumber", "00445790");

        // [Add an organisation] Click the Listed on Companies House radio button"
        Apprentices.common("[Add an organisation] Click the Continue button");
        Apprentices.clickId("addOrganisation");

        // [Allowing your tax details to be used] Check heading displays "Allowing your tax details to be used"
        Apprentices.common("[Allowing your tax details to be used] Check heading displays \"Allowing your tax details to be used\"");
        Apprentices.checkTextClassName("heading-xlarge", "Allowing your tax details to be used", "Check \"Allowing your tax details to be used\" is displayed");

        // [Allowing your tax details to be used] Click the Agree and continue button"
        Apprentices.common("[Allowing your tax details to be used] Click the Agree and continue button");
        Apprentices.clickId("agree_and_continue");

        // [Sign in mock tax service] Click the Sign in button"
        Apprentices.common("[Sign in mock tax service] Check heading displays \"Sign in\"");
        Apprentices.checkTextXPath("//*[@id=\"content\"]/div[2]/article/h1", "Sign in", "Check \"Sign in\" is displayed");

        // [Sign in mock tax service] Enter user ID
        Apprentices.common("[Sign in mock tax service] Enter user ID N07TNN1KAA02");
        Apprentices.sendKeys("userId", "N07TNN1KAA02");

        // [Sign in mock tax service] Enter user password
        Apprentices.common("[Sign in mock tax service] Enter user ID N07TNN1KAA02");
        Apprentices.sendKeys("password", "thisisatestaccount");

        // [Sign in mock tax service] Click the sign in button
        Apprentices.common("[Sign In] Click the sign in button");
        Apprentices.clickClassName("button");

        // [Sign in mock tax service] Click the Sign in button"
        Apprentices.common("[Sign in mock tax service] Check heading displays \"Authority to interact with HMRC on your behalf\"");
        Apprentices.checkTextXPath("//*[@id=\"content\"]/div[2]/article/h1", "Authority to interact with HMRC on your behalf", "Check \"Authority to interact with HMRC on your behalf\" is displayed");

        // [Sign in mock tax service] Click Grant Authority button
        Apprentices.common("[Sign In] Click the Grant Authority button");
        Apprentices.clickClassName("button");

        // [Check details] Check heading displays "Check details"
        Apprentices.common("[Check details] Check heading displays \"Check details\"");
        Apprentices.checkTextClassName("heading-xlarge", "Check details", "Check \"Check details\" is displayed");

        // [Check details] Click These details are correct button"
        Apprentices.common("[Allowing your tax details to be used] Click These details are correct button");
        Apprentices.clickId("continue");

        // [Your legal agreement] Check heading displays "Your legal agreement"
        Apprentices.common("[Your legal agreement] Check heading displays \"Your legal agreement\"");
        Apprentices.checkTextClassName("heading-xlarge", "Your legal agreement", "Check \"Your legal agreement\" is displayed");

        // [Your legal agreement] Click the Continue button"
        Apprentices.common("[Your legal agreement] Click the Continue button");
        Apprentices.clickId("continue");

        // [Account Home] Check heading displays "Account created"
        Apprentices.common("[Account Home] Check heading displays \"Account created\"");
        Apprentices.checkTextClassName("bold-large", "Account created", "Check \"Account created\" is displayed");

        // [Account Home] Click Apprenticeships hyperlink"
        Apprentices.common("[Allowing your tax details to be used] Click Apprenticeships hyperlink");
        Apprentices.clickId("proposition-name");

        // [Your levy accounts] Check heading displays "Your accounts"
        Apprentices.common("[Your levy accounts] Check heading displays \"Your accounts\"");
        Apprentices.checkTextClassName("heading-xlarge", "Your accounts", "Check \"Your accounts\" is displayed");

    }
}
