using PyrxSynapse;
using PyrxSynapse.Models;

public static class TrackEvent
{
    public static async Task RunAsync()
    {
        var client = ExampleHelper.CreateClient();

        var resp = await client.TrackAsync(new TrackParams
        {
            ExternalId = "user_123",
            EventName = "user_signed_up",
            Attributes = new Dictionary<string, object> { ["plan"] = "starter", ["source"] = "landing_page" }
        });

        Console.WriteLine($"Event tracked: {ExampleHelper.ToJson(resp)}");
    }
}
