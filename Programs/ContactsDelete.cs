using PyrxSynapse;
using PyrxSynapse.Models;

public static class ContactsDelete
{
    public static async Task RunAsync()
    {
        var client = ExampleHelper.CreateClient();

        var extId = $"del_test_{DateTimeOffset.UtcNow.ToUnixTimeSeconds()}";

        // Create contact first
        client.Identify(new IdentifyParams
        {
            ExternalId = extId,
            Email = $"{extId}@test.com"
        });

        client.Contacts.Delete(extId);

        Console.WriteLine("Contact deleted");
        await Task.CompletedTask;
    }
}
