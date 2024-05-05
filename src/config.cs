using System;
using Newtonsoft.Json;
using System.IO;

public class AppSettings
{
    public string AppVersion { get; set; }
    public string ApiEndpoint { get; set; }
    public string DateFormat { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        string configFilePath = Path.Combine(".config", "AppSetting.json");

        if (File.Exists(configFilePath))
        {
            string json = File.ReadAllText(configFilePath);
            AppSettings appSettings = JsonConvert.DeserializeObject<AppSettings>(json);

            string dateString = "2024-05-06 11:37:30";
            DateTime dateTime = DateTime.ParseExact(dateString, appSettings.DateFormat, null);
            Console.WriteLine(dateTime.ToString("dddd, dd MMMM yyyy HH:mm:ss")); // Example custom format
        }
        else
        {
            Console.WriteLine("AppSetting.json not found.");
        }
    }
}
