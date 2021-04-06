using System;
using System.Threading;
using CryptoCounter.Models;
using Newtonsoft.Json;
using RestSharp;

namespace CryptoCounter
{
    public class Program
    {
        static bool exitLoop = false;
        static int secondsToSleep = 10;

        static void Main(string[] args)
        {
            if(args.Length == 0) { Console.WriteLine("Usage: crypc <account_num>"); }

            var client = new RestClient("https://eth.2miners.com/");
            var request = new RestRequest($"api/accounts/{args[0]}", DataFormat.Json);

            while (!exitLoop)
            {
                var response = client.Get(request);
                var jsonResult = JsonConvert.DeserializeObject<AccountReturnModel>(response.Content);

                Console.Clear();
                Console.Title = "Crypto Counter - ETH (2miners)";
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{DateTime.Now}");
                Console.WriteLine($"Current Balance: {(double)jsonResult.stats.balance/1000000000}");

                if (Console.KeyAvailable)
                {
                    switch (Console.ReadKey().Key)
                    {
                        default:
                            continue;
                        case ConsoleKey.Q:
                        case ConsoleKey.Escape:
                            exitLoop = true;
                            break;
                    }
                }

                Thread.Sleep(secondsToSleep*1000);
            }
        }
    }
}
