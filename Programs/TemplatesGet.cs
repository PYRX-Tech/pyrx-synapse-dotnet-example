using PyrxSynapse;
using PyrxSynapse.Models;

public static class TemplatesGet
{
    public static async Task RunAsync()
    {
        var client = ExampleHelper.CreateClient();

        var slug = $"sdk-get-test-{DateTimeOffset.UtcNow.ToUnixTimeSeconds()}";

        // Create a template first
        client.Templates.Create(new TemplateCreateParams
        {
            Slug = slug,
            Name = "Get Test",
            Subject = "Test",
            BodyHtml = "<p>Hi</p>",
            SenderName = "Test",
            FromEmail = "test@example.com"
        });

        var template = client.Templates.Get(slug);

        Console.WriteLine($"Template: {ExampleHelper.ToJson(template)}");

        // Cleanup
        try { client.Templates.Delete(slug); } catch { }
        await Task.CompletedTask;
    }
}
