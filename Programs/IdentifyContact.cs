using PyrxSynapse;
using PyrxSynapse.Models;

public static class IdentifyContact
{
    public static async Task RunAsync()
    {
        var client = ExampleHelper.CreateClient();

        var resp = client.Identify(new IdentifyParams
        {
            ExternalId = "user_123",
            Email = "jane@example.com",
            Properties = new Dictionary<string, object> { ["plan"] = "pro", ["signup_source"] = "website" }
        });

        Console.WriteLine($"Contact identified: {ExampleHelper.ToJson(resp)}");
        await Task.CompletedTask;
    }
}
