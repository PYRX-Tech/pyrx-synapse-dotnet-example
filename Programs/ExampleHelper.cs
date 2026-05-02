using System.Text.Json;
using PyrxSynapse;

public static class ExampleHelper
{
    private static readonly JsonSerializerOptions PrintOptions = new()
    {
        WriteIndented = false
    };

    public static SynapseClient CreateClient()
    {
        return new SynapseClient(new SynapseConfig
        {
            ApiKey = Environment.GetEnvironmentVariable("SYNAPSE_API_KEY") ?? "",
            WorkspaceId = Environment.GetEnvironmentVariable("SYNAPSE_WORKSPACE_ID") ?? "",
            BaseUrl = Environment.GetEnvironmentVariable("SYNAPSE_API_URL") ?? "https://synapse-api.pyrx.tech"
        });
    }

    public static string ToJson(object obj)
    {
        return JsonSerializer.Serialize(obj, PrintOptions);
    }
}
