using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIsAndJSON
{
    public class QuoteGen
    {
        public static void KanyeQuote()
        {
            var client = new HttpClient();

            var kanyeURL = "https://api.kanye.rest/";

            var kanyeResponse = client.GetStringAsync(kanyeURL).Result;

            var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();

            Console.WriteLine($"");
            Console.WriteLine($"Kanye: {kanyeQuote}'");
        }

        public static void RonSwansonQuote()
        {
            var client = new HttpClient();

            var ronSwanURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";

            var ronSwanResponse = client.GetStringAsync(ronSwanURL).Result;

            var ronSwanQuote = JArray.Parse(ronSwanResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim();

            Console.WriteLine($"");
            Console.WriteLine($"Ron: {ronSwanQuote}");
        }
    }
}
