using System.Collections.Generic;
using System.Linq;
using Microsoft.Azure.Management.Logic;
using Microsoft.Azure.Management.Logic.Models;
using GreetingFlow.Tests.Feature.Models;

namespace GreetingFlow.Tests.Feature.Utilities
{
    public class LogicAppExecutionRetriever
    {
        private readonly ILogicManagementClient _client;
        private readonly string _resourceGroup;

        public LogicAppExecutionRetriever(ILogicManagementClient client, string resourceGroup)
        {
            _client = client;
            _resourceGroup = resourceGroup;
        }

        public IList<LogicAppEvent> GetLatestExecutionEvents(string logicApp)
        {
            var events = new List<LogicAppEvent>();

            var workflowRun = GetLatestWorkflowRun(logicApp);
            events.Add(new LogicAppEvent(workflowRun.Trigger.Name, workflowRun.Trigger.Status));

            var workflowRunActions = GetWorkflowRunActions(logicApp, workflowRun.Name);
            events.AddRange(workflowRunActions.Select(action => new LogicAppEvent(action.Name, action.Status)));

            return events;
        }

        private WorkflowRun GetLatestWorkflowRun(string logicApp)
        {
            return _client
                .WorkflowRuns
                .ListWithHttpMessagesAsync(_resourceGroup, logicApp)
                .Result.Body.First();
        }

        private IEnumerable<WorkflowRunAction> GetWorkflowRunActions(string logicApp, string workflowRunId)
        {
            return _client
                .WorkflowRunActions
                .ListWithHttpMessagesAsync(_resourceGroup, logicApp, workflowRunId)
                .Result.Body.OrderBy(x => x.StartTime);
        }
    }
}
