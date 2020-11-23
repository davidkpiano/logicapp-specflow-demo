using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace GreetingFlow.Tests.Feature.Steps
{
    [Binding]
    public class UtilityBindings
    {
        [When(@"I wait '(\d+)' seconds for execution to complete")]
        public void WhenIWaitSecondsForExecutionToComplete(int seconds)
        {
            Thread.Sleep(TimeSpan.FromSeconds(seconds));
        }

    }
}
