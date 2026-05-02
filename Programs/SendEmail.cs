using PyrxSynapse;
using PyrxSynapse.Models;
using PyrxSynapse.Errors;

public static class SendEmail
{
    public static async Task RunAsync()
    {
        var client = ExampleHelper.CreateClient();

        try
        {
            var resp = client.Send(new SendParams
            {
                TemplateSlug = "welcome-email",
                To = new Dictionary<string, object> { ["user_id"] = "user_123", ["email"] = "jane@example.com" },
                Attributes = new Dictionary<string, object> { ["first_name"] = "Jane" }
            });

            Console.WriteLine($"Email sent: {ExampleHelper.ToJson(resp)}");
        }
        catch (SynapseException ex)
        {
            Console.WriteLine($"Send failed (expected if template doesn't exist): Status={ex.Status}, Message={ex.Message}");
        }

        await Task.CompletedTask;
    }
}
