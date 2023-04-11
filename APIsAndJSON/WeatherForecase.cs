using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace APIsAndJSON
{
    public class WeatherForecase
    {
        public static void ZipWeather()
        {
            Console.WriteLine("Ener your Zipcode");
            var zipCode = Console.ReadLine();
            var client = new HttpClient();
            string key = File.ReadAllText("appsettings.json");
            string apiKey = JObject.Parse(key).GetValue("DefaultKey").ToString();
            string apiCall = $"https://api.openweathermap.org/data/2.5/weather?zip={zipCode}&units=imperial&appid={apiKey}";

        }
    }
}
