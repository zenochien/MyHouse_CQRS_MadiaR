using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace HotelMobile
{
    internal class Program
    {
        const string ID_HOST = "http://localhost:55369";
        const string API_HOST = "http://localhost:54664";

        static async Task Main(string[] args)
        {
            Console.WriteLine("Press any key to start");
            Console.ReadLine();
            Console.WriteLine(await CallApi());
        }

        static async Task<string> CallApi()
        {
            using var client = new HttpClient();
            var message = new HttpRequestMessage(HttpMethod.Get, $"{API_HOST}/hotels");

            message.Headers.Authorization = new AuthenticationHeaderValue("Bearer", await Token());

            var response = await client.SendAsync(message);

            if (response.IsSuccessStatusCode)
                return await response.Content.ReadAsStringAsync();

            return "Failed";
        }

        static async Task<string> Token()
        {
            using var client = new HttpClient();

            var message = new HttpRequestMessage(HttpMethod.Post, $"{ID_HOST}/connect/token");

            message.Content = new FormUrlEncodedContent(new Dictionary<string, string>()
            {
                {"client_id", "f4bca9c0-7984-494e-9b89-126333be48b3"},
                {"client_secret", "4bb712a4-243f-4ceb-80fe-9fcdf56aa0ba"},
                {"grant_type", "client_credentials"},
                {"scope", "hotel.read"}
            });

            var response = await client.SendAsync(message);

            var body = await response.Content.ReadAsStringAsync();

            return JObject.Parse(body).Value<string>("access_token");
        }
    }
}