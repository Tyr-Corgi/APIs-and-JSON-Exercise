using Newtonsoft.Json.Linq;


namespace APIsAndJSON
{
    public class Program
    {
        static void Main(string[] args)
        {

            #region --Excercise 1
            //int i = 0;
            //while (i < 5)
            //{
            //    QuoteGen.KanyeQuote();
            //    Thread.Sleep(1000);
            //    QuoteGen.RonSwansonQuote();
            //    Console.WriteLine("Press any key to continue");
            //    Console.ReadLine();
            //    i++;
            //}

            //QuoteGen.KanyeQuote();
            //QuoteGen.RonSwansonQuote();
            //Console.ReadLine();
            #endregion

            #region-- Exercise 2
            string key = File.ReadAllText("appsettings.json");
            string APIkey = JObject.Parse(key).GetValue("DefaultKey").ToString();

            Console.WriteLine("Please enter your zipcode");
            var zipCode = Console.ReadLine();

            string apiCall = $"http://api.openweathermap.org/data/2.5/weather?zip={zipCode}&appid={APIkey}&units=imperial";

            Console.WriteLine();
            Console.WriteLine($"It is currently {WeatherMap.GetTemp(apiCall)} degrees F");
            #endregion

        }
    }
}
