using System;
using System.Threading.Tasks;

Console.WriteLine("Requesting a report from each lab branch...");

Task<string> cairoTask = FetchFromCairoLabAsync();
Task<string> gizaTask = FetchFromGizaLabAsync();
Task<string> alexandriaTask = FetchFromAlexandriaLabAsync();

Task<string> fastestTask = await Task.WhenAny(cairoTask, gizaTask, alexandriaTask);
string fastestReport = await fastestTask;

Console.WriteLine($"The fastest report is: {fastestReport}");

static async Task<string> FetchFromCairoLabAsync()
{
    await Task.Delay(2000);
    return "Report from Cairo Central";
}

static async Task<string> FetchFromGizaLabAsync()
{
    await Task.Delay(1000);
    return "Report from Giza Lab";
}

static async Task<string> FetchFromAlexandriaLabAsync()
{
    await Task.Delay(3000);
    return "Report from Alexandria Lab";
}
