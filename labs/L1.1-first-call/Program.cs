using Azure.AI.Projects;
using Azure.Identity;
using OpenAI.Responses;

#pragma warning disable OPENAI001

// No API key anywhere. DefaultAzureCredential uses your `az login` locally
// and a Managed Identity when the app runs in Azure.
var endpoint = Environment.GetEnvironmentVariable("FOUNDRY_PROJECT_ENDPOINT")
    ?? throw new InvalidOperationException("Set FOUNDRY_PROJECT_ENDPOINT first.");
var deployment = Environment.GetEnvironmentVariable("FOUNDRY_CHAT_DEPLOYMENT") ?? "chat-dev";

var project = new AIProjectClient(new Uri(endpoint), new DefaultAzureCredential());
var client = project.ProjectOpenAIClient.GetProjectResponsesClientForModel(deployment);

ResponseResult response = await client.CreateResponseAsync("In one short sentence, what is an embedding?");
Console.WriteLine(response.GetOutputText());
