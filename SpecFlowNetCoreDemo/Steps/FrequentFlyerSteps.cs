using NUnit.Framework;
using SpecFlowNetCoreDemo.Models;
using SpecFlowNetCoreDemo.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SpecFlowNetCoreDemo.Steps
{
    [Binding]
    public class FrequentFlyerSteps
    {
        FrequenFlyerService svc = new FrequenFlyerService();

        [Given(@"user ""(.*)"" is not a Frequent Flyer member")]
        public void GivenUserIsNotAFrequentFlyerMember(string userName)
        {
            Response res = svc.IsUserFrequentFlyer(userName);
            Assert.AreEqual(res.StatusCode, 404);
        }

        [When(@"user ""(.*)"" registers on the Frequent Flyer program")]
        public void WhenUserRegistersOnTheFrequentFlyerProgram(string userName)
        {
            UserDetails user = svc.AddUser(userName);
            Assert.IsNotNull(user);
        }


        [Then(@"user ""(.*)"" should have a status of BRONZE")]
        public void ThenUserShouldHaveAStatusOfBRONZE(string userName)
        {
            string status = svc.GetStatus(userName);
            Assert.AreEqual(status, "Bronze");

        }

        [Given(@"""(.*)"" is a FrequentFlyer member")]
        public void GivenIsAFrequentFlyerMember(string userName)
        {
            Response res = svc.IsUserFrequentFlyer(userName);
            Assert.AreEqual(res.StatusCode, 200);
        }

        [Given(@"""(.*)"" has ""(.*)"" status points")]
        public void GivenHasStatusPoints(string userName, int points)
        {
            UserDetails data = svc.userDetails.Where(x => x.Name == userName && x.RewardPoints == points).FirstOrDefault();
            Assert.IsNotNull(data);
        }

        [When(@"""(.*)"" earns ""(.*)"" extra status points")]
        public void WhenEarnsExtraStatusPoints(string userName, int points)
        {
            var obj = svc.AddEarnPoints(userName, points);
        }

        [Then(@"he should have a status of ""(.*)""")]
        public void ThenHeShouldHaveAStatusOf(string status)
        {
            string updatedStatus = svc.GetStatus("William");
            Assert.AreEqual(updatedStatus, status);
            
        }




    }
}
