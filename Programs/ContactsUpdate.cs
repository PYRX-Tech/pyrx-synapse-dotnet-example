using PyrxSynapse;
using PyrxSynapse.Models;

public static class ContactsUpdate
{
    public static async Task RunAsync()
    {
        var client = ExampleHelper.CreateClient();

        // Identify first to ensure contact exists
        client.Identify(new IdentifyParams
        {
            ExternalId = "sdk_update_test",
            Email = "update@example.com"
        });

        var updated = client.Contacts.Update("sdk_update_test", new ContactUpdateParams
        {
            Properties = new Dictionary<string, object> { ["plan"] = "growth" }
        });

        Console.WriteLine($"Updated: {ExampleHelper.ToJson(updated)}");
        await Task.CompletedTask;
    }
}
