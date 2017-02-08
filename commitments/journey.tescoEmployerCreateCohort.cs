using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commitments
{
    class journey1TescoEmployerCreateCohortClass
    {
        public static void journey1TescoEmployerCreateCohort()
        {
            Apprentices.outputInfo("Running accountTesco()");

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

            // [Apprentices Page] Click Add an apprentice
            Apprentices.common("[Apprentices Page] Click Add an apprentice");
            Apprentices.clickLinkText("Add an apprentice");

            // [Add an apprentice] Check heading displays Add an apprentice
            Apprentices.common("[Add an apprentice] Check heading displays Add an apprentice");
            Apprentices.checkTextClassName("heading-xlarge", "Add an apprentice", "Check \"Add an apprentice\" is displayed");

            // [Add an apprentice] Click Start now button
            Apprentices.common("[Add an apprentice] Click Start now button");
            Apprentices.clickLinkText("Start now");

            // [Choose organisation] Check heading displays Choose organisation
            Apprentices.common("[Choose organisation] Check heading displays Choose organisation");
            Apprentices.checkTextClassName("heading-xlarge", "Choose organisation", "Check \"Choose organisation\" is displayed");

            if (Apprentices.includeNegTest == 1)
            {
                // [Choose organisation] Click the Continue button, This should invoke an error
                Apprentices.common("[Choose organisation] Click the Continue button, This should invoke an error");
                Apprentices.clickClassName("button");

                // [Choose organisation] Check errors to fix heading is displayed
                Apprentices.common("[Choose organisation] Check heading displays Errors to fix");
                Apprentices.checkTextId("error-summary", "Errors to fix", "Check \"Errors to fix\" is displayed");

                // [Choose organisation] Check Please choose an option is displayed
                Apprentices.common("[Choose organisation] Check Please choose an option is displayed");
                Apprentices.checkTextClassName("field-validation-error", "Please choose an option", "Check \"Please choose an option\" is displayed");

                // [Choose organisation] Check heading displays Choose organisation
                Apprentices.common("[Choose organisation] Check heading displays Choose organisation");
                Apprentices.checkTextClassName("heading-xlarge", "Choose organisation", "Check \"Choose organisation\" is displayed");
            }

            // [Choose organisation] Click the Tesco radio button
            Apprentices.common("[Choose organisation] Click the Tesco radio button");
            Apprentices.clickFor("LegalEntityCode-00445790");

            // [Choose organisation] Click the Continue button
            Apprentices.common("[Choose organisation] Click the Continue button");
            Apprentices.clickClassName("button");

            // [Add training provider details] Check Heading
            Apprentices.common("[Add training provider details] Check Heading");
            Apprentices.checkTextClassName("heading-xlarge", "Add training provider details", "Check \"Add training provider details\" is displayed");

            if (Apprentices.includeNegTest == 1)
            {
                // [Add training provider details] Click Continue button, this should invoke an error by submitting an empty form
                Apprentices.common("[Add training provider details] Click Continue button, this should invoke an error by submitting an empty form");
                Apprentices.clickClassName("button");

                // [Add training provider details] Check errors to fix heading is displayed
                Apprentices.common("[Add training provider details] Check heading displays Errors to fix");
                Apprentices.checkTextId("error-summary", "Errors to fix", "Check \"Errors to fix\" is displayed");

                // [Add training provider details] Check Please enter an 8-digit UK Provider Reference Number is displayed
                Apprentices.common("[Choose organisation] Check Please enter an 8-digit UK Provider Reference Number is displayed");
                Apprentices.checkTextClassName("field-validation-error", "Please enter an 8-digit UK Provider Reference Number", "Check \"Please enter an 8-digit UK Provider Reference Number\" is displayed");

                // [Add training provider details] Enter 1 into the UK Provider Reference Number input field
                Apprentices.common("[Add training provider details] Enter 1 into the UK Provider Reference Number input field");
                Apprentices.sendKeys("ProviderId", "1");

                // [Add training provider details] Click Continue button
                Apprentices.common("[Add training provider details] Click Continue button");
                Apprentices.clickClassName("button");

                // [Add training provider details] Check Please enter an 8-digit UK Provider Reference Number is displayed
                Apprentices.common("[Choose organisation] Check Please enter an 8-digit UK Provider Reference Number is displayed");
                Apprentices.checkTextClassName("field-validation-error", "Please enter an 8-digit UK Provider Reference Number", "Check \"Please enter an 8-digit UK Provider Reference Number\" is displayed");

                // [Add training provider details] Clear UK Provider Reference Number input field
                Apprentices.common("[Add training provider details] Clear UK Provider Reference Number input field");
                Apprentices.clearInput("ProviderId");

                // [Add training provider details] Enter 10000534 into the UK Provider Reference Number input field
                Apprentices.common("[Add training provider details] Enter 123456789 into the UK Provider Reference Number input field");
                Apprentices.sendKeys("ProviderId", "123456789");

                // [Add training provider details] Click Continue button
                Apprentices.common("[Add training provider details] Click Continue button");
                Apprentices.clickClassName("button");

                // [Add training provider details] Check Please enter an 8-digit UK Provider Reference Number is displayed
                Apprentices.common("[Choose organisation] Check Please enter an 8-digit UK Provider Reference Number is displayed");
                Apprentices.checkTextClassName("field-validation-error", "Please enter an 8-digit UK Provider Reference Number", "Check \"Please enter an 8-digit UK Provider Reference Number\" is displayed");

                // [Add training provider details] Check Heading
                Apprentices.common("[Add training provider details] Check Heading");
                Apprentices.checkTextClassName("heading-xlarge", "Add training provider details", "Check \"Add training provider details\" is displayed");

                // [Add training provider details] Clear UK Provider Reference Number input field
                Apprentices.common("[Add training provider details] Clear UK Provider Reference Number input field");
                Apprentices.clearInput("ProviderId");
            }

            // [Add training provider details] Enter 10000534 into the UK Provider Reference Number input field
            Apprentices.common("[Add training provider details] Enter 10000534 into the UK Provider Reference Number input field");
            Apprentices.sendKeys("ProviderId", "10000534");

            // [Add training provider details] Click Continue button
            Apprentices.common("[Add training provider details] Click Continue button");
            Apprentices.clickClassName("button");

            // [Confirm training provider] Check heading displays Confirm training provider
            Apprentices.common("[Confirm training provider] Check heading displays Confirm training provider");
            Apprentices.checkTextClassName("heading-xlarge", "Confirm training provider", "Check \"Confirm training provider\" is displayed");

            // [Confirm training provider] Check BARNFIELD COLLEGE is displayed
            Apprentices.common("[Confirm training provider] Check BARNFIELD COLLEGE is displayed");
            Apprentices.checkTextClassName("heading-large", "BARNFIELD COLLEGE", "Check \"BARNFIELD COLLEGE\" is displayed");

            if (Apprentices.includeNegTest == 1)
            {
                // [Confirm training provider] Click No, use BARNFIELD COLLEGE
                Apprentices.common("[Confirm training provider] Click No, change UK Provider Reference Number");
                Apprentices.clickFor("Confirmation-False");

                // [Confirm training provider] Click Continue button
                Apprentices.common("[Confirm training provider] Click Continue button");
                Apprentices.clickClassName("button");

                // [Add training provider details] Check Heading
                Apprentices.common("[Add training provider details] Check Heading");
                Apprentices.checkTextClassName("heading-xlarge", "Add training provider details", "Check \"Add training provider details\" is displayed");

                // [Add training provider details] Enter 10000534 into the UK Provider Reference Number input field
                Apprentices.common("[Add training provider details] Enter 10000534 into the UK Provider Reference Number input field");
                Apprentices.sendKeys("ProviderId", "10000534");

                // [Add training provider details] Click Continue button
                Apprentices.common("[Add training provider details] Click Continue button");
                Apprentices.clickClassName("button");

                // [Confirm training provider] Check heading displays Confirm training provider
                Apprentices.common("[Confirm training provider] Check heading displays Confirm training provider");
                Apprentices.checkTextClassName("heading-xlarge", "Confirm training provider", "Check \"Confirm training provider\" is displayed");

                // [Confirm training provider] Check BARNFIELD COLLEGE is displayed
                Apprentices.common("[Confirm training provider] Check BARNFIELD COLLEGE is displayed");
                Apprentices.checkTextClassName("heading-large", "BARNFIELD COLLEGE", "Check \"BARNFIELD COLLEGE\" is displayed");
            }

            // [Confirm training provider] Click Yes, use BARNFIELD COLLEGE
            Apprentices.common("[Confirm training provider] Click Yes, use BARNFIELD COLLEGE");
            Apprentices.clickFor("Confirmation-True");

            // [Confirm training provider] Click Continue button
            Apprentices.common("[Confirm training provider] Click Continue button");
            Apprentices.clickClassName("button");

            // [Start adding apprentices] Check Heading displays Start adding apprentices
            Apprentices.common("[Start adding apprentices] Check Heading displays Start adding apprentices");
            Apprentices.checkTextClassName("heading-xlarge", "Start adding apprentices", "Check \"Start adding apprentices\" is displayed");

            if (Apprentices.includeNegTest == 1)
            {
                // [Start adding apprentices] Click Continue button, this should invoke validation error
                Apprentices.common("[Start adding apprentices] Click Continue button, this should invoke validation error");
                Apprentices.clickClassName("button");

                // [Start adding apprentices] Check errors to fix heading is displayed
                Apprentices.common("[Start adding apprentices] Check heading displays Errors to fix");
                Apprentices.checkTextId("error-summary", "Errors to fix", "Check \"Errors to fix\" is displayed");

                // [Start adding apprentices] Check Please choose an option is displayed
                Apprentices.common("[Start adding apprentices] Check Please choose an option is displayed");
                Apprentices.checkTextClassName("field-validation-error", "Please choose an option", "Check \"Please choose an option\" is displayed");
            }

            // [Start adding apprentices] Click I will add apprentices
            Apprentices.common("[Start adding apprentices] Click I will add apprentices");
            Apprentices.clickFor("SelectedRoute-Employer");

            // [Start adding apprentices] Click Continue button
            Apprentices.common("[Start adding apprentices] Click Continue button");
            Apprentices.clickClassName("button");

            // [Add apprentices] Check Heading displays Add apprentices
            Apprentices.common("[Add apprentices] Check Heading displays Add apprentice");
            Apprentices.checkTextClassName("heading-xlarge", "Add apprentices", "Check \"Add apprentices\" is displayed");

            // [Add apprentices] Click "Add an apprentice" button
            Apprentices.common("[Add apprentices] Click Add an apprentice button");
            Apprentices.clickLinkText("Add an apprentice");

            // [Add an apprentice] Check Heading displays Add apprentices
            Apprentices.common("[Add an apprentice] Check Heading displays Add an apprentice");
            Apprentices.checkTextClassName("heading-xlarge", "Add an apprentice", "Check \"Add an apprentice\" is displayed");

            if (Apprentices.includeNegTest == 1)
            {
                // [Add an apprentice] Click Add button, should invoke an error
                Apprentices.common("[Add an apprentice] Click Add button, should invoke an error as \"First name\" and \"Last name\" is empty");
                Apprentices.clickClassName("button");

                // [Add an apprentice] Check errors to fix heading is displayed
                Apprentices.common("[Add an apprentice] Check heading displays Errors to fix");
                Apprentices.checkTextId("error-summary", "Errors to fix", "Check \"Errors to fix\" is displayed");

                // [Add an apprentice] Check "First name must be entered" is displayed
                Apprentices.common("[Add an apprentice] Check \"First name must be entered\" is diplayed");
                Apprentices.checkTextId("error-message-FirstName", "First name must be entered", "Check \"First name must be entered\" is displayed");

                // [Add an apprentice] Check "Last name must be entered" is displayed
                Apprentices.common("[Add an apprentice] Check \"Last name must be entered\" is diplayed");
                Apprentices.checkTextId("error-message-LastName", "Last name must be entered", "Check \"Last name must be entered\" is displayed");
            }

            // [Add an apprentice] Enter First into the "First name" input field
            Apprentices.common("[Add an apprentice]  Enter First into the \"First name\" input field");
            Apprentices.sendKeys("FirstName", "First");

            if (Apprentices.includeNegTest == 1)
            {
                // [Add an apprentice] Click Add button, should invoke an error
                Apprentices.common("[Add an apprentice] Click Add button, should invoke an error as \"Last name\" is empty");
                Apprentices.clickClassName("button");

                // [Add an apprentice] Check errors to fix heading is displayed
                Apprentices.common("[Add an apprentice] Check heading displays Errors to fix");
                Apprentices.checkTextId("error-summary", "Errors to fix", "Check \"Errors to fix\" is displayed");

                // [Add an apprentice] Check "Last name must be entered" is displayed
                Apprentices.common("[Add an apprentice] Check \"Last name must be entered\" is diplayed");
                Apprentices.checkTextId("error-message-LastName", "Last name must be entered", "Check \"Last name must be entered\" is displayed");

                // [Add an apprentice] Clear UK \"First name\" input field
                Apprentices.common("[Add training provider details] Clear UK Provider Reference Number input field");
                Apprentices.clearInput("FirstName");
            }

            // [Add an apprentice] Enter "Last" into the "Last name" input field
            Apprentices.common("[Add an apprentice] Enter \"Last\" into the \"Last name\" input field");
            Apprentices.sendKeys("LastName", "Last");

            if (Apprentices.includeNegTest == 1)
            {
                // [Add an apprentice] Click Add button, should invoke an error
                Apprentices.common("[Add an apprentice] Click Add button, should invoke an error as \"First name\" is empty");
                Apprentices.clickClassName("button");

                // [Add an apprentice] Check errors to fix heading is displayed
                Apprentices.common("[Add an apprentice] Check heading displays Errors to fix");
                Apprentices.checkTextId("error-summary", "Errors to fix", "Check \"Errors to fix\" is displayed");

                // [Add an apprentice] Check "First name must be entered" is displayed
                Apprentices.common("[Add an apprentice] Check \"First name must be entered\" is diplayed");
                Apprentices.checkTextId("error-message-FirstName", "First name must be entered", "Check \"First name must be entered\" is displayed");

                // [Add an apprentice] Enter First into the "First name" input field
                Apprentices.common("[Add an apprentice]  Enter First into the \"First name\" input field");
                Apprentices.sendKeys("FirstName", "First");
            }

            // [Add an apprentice] Enter "01" into the "Date of birth, Day" input field
            Apprentices.common("[Add an apprentice] Enter \"01\" into the \"Date of birth, Day\" input field");
            Apprentices.sendKeys("DateOfBirth_Day", "01");

            // [Add an apprentice] Enter "01" into the "Date of birth, Month" input field
            Apprentices.common("[Add an apprentice] Enter \"01\" into the \"Date of birth, Month\" input field");
            Apprentices.sendKeys("DateOfBirth_Month", "01");

            if (Apprentices.includeNegTest == 1)
            {
                // [Add an apprentice] Enter "2018" into the "Date of birth Year" input field
                Apprentices.common("[Add an apprentice] Enter \"2018\" into the \"Date of birth Year\" input field");
                Apprentices.sendKeys("DateOfBirth_Year", "2018");

                // [Add an apprentice] Click Add button, should invoke an error "The date of birth must be in the past"
                Apprentices.common("[Add an apprentice] Click Add button, should invoke an error \"The date of birth must be in the past\"");
                Apprentices.clickClassName("button");

                // [Add an apprentice] Check errors to fix heading is displayed
                Apprentices.common("[Add an apprentice] Check heading displays Errors to fix");
                Apprentices.checkTextId("error-summary", "Errors to fix", "Check \"Errors to fix\" is displayed");

                // [Add an apprentice] Check "The date of birth must be in the pastr" is displayed
                Apprentices.common("[Add an apprentice] Check \"The date of birth must be in the past\" is diplayed");
                Apprentices.checkTextId("error-message-DateOfBirth", "The date of birth must be in the past", "Check \"The date of birth must be in the past\" is displayed");

                // [Add an apprentice] Clear "Date of birth Year" input field
                Apprentices.common("[Add training provider details] Clear \"Date of birth Year\" input field");
                Apprentices.clearInput("DateOfBirth_Year");
            }

            // [Add an apprentice] Enter "1980" into the "Date of birth Year" input field
            Apprentices.common("[Add an apprentice] Enter \"1980\" into the \"Date of birth Year\" input field");
            Apprentices.sendKeys("DateOfBirth_Year", "1980");

            // [Add an apprentice] Enter "02" into the "Planned training start date, Month" input field
            Apprentices.common("[Add an apprentice] Enter \"1980\" into the \"Date of birth Year\" input field");
            Apprentices.sendKeys("StartDate_Month", "02");

            // [Add an apprentice] Enter "2018" into the "Planned training start date, Year" input field
            Apprentices.common("[Add an apprentice] Enter \"2018\" into the \"Date of birth Year\" input field");
            Apprentices.sendKeys("StartDate_Year", "2018");

            // [Add an apprentice] Enter "02" into the "Planned training finish  date, Month" input field
            Apprentices.common("[Add an apprentice] Enter \"02\" into the \"Planned training finish  date, Month\" input field");
            Apprentices.sendKeys("EndDate_Month", "02");

            if (Apprentices.includeNegTest == 1)
            {
                // [Add an apprentice] Enter "2017" into the "Planned training finish  date, Year" input field
                Apprentices.common("[Add an apprentice] Enter \"2017\" into the \"Planned training finish  date, Year\" input field");
                Apprentices.sendKeys("EndDate_Year", "2017");

                // [Add an apprentice] Click Add button, should invoke an error "The end date must be later than the start date"
                Apprentices.common("[Add an apprentice] Click Add button, should invoke an error \"The end date must be later than the start date\"");
                Apprentices.clickClassName("button");

                // [Add an apprentice] Check errors to fix heading is displayed
                Apprentices.common("[Add an apprentice] Check heading displays Errors to fix");
                Apprentices.checkTextId("error-summary", "Errors to fix", "Check \"Errors to fix\" is displayed");

                // [Add an apprentice] Check "The end date must be later than the start date" is displayed
                //common("[Add an apprentice] Check \"The end date must be later than the start date\" is diplayed");
                //checkTextXPath("//*[@id=\"error-message-EndDate\"]", "The end date must be later than the start date", "Check \"The end date must be later than the start date\" is displayed");

                // [Add an apprentice] Clear Projected training finish date input field
                Apprentices.common("[Add training provider details] Clear Projected training finish date input field");
                Apprentices.clearInput("EndDate_Year");
            }

            // [Add an apprentice] Enter "2019" into the "Projected training finish date, Year" input field
            Apprentices.common("[Add an apprentice] Enter \"2019\" into the \"Projected training finish date, Year\" input field");
            Apprentices.sendKeys("EndDate_Year", "2019");


            // [Add an apprentice] Enter "1000" into the "Total agreed training cost (excluding VAT)" input field
            Apprentices.common("[Add an apprentice] Enter \"1000\" into the \"Total agreed training cost (excluding VAT)\" input field");
            Apprentices.sendKeys("Cost", "1000");

            // [Add an apprentice] Enter "Ref1" into the "Reference (optional)" input field
            Apprentices.common("[Add an apprentice] Enter \"REF1\" into the \"Reference (optional)\" input field");
            Apprentices.sendKeys("EmployerRef", "Ref1");

            // [Add an apprentice] Click Add button
            Apprentices.common("[Add an apprentice] Click Add button");
            Apprentices.clickClassName("button");

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
            Apprentices.common("[Add apprentices] Check Heading displays Add apprentice");
            Apprentices.checkTextClassName("heading-xlarge", "Add apprentices", "Check \"Add apprentices\" is displayed");

            // [Add apprentices] Click "Save and continue" button
            Apprentices.common("[Add an apprentice] Click \"Save and continue\" button");
            Apprentices.clickLabel("Save and continue");

            // [Choose an option] Check Heading displays "Choose an option"
            Apprentices.common("[Choose an option] Check Heading displays \"Choose an option\"");
            Apprentices.checkTextClassName("heading-xlarge", "Choose an option", "Check Heading displays \"Choose an option\"");

            // [Choose an option] Click Send to training provider to review or add details radio button
            Apprentices.common("[Choose an option] Click Send to training provider to review or add details radio button");
            Apprentices.clickId("changeOne");

            // [Choose an option] Click "Continue" button
            Apprentices.common("[Choose an option] Click \"Continue\" button");
            Apprentices.clickClassName("button");

            // [Instructions for your training provider] Check Heading displays "Choose an option"
            Apprentices.common("[Instructions for your training provider] Check Heading displays \"Instructions for your training provider\"");
            Apprentices.checkTextClassName("heading-xlarge", "Instructions for your training provider", "Check Heading displays \"Instructions for your training provider\"");

            // [Instructions for your training provider] Enter "Hi, Please check and add in the training course that this apprentice, Thank you." into the "Instructions (optional)" input field
            Apprentices.common("[Instructions for your training provider] Enter \"Hi, Please check and add in the training course that this apprentice, Thank you.\" into the \"Instructions (optional)\" input field");
            Apprentices.sendKeys("Message", "Hi, Please check and add in the training course that this apprentice, Thank you.");

            // [Instructions for your training provider] Click "Send" button
            Apprentices.common("[Instructions for your training provider] Click \"Send\" button");
            Apprentices.clickClassName("button");

            // [Instructions sent] Check Heading displays "Instructions sent"
            Apprentices.common("[Instructions sent] Check Heading displays \"Instructions sent\"");
            Apprentices.checkTextClassName("heading-xlarge", "Instructions sent", "Check Heading displays \"Instructions sent\"");

            // [Instructions sent] Click Apprentices link
            Apprentices.common("[Instructions sent] Click Apprentices link");
            Apprentices.clickLinkText("Apprentices");

            // [Apprentices] Click "Requests in progress" link
            Apprentices.common("[Apprentices] Click \"Requests in progress\" link");
            Apprentices.clickLinkText("Requests in progress");

        }
    }
}
