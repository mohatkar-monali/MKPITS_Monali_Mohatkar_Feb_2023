namespace accountdropdownlistfor.Models
{
    public class Account
    {
        public int accountno { get; set; }
        public int amount { get; set; }
      
        public transtype GetTranstype { get; set; }
    }
    public enum transtype
    { deposite, withdraw }
}
