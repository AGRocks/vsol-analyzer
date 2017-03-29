using Newtonsoft.Json;
using OpenScraping;
using OpenScraping.Config;
using System;
using System.IO;
using System.Net;
using System.Text;

namespace vsol_analyzer.scrapper
{
    class Program
    {
        static void Main(string[] args)
        {
            var jsonConfig = File.ReadAllText(@"match-result.config.json");
            var config = StructuredDataConfig.ParseJsonString(jsonConfig);

            var html = string.Empty;
            using (WebClient client = new WebClient())
            {
                client.Encoding = Encoding.UTF8;
                html = client.DownloadString("http://virtualsoccer.ru/viewmatch.php?day=12968&match_id=213340");
            }

            var openScraping = new StructuredDataExtractor(config);
            var scrapingResults = openScraping.Extract(html);

            Console.WriteLine(JsonConvert.SerializeObject(scrapingResults, Formatting.Indented));
            Console.ReadKey();
        }
    }
}
