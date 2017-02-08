using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Commitments
{
    class journey1TescoEmployerApproveCohortClass
    {
        public static void journey1TescoEmployerApproveCohort()
        {
            Apprentices.outputInfo("Running journey1TescoEmployerApproveCohort");

            // [Your levy accounts] Check heading displays "Your accounts"
            Apprentices.common("[Your accounts] Check heading displays \"Your accounts\"");
            Apprentices.checkTextClassName("heading-xlarge", "Your accounts", "Check \"Your accounts\" is displayed");

            // [Your accounts] Click Open link for Tesco
            Apprentices.common("[Add an apprentice] Click \"Open\" link for TESCO PLC");
            Apprentices.clickLabel("View account homepage for TESCO PLC");

            // [Employer Account Homepage] Check heading displays TESCO PLC
            Apprentices.common("[Employer Account Homepage] Check heading displays TESCO PLC");
            Apprentices.checkTextId("company-Name", "TESCO PLC", "Check \"TESCO PLC\" is displayed");

            // [Employer Account Homepage] Click Apprentices link
            Apprentices.common("[Employer Account Homepage] Click Apprentices link");
            Apprentices.clickLinkText("Apprentices");

            // [Apprentices Page] Check heading displays Apprentices.
            Apprentices.common("[Apprentices Page] Check heading displays Apprentices");
            Apprentices.checkTextClassName("heading-xlarge", "Apprentices", "Check \"Apprentices\" is displayed");

            // [Apprentices Page] Click Requests in progress
            Apprentices.common("[Apprentices Page] Click Requests in progress");
            Apprentices.clickLinkText("Requests in progress");

            // [Add an apprentice] Check heading displays Requests in progress
            Apprentices.common("[Add an apprentice] Check heading displays Requests in progress");
            Apprentices.checkTextClassName("heading-xlarge", "Requests in progress", "Check \"Requests in progress\" is displayed");

            // [Add an apprentice] Click "View" link
            Apprentices.common("[Provider] Open cohort " + Apprentices.cohort);
            Apprentices.driver.Url = Apprentices.urlEmployer + "/accounts/" + Apprentices.leavy + "/apprentices/" + Apprentices.cohort + "/details";

            // [Add an apprentice] Click Apprentice that was just created
            Apprentices.common("[Add an apprentice] Click Apprentice that was just created");
            Apprentices.getApprentice("First Last");

            // [Edit an apprentice] Check Heading displays Add apprentices
            Apprentices.common("[Edit an apprentice] Check Heading displays Edit an apprentice");
            Apprentices.checkTextClassName("heading-xlarge", "Edit an apprentice", "Check \"Edit an apprentice\" is displayed");

            // [Edit an apprentice] Get apprentices codes
            Apprentices.getApprenticeCodes();

            // [Edit an apprentice] Check "First" is displayed in the "First Name" input field
            Apprentices.common("[Edit an apprentice] Check \"First\" is displayed in the \"First Name\" input field");
            Apprentices.checkValue("FirstName", "First", "Check \"First\" is displayed in the \"First Name\" input field");
            Apprentices.clickId("FirstName");

            // [Edit an apprentice] Check "Last" is displayed in the "Last Name" input field
            Apprentices.common("[Edit an apprentice] Check \"Last\" is displayed in the \"Last Name\" input field");
            Apprentices.checkValue("LastName", "Last", "Check \"Last\" is displayed in the \"Last Name\" input field");
            Apprentices.clickId("LastName");

            // [Edit an apprentice] Check "1" is displayed in the "Date of birth, Day" input field
            Apprentices.common("[Edit an apprentice] Check \"1\" is displayed in the \"Date of birth, Day\" input field");
            Apprentices.checkValue("DateOfBirth_Day", "1", "Check \"1\" is displayed in the \"Date of birth, Day\" input field");
            Apprentices.clickId("DateOfBirth_Day");

            // [Edit an apprentice] Check "1" is displayed in the "Date of birth, Month" input field
            Apprentices.common("[Edit an apprentice] Check \"1\" is displayed in the \"Date of birth, Month\" input field");
            Apprentices.checkValue("DateOfBirth_Month", "1", "Check \"1\" is displayed in the \"Date of birth, Month\" input field");
            Apprentices.clickId("DateOfBirth_Month");

            // [Edit an apprentice] Check "1980" is displayed in the "Date of birth, Year" input field
            Apprentices.common("[Edit an apprentice] Check \"1980\" is displayed in the \"Date of birth, Year\" input field");
            Apprentices.checkValue("DateOfBirth_Year", "1980", "Check \"1980\" is displayed in the \"Date of birth, Year\" input field");
            Apprentices.clickId("DateOfBirth_Year");

            // [Edit an apprentice] Check "2" is displayed in the "Planned training start date, Month" input field
            Apprentices.common("[Edit an apprentice] Check \"2\" is displayed in the \"Planned training start date, Month\" input field");
            Apprentices.checkValue("StartDate_Month", "2", "Check \"2\" is displayed in the \"Planned training start date, Month\" input field");
            Apprentices.clickId("StartDate_Month");

            // [Edit an apprentice] Check "2018" is displayed in the "Planned training start date, Year" input field
            Apprentices.common("[Edit an apprentice] Check \"2018\" is displayed in the \"Planned training start date, Year\" input field");
            Apprentices.checkValue("StartDate_Year", "2018", "Check \"2018\" is displayed in the \"Planned training start date, Year\" input field");
            Apprentices.clickId("StartDate_Year");

            // [Edit an apprentice] Check "2" is displayed in the "Projected training finish date, Month" input field
            Apprentices.common("[Edit an apprentice] Check \"2\" is displayed in the \"Projected training finish date, Month\" input field");
            Apprentices.checkValue("EndDate_Month", "2", "Check \"2\" is displayed in the \"Projected training finish date, Month\" input field");
            Apprentices.clickId("EndDate_Month");

            // [Edit an apprentice] Check "2019" is displayed in the "Projected training finish date, Year" input field
            Apprentices.common("[Edit an apprentice] Check \"2019\" is displayed in the \"Projected training finish date, Year\" input field");
            Apprentices.checkValue("EndDate_Year", "2019", "Check \"2019\" is displayed in the \"Projected training finish date, Year\" input field");
            Apprentices.clickId("EndDate_Year");

            // [Edit an apprentice] Check "1000" is displayed in the "Total agreed training cost (excluding VAT)" input field
            Apprentices.common("[Edit an apprentice] Check \"1000\" is displayed in the \"Total agreed training cost (excluding VAT)\" input field");
            Apprentices.checkValue("Cost", "1000", "Check \"1000\" is displayed in the \"Total agreed training cost (excluding VAT)\" input field");
            Apprentices.clickId("Cost");

            // [Edit an apprentice] Check "Ref1" is displayed in the "Reference (optional)" input field
            Apprentices.common("[Edit an apprentice] Check \"Ref1\" is displayed in the \"Reference (optional)\" input field");
            Apprentices.checkValue("EmployerRef", "Ref1", "Check \"Ref1\" is displayed in the \"Reference (optional)\" input field");
            Apprentices.clickId("EmployerRef");

            // [Edit an apprentice] Click "Save" button
            Apprentices.common("[Add an apprentice] Click \"Save\" button");
            Apprentices.clickClassName("button");

            // [Add apprentices] Check Heading displays Add apprentices
            Apprentices.common("[Add apprentices] Check Heading displays Add apprentices");
            Apprentices.checkTextClassName("heading-xlarge", "Add apprentices", "Check \"Add apprentices\" is displayed");

            // [Add apprentices] Click "Save and continue" button
            Apprentices.common("[Add an apprentice] Click \"Save and continue\" button");
            Apprentices.clickLabel("Save and continue");

            // [Choose an option] Click "Approve" button
            Apprentices.common("[Choose an option] Click \"Approve\" button");
            Apprentices.clickId("changeTwo");

            // [Choose an option] Click "Continue" button
            Apprentices.common("[Choose an option] Click \"Continue\" button");
            Apprentices.clickClassName("button");

        }

    }
}
