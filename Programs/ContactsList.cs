using PyrxSynapse;
using PyrxSynapse.Models;

public static class ContactsList
{
    public static async Task RunAsync()
    {
        var client = ExampleHelper.CreateClient();

        var resp = client.Contacts.List(new ContactListParams { Page = 1, PerPage = 10 });

        Console.WriteLine($"Contacts: {ExampleHelper.ToJson(resp)}");
        await Task.CompletedTask;
    }
}
