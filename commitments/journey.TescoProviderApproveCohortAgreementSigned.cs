using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commitments
{
    class journey1TescoProviderApproveCohortAgreementSignedClass
    {
        public static void journey1TescoProviderApproveCohortAgreementSigned()
        {
            // [Provider] Click "Requests in progress" link
            Apprentices.common("[Provider] Open cohort " + Apprentices.cohort);
            Apprentices.driver.Url = Apprentices.urlProvider + Apprentices.providerId + "/apprentices/" + Apprentices.cohort + "/Details";

            // [Provider] Click Apprentice that was created by the employer
            Apprentices.common("[Add an apprentice] Click Apprentice that was created by the employer");
            Apprentices.getApprentice("First Last");

            // [Provider] Enter 1234567890 into "Unique learner number" input field
            Apprentices.common("[Provider] Enter 1234567890 into \"Unique learner number\" input field");
            Apprentices.sendKeys("ULN", "1234567890");

            // [Provider] Enter "acc" and press return on the "Unique learner number" input field
            Apprentices.common("[Provider] Enter \"acc\" and press return on the \"Unique learner number\" input field");
            Apprentices.sendKeys("TrainingCode", "acc");
            Apprentices.sendKey("TrainingCode", "RETURN");

            // [Provider] Enter RefPro1 into "Reference (optional)" input field
            Apprentices.common("[Provider] Enter RefPro1 into \"Reference (optional)\" input field");
            Apprentices.sendKeys("ProviderRef", "RefPro1");

            // TO BE REMOVED  TO BE REMOVED  TO BE REMOVED  TO BE REMOVED  TO BE REMOVED  TO BE REMOVED  TO BE REMOVED  TO BE REMOVED  TO BE REMOVED  TO BE REMOVED  TO BE REMOVED  TO BE REMOVED  TO BE REMOVED  
            Apprentices.common("[Provider] Enter aa000001a into \"National insurance number\" input field");
            Apprentices.sendKeys("NINumber", "aa000001a");

            // [Provider] Click "Save" button
            Apprentices.common("[Provider] Click \"Save\" button");
            Apprentices.clickClassName("button");

            // [Provider] Check Heading displays "Add an apprentice"
            Apprentices.common("[Provider] Check Heading displays \"Add an apprentice\"");
            Apprentices.checkTextClassName("heading-xlarge", "Add an apprentice", "Check Heading displays \"Add an apprentice\"");

            // [Provider] Click "Save and continue" button
            Apprentices.common("[Provider] Click \"Save and continue\" button");
            Apprentices.clickLabel("Save and continue");

            // [Choose an option] Click Approve and send to employer for approval radio button
            Apprentices.common("[Choose an option] Click Approve and send to employer for approval radio button");
            Apprentices.clickId("changeOne");

            // [Provider] Click "Continue" button
            Apprentices.common("[Provider] Click \"Continue\" button");
            Apprentices.clickClassName("button");

            // [Provider] Enter "Hi, All done, please Approve." into the "Instructions (optional)" input field
            Apprentices.common("[Provider] Enter \"Hi, All done, please Approve.\" into the \"Instructions(optional)\" input field");
            Apprentices.sendKeys("Message", "Hi, All done, please Approve.");

            // [Provider] Click "Send" button
            Apprentices.common("[Provider] Click \"Send\" button");
            Apprentices.clickClassName("button");

            // [Provider] Check Heading displays "Instructions sent"
            Apprentices.common("[Provider] Check Heading displays \"Instructions sent\"");
            Apprentices.checkTextClassName("heading-xlarge", "Instructions sent", "Check Heading displays \"Instructions sent\"");

        }
    }
}
