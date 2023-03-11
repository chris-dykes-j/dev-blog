using HtmlAgilityPack;

var httpClientHandler = new HttpClientHandler();
httpClientHandler.ServerCertificateCustomValidationCallback = (_, _, _, _) => true;
var client = new HttpClient(httpClientHandler);

const string homeUri = "https://localhost:7081/";
const string directory = "/run/media/chris/Extra/dev-blog/";
GetHtmlPage(homeUri);
GetHtmlPage(homeUri + "about");

void GetHtmlPage(string requestUri)
{
    using var request = new HttpRequestMessage(HttpMethod.Get, requestUri);
    var result = client.Send(request).Content.ReadAsStringAsync().Result;
    var homePage = new HtmlDocument();
    homePage.LoadHtml(result);

    var fileName = requestUri.Equals(homeUri)
        ? "index" 
        : requestUri.Replace(homeUri, "");

    using var fileStream = new FileStream($"{directory}{fileName}.html", FileMode.Create);
    homePage.Save(fileStream);
    Console.WriteLine(requestUri);
    
    if (!fileName.Equals("index")) return;
    foreach (var link in homePage.DocumentNode.SelectNodes("//a[@class='blog-link']"))
    {
        GetHtmlPage($"https://localhost:7081{link.Attributes["href"].Value}");
    }
}

Console.WriteLine("Complete");