using PyrxSynapse;
using PyrxSynapse.Models;
using PyrxSynapse.Errors;

var command = args.Length > 0 ? args[0] : "help";

switch (command)
{
    case "track_event":
        await TrackEvent.RunAsync();
        break;
    case "track_batch":
        await TrackBatch.RunAsync();
        break;
    case "identify_contact":
        await IdentifyContact.RunAsync();
        break;
    case "identify_batch":
        await IdentifyBatch.RunAsync();
        break;
    case "send_email":
        await SendEmail.RunAsync();
        break;
    case "contacts_list":
        await ContactsList.RunAsync();
        break;
    case "contacts_get":
        await ContactsGet.RunAsync();
        break;
    case "contacts_update":
        await ContactsUpdate.RunAsync();
        break;
    case "contacts_delete":
        await ContactsDelete.RunAsync();
        break;
    case "templates_list":
        await TemplatesList.RunAsync();
        break;
    case "templates_get":
        await TemplatesGet.RunAsync();
        break;
    case "templates_create":
        await TemplatesCreate.RunAsync();
        break;
    case "templates_update":
        await TemplatesUpdate.RunAsync();
        break;
    case "templates_preview":
        await TemplatesPreview.RunAsync();
        break;
    case "templates_delete":
        await TemplatesDelete.RunAsync();
        break;
    default:
        Console.WriteLine("Usage: dotnet run -- <command>");
        Console.WriteLine();
        Console.WriteLine("Commands:");
        Console.WriteLine("  track_event        Track a single event");
        Console.WriteLine("  track_batch        Track batch events");
        Console.WriteLine("  identify_contact   Identify a contact");
        Console.WriteLine("  identify_batch     Batch identify contacts");
        Console.WriteLine("  send_email         Send transactional email");
        Console.WriteLine("  contacts_list      List contacts");
        Console.WriteLine("  contacts_get       Get a contact by ID");
        Console.WriteLine("  contacts_update    Update a contact");
        Console.WriteLine("  contacts_delete    Delete a contact");
        Console.WriteLine("  templates_list     List templates");
        Console.WriteLine("  templates_get      Get a template");
        Console.WriteLine("  templates_create   Create a template");
        Console.WriteLine("  templates_update   Update a template");
        Console.WriteLine("  templates_preview  Preview a template");
        Console.WriteLine("  templates_delete   Delete a template");
        break;
}
