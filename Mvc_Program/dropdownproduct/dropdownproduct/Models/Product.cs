namespace dropdownproduct.Models
{
    public class Product
    {
        public int orderno { get; set; }
        public string custname { get; set; }
        public int price { get; set; }
        public int quantity { get; set; }  
        public product producttype { get; set; }
        public int totalprice { get; set; }
    }
    public enum product
    {
        mouse,keyboard,ram,monitor
    }
}
