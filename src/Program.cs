using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;

public class Data
{
    public string city { get; set; }
    public string region { get; set; }
    public string country { get; set; }
    public string loc { get; set; }
    public string postal { get; set; }
    public string org { get; set; }
}

class Program
{
    static async Task Main(string[] args)
    {
        Console.Title = "Devexv IP Locator";

        bool continueExecution = true;

        while (continueExecution)
        {
            Console.WriteLine("Enter The Target IP Address:");
            string ip = Console.ReadLine();
            string url = $"https://ipinfo.io/{ip}/json";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(url);
                    response.EnsureSuccessStatusCode();

                    Console.WriteLine("[+] Request Successfully Made");

                    string responseData = await response.Content.ReadAsStringAsync();
                    Data ipInfo = JsonConvert.DeserializeObject<Data>(responseData);

                    Console.Clear();
                    Console.WriteLine($"City: {ipInfo.city}");
                    Console.WriteLine($"Region: {ipInfo.region}");
                    Console.WriteLine($"Country: {ipInfo.country}");
                    Console.WriteLine($"Coordinates: {ipInfo.loc}");
                    Console.WriteLine($"Postal Code: {ipInfo.postal}");
                    Console.WriteLine($"ASN: {ipInfo.org}");
                    string[] coords = ipInfo.loc.Split(',');
                    Console.WriteLine($"Google Maps Point : https://www.google.com/maps/?q={coords[0]}, {coords[1]}");
                }
                catch (HttpRequestException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }

            Console.WriteLine("Press 'C' to continue or any other key to exit...");
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            if (keyInfo.KeyChar != 'c' && keyInfo.KeyChar != 'C')
                continueExecution = false;

            Console.Clear();
        }
    }
}
