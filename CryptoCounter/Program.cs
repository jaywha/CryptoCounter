using System;
using System.Threading;
using CryptoCounter.Models;
using Newtonsoft.Json;
using RestSharp;

namespace CryptoCounter
{
    public class Program
    {
        public static bool exitLoop = false;

        static void Main(string[] args)
        {
            if(args.Length == 0) { Console.WriteLine("Usage: crypc <account_num>"); }

            var client = new RestClient("https://eth.2miners.com/");
            var request = new RestRequest($"api/accounts/{args[0]}", DataFormat.Json);
            var response = client.Get(request);

            var jsonResult = JsonConvert.DeserializeObject<AccountReturnModel>(response.Content);

            while (!exitLoop)
            {
                Console.Clear();
                Console.WriteLine($"{DateTime.Now}");
                Console.WriteLine($"Current Balance: 0.0{jsonResult.stats.balance}");

                var key = Console.ReadKey();
                switch (key.Key)
                {
                    default:
                        continue;
                    case ConsoleKey.Q:
                    case ConsoleKey.Escape:
                        exitLoop = true;
                        break;
                }
            }
        }
    }
}
