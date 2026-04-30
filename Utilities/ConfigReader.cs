using System.IO;
using Newtonsoft.Json.Linq;
namespace AutomationFramework;

[TestClass]
public class ConfigReader
{
    private static JObject configData;
    static ConfigReader()
    {
        string json = File.ReadAllText("Config/config.json");
        configData = JObject.Parse(json);
    }
    public static string GetData(string section, string key)
    {
        return configData["environments"][section][key].ToString();
    }
    public static string GetBrowser()
    {
        return configData["browser"].ToString();
    }
}
