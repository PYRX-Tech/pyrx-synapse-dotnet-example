using PyrxSynapse;
using PyrxSynapse.Models;

public static class TemplatesUpdate
{
    public static async Task RunAsync()
    {
        var client = ExampleHelper.CreateClient();

        var slug = $"tpl-update-{DateTimeOffset.UtcNow.ToUnixTimeSeconds()}";

        // Create first
        client.Templates.Create(new TemplateCreateParams
        {
            Slug = slug,
            Name = "Update Test",
            Subject = "Original subject",
            BodyHtml = "<h1>Hi</h1>",
            SenderName = "Synapse",
            FromEmail = "noreply@example.com"
        });

        var updated = client.Templates.Update(slug, new TemplateUpdateParams
        {
            Subject = "Your order is confirmed!"
        });

        Console.WriteLine($"Updated: {ExampleHelper.ToJson(updated)}");

        // Cleanup
        try { client.Templates.Delete(slug); } catch { }
        await Task.CompletedTask;
    }
}
