using System;
using System.IO;
using Newtonsoft.Json;

public class LoggingSettings
{
    public string Application { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        string configFilePath = Path.Combine(".config", "logging.json");

        if (File.Exists(configFilePath))
        {
            string json = File.ReadAllText(configFilePath);
            LoggingSettings loggingSettings = JsonConvert.DeserializeObject<LoggingSettings>(json);

            string applicationName = AppDomain.CurrentDomain.FriendlyName;
            loggingSettings.Application = "IP locator.exe";

            string updatedJson = JsonConvert.SerializeObject(loggingSettings, Formatting.Indented);
            File.WriteAllText(configFilePath, updatedJson);
        }
        else
        {
            Console.WriteLine("logging.json not found.");
        }
    }
}
