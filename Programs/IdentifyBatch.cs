using PyrxSynapse;
using PyrxSynapse.Models;

public static class IdentifyBatch
{
    public static async Task RunAsync()
    {
        var client = ExampleHelper.CreateClient();

        var resp = client.IdentifyBatch(new IdentifyBatchParams
        {
            Contacts = new List<IdentifyParams>
            {
                new() { ExternalId = "user_1", Email = "alice@example.com", Properties = new Dictionary<string, object> { ["plan"] = "starter" } },
                new() { ExternalId = "user_2", Email = "bob@example.com", Properties = new Dictionary<string, object> { ["plan"] = "growth" } }
            }
        });

        Console.WriteLine($"Batch identified: {ExampleHelper.ToJson(resp)}");
        await Task.CompletedTask;
    }
}
