using PyrxSynapse;
using PyrxSynapse.Models;

public static class ContactsGet
{
    public static async Task RunAsync()
    {
        var client = ExampleHelper.CreateClient();

        // List contacts first to get an ID
        var list = client.Contacts.List(new ContactListParams { Page = 1, PerPage = 1 });

        if (list.Data == null || list.Data.Count == 0)
        {
            Console.WriteLine("No contacts found");
            return;
        }

        var contactId = list.Data[0].Id;
        var contact = client.Contacts.Get(contactId);

        Console.WriteLine($"Contact: {ExampleHelper.ToJson(contact)}");
        await Task.CompletedTask;
    }
}
