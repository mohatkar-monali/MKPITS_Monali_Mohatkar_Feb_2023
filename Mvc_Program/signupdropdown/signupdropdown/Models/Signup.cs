namespace signupdropdown.Models
{
    public class Signup
    {
        public string username { get; set; }
        public string gender { get; set; }
        public bool sub1 { get; set; }
        public bool sub2 { get; set; }

        public city getcity { get; set; }
    }
    public enum city
    {
        Nagpur,Mumbai,Hydrabad
    }

}
