using PyrxSynapse;
using PyrxSynapse.Models;

public static class TemplatesPreview
{
    public static async Task RunAsync()
    {
        var client = ExampleHelper.CreateClient();

        var slug = $"sdk-preview-test-{DateTimeOffset.UtcNow.ToUnixTimeSeconds()}";

        // Create a template to preview
        client.Templates.Create(new TemplateCreateParams
        {
            Slug = slug,
            Name = "Preview Test",
            Subject = "Hi {{first_name}}",
            BodyHtml = "<p>Hello {{first_name}}</p>",
            SenderName = "Test",
            FromEmail = "test@example.com"
        });

        var preview = client.Templates.Preview(slug, new TemplatePreviewParams
        {
            Contact = new Dictionary<string, object> { ["email"] = "jane@example.com", ["first_name"] = "Jane" }
        });

        Console.WriteLine($"Preview: {ExampleHelper.ToJson(preview)}");

        // Cleanup
        try { client.Templates.Delete(slug); } catch { }
        await Task.CompletedTask;
    }
}
