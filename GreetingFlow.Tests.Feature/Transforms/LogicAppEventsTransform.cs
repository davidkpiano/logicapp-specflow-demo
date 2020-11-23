using System.Collections.Generic;
using System.Linq;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using GreetingFlow.Tests.Feature.Models;

namespace GreetingFlow.Tests.Feature.Transforms
{
    [Binding]
    public class LogicAppEventsTransform
    {
        [StepArgumentTransformation]
        public IList<LogicAppEvent> TransformTableToLogicAppEvents(Table table) =>
            table.CreateSet<LogicAppEvent>().ToList();
    }
}
