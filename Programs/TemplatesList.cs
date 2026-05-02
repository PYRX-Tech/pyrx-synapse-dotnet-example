using PyrxSynapse;
using PyrxSynapse.Models;

public static class TemplatesList
{
    public static async Task RunAsync()
    {
        var client = ExampleHelper.CreateClient();

        var templates = client.Templates.List();

        Console.WriteLine($"Templates: {ExampleHelper.ToJson(templates)}");
        await Task.CompletedTask;
    }
}
