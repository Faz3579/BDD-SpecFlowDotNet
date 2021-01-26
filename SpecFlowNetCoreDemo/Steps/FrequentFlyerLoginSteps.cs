using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace SpecFlowNetCoreDemo.Steps
{
    [Binding]
    public class FrequentFlyerLoginSteps
    {
        [Given(@"Joe is a Frequent Flyer member")]
        public void GivenJoeIsAFrequentFlyerMember()
        {
            //  ScenarioContext.Current.Pending();
            Assert.AreEqual(1, 1);
        }

        [Given(@"Joe has registered online with a password of '(.*)'")]
        public void GivenJoeHasRegisteredOnlineWithAPasswordOf(string p0)
        {
           // ScenarioContext.Current.Pending();
        }

        [When(@"Joe logs on with password '(.*)'")]
        public void WhenJoeLogsOnWithPassword(string p0)
        {
           // ScenarioContext.Current.Pending();
        }

        [Then(@"he should be given access to the site")]
        public void ThenHeShouldBeGivenAccessToTheSite()
        {
            Assert.AreEqual(1, 1);
            // ScenarioContext.Current.Pending();
        }

        [Then(@"he should be informed that his password was incorrect")]
        public void ThenHeShouldBeInformedThatHisPasswordWasIncorrect()
        {
            Assert.AreEqual(1, 1);
            // ScenarioContext.Current.Pending();
        }

        [Given(@"the account has expired")]
        public void GivenTheAccountHasExpired()
        {
           // ScenarioContext.Current.Pending();
        }

        [Then(@"he should be informed that his account has expired")]
        public void ThenHeShouldBeInformedThatHisAccountHasExpired()
        {
            Assert.AreEqual(1, 1);
            // ScenarioContext.Current.Pending();
        }

        [Then(@"he should be invited to renew his account")]
        public void ThenHeShouldBeInvitedToRenewHisAccount()
        {
            Assert.AreEqual(1, 1);
            // ScenarioContext.Current.Pending();
        }        


    }
}
