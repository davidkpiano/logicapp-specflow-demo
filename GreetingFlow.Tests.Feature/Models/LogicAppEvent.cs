namespace GreetingFlow.Tests.Feature.Models
{
    public class LogicAppEvent
    {
        public LogicAppEvent(string stepName, string status)
        {
            StepName = stepName;
            Status = status;
        }

        public string StepName { get; }
        public string Status { get; }

        public override string ToString() => $"{StepName}|{Status}";
    }
}
