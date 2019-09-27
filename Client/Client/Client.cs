using System;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading;
using Newtonsoft.Json;

namespace Client
{
    public class ClientOperator
    {
        private HttpClient MyClient { get; set; }

        public ClientOperator()
        {
            MyClient = new HttpClient();
        }

        public void Get(string url)
        {
            var response = MyClient.GetAsync(url);


            var result = response.Result;
            var content = result.Content;

            var str = content.ReadAsStringAsync();
            var resultString = str.Result;
            Console.WriteLine(resultString);
        }

        public void Post(string url, Location location)
        {
            var locationJson = JsonConvert.SerializeObject(location); 
            
            var response = MyClient.PostAsync(url, new StringContent(locationJson, Encoding.UTF8, "application/json"));
 
            Console.WriteLine(response.Result); 
        }
    }
}