using Azure.AI.OpenAI;
using Azure;


OpenAIClient client = new OpenAIClient(
        new Uri("https://emailgeneratordemo.openai.azure.com/"),
        new AzureKeyCredential("4461d4ebc79a45bca18557145962a4f3"));

string deploymentName = "EmailGeneratorDemo01";
string prompt = "Draft an email requesting fund for stray dogs.";
Console.Write($"Input: {prompt}");

Response<Completions> completionsResponse = client.GetCompletions(deploymentName, prompt);
string completion = completionsResponse.Value.Choices[0].Text;

Console.WriteLine(completion);

Console.ReadLine();