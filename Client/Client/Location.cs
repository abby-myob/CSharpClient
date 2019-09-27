namespace Client
{
    public class Location
    {
        public string Name { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }

        public Location(string name, string latitude, string longitude)
        {
            Name = name;
            Latitude = latitude;
            Longitude = longitude;
        }
    }
}