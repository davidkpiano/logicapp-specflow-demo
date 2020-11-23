# Azure Logic App E2E Tests with SpecFlow

This repo demonstrates using [SpecFlow](https://specflow.org/) to run through testing scenarios and assert the expected behavior of [Azure Logic Apps].

## Setup

- Create an Azure Logic App with the workflow specified in the [`workflow.template.json`](./workflow.template.json) file.
- Create a service principal that can access the Logic App
- Add the following environment variables (found in [`env.template`](./env.template)):

  ```bash
  export AzureClientId="..."
  export AzureClientSecret="..."
  export AzureTenantId="..."
  export SubscriptionId="..."
  export ResourceGroup="..."
  export LogicAppTriggerUrl="https://prod-08.eastus.logic.azure.com:443/workflows/..."
  ```

- Build the solution: run `dotnet build`

## Running the test

- Run `dotnet test`
