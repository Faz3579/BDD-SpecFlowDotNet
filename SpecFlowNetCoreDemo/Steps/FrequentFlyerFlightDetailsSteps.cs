using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace SpecFlowNetCoreDemo.Steps
{
    [Binding]
    public class FrequentFlyerFlightDetailsSteps
    {
        [Given(@"I need to know the details of flight number FH(.*)")]
        public void GivenINeedToKnowTheDetailsOfFlightNumberFH(int p0)
        {
           // ScenarioContext.Current.Pending();
        }

        [When(@"I request the details about this flight")]
        public void WhenIRequestTheDetailsAboutThisFlight()
        {
           // ScenarioContext.Current.Pending();
        }

        [Then(@"I should receive the following:")]
        public void ThenIShouldReceiveTheFollowing(Table table)
        {
           // ScenarioContext.Current.Pending();
        }

    }
}
