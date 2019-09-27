using System;
using System.Text;

namespace Client
{
    public class Io
    {
        private ClientOperator Client { get; }

        public Io(ClientOperator client)
        {
            Client = client;
        }

        public void Start()
        {
            var isLookUp = false;
            var address = "";
            var lat = "";
            var lng = "";
            var urlbuilder = new StringBuilder();
            
            while (true)
            {
                urlbuilder.Append("Http://localhost:8080/geocode/json");
                Console.WriteLine("Look up or Update? (l/u)");
                isLookUp = Console.ReadLine() != "u";

                Console.WriteLine("Address:");
                address = Console.ReadLine();

                if (isLookUp)
                {
                    urlbuilder.Append($"?address={address}");
                    Client.Get(urlbuilder.ToString());
                }
                else
                {
                    Console.WriteLine("Lat:");
                    lat = Console.ReadLine();
                    Console.WriteLine("Lng:");
                    lng = Console.ReadLine();
                
                    var location = new Location(address, lat, lng);
                
                    Client.Post(urlbuilder.ToString(), location);
                }
            }
        }
    }
}