Console.WriteLine("requsting a report from each lab branch...");

task<String> cairoTask = FetchFromCairoLabAsync();
task<String> gizaTask = FetchFromGizaLabAsync();
task <String> alexandriaTask = FetchFromAlexandriaLabAsync();
task <String> fastestTask = Task.WhenAny(cairoTask, gizaTask, alexandriaTask);
string fastestReport = await fastestTask;
Console.WriteLine($"The fastest report is: {fastestReport}");


async Task<string>  FetchFromCairoLabAsync()
await task delay(2000);
return ("Report from Cairo Central");
async Task<string> FetchFromGizaLabAsync()
await task delay(1000);
return("Report from Giza Lab");
async Task<string> FetchFromAlexandriaLabAsync()
await task delay(3000);
return("Report from Alexandria Lab");
