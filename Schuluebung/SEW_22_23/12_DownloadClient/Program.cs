using _12__DownloadClient;

List<Uri> urls = new List<Uri>();
urls.Add(new Uri("http://bit.ly/leseprobe_schroedinger_cplusplus"));
urls.Add(new Uri("http://bit.ly/leseprobe_schroedinger_abap"));
urls.Add(new Uri("http://bit.ly/leseprobe_schroedinger_html5"));
urls.Add(new Uri("http://bit.ly/leseprobe_programmieren_lernen"));
urls.Add(new Uri("https://www.thecodingguys.net/resources/cs-cheat-sheet.pdf"));

List<Task<string>> tasks = new List<Task<string>>();
foreach(Uri url in urls)
{
    PdfDownloader downloader = new PdfDownloader();
    Task<string> t = downloader.DownloadAsync(url);
    //string fileName = t.Result; // führt dazu das t.Wait aufgerufen wird, da das Result noch nicht da ist
    tasks.Add(t);
    //t.Wait();
};
Task.WaitAll(tasks.ToArray());  // warten bis alle Tasks fertig sind
tasks.ForEach(task => Console.WriteLine("File can be found: " +task.Result));
Console.WriteLine("Alle Downloads abgeschlossen!");