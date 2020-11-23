using System;

namespace GreetingFlow.Tests.Feature.Utilities
{
    public static class EnvVariables
    {
        public static string AzureClientId = Environment.GetEnvironmentVariable("AzureClientId");
        public static string AzureClientSecret = Environment.GetEnvironmentVariable("AzureClientSecret");
        public static string AzureTenantId = Environment.GetEnvironmentVariable("AzureTenantId");
        public static string SubscriptionId = Environment.GetEnvironmentVariable("SubscriptionId");
        public static string ResourceGroup = Environment.GetEnvironmentVariable("ResourceGroup");

        public static string LogicAppTriggerUrl = Environment.GetEnvironmentVariable("LogicAppTriggerUrl");
    }
}
