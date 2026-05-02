using PyrxSynapse;
using PyrxSynapse.Models;

public static class TemplatesCreate
{
    public static async Task RunAsync()
    {
        var client = ExampleHelper.CreateClient();

        var slug = $"tpl-create-{DateTimeOffset.UtcNow.ToUnixTimeSeconds()}";

        var template = client.Templates.Create(new TemplateCreateParams
        {
            Slug = slug,
            Name = "Create Test",
            Subject = "Order confirmed",
            BodyHtml = "<h1>Hi</h1><p>Your order is confirmed.</p>",
            SenderName = "Synapse",
            FromEmail = "noreply@example.com"
        });

        Console.WriteLine($"Created: {ExampleHelper.ToJson(template)}");

        // Cleanup
        try { client.Templates.Delete(slug); } catch { }
        await Task.CompletedTask;
    }
}
