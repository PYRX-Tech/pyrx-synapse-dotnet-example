using PyrxSynapse;
using PyrxSynapse.Models;

public static class TemplatesDelete
{
    public static async Task RunAsync()
    {
        var client = ExampleHelper.CreateClient();

        var slug = $"sdk-del-test-{DateTimeOffset.UtcNow.ToUnixTimeSeconds()}";

        // Create then delete
        client.Templates.Create(new TemplateCreateParams
        {
            Slug = slug,
            Name = "Del Test",
            Subject = "Test",
            BodyHtml = "<p>Hi</p>",
            SenderName = "Test",
            FromEmail = "test@example.com"
        });

        client.Templates.Delete(slug);

        Console.WriteLine("Template deleted");
        await Task.CompletedTask;
    }
}
