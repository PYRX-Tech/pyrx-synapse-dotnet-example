using PyrxSynapse;
using PyrxSynapse.Models;

public static class TrackBatch
{
    public static async Task RunAsync()
    {
        var client = ExampleHelper.CreateClient();

        var resp = client.TrackBatch(new TrackBatchParams
        {
            Events = new List<TrackParams>
            {
                new() { ExternalId = "user_1", EventName = "page_viewed", Attributes = new Dictionary<string, object> { ["page"] = "/pricing" } },
                new() { ExternalId = "user_2", EventName = "feature_used", Attributes = new Dictionary<string, object> { ["feature"] = "export" } }
            }
        });

        Console.WriteLine($"Batch tracked: {ExampleHelper.ToJson(resp)}");
        await Task.CompletedTask;
    }
}
