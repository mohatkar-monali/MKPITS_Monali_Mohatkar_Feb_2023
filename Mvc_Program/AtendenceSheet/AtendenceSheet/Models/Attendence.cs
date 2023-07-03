namespace AtendenceSheet.Models
{
    public class Attendence
    {
        public string Name { get; set; }
       public batch batchtype { set; get; }
        public bool status { get; set; }

        public course getcourse { get; set; }
        public DateTime date { get; set; }
        public double percentage { get; set; }
    }
    public enum batch
    {
        Java, DotNet
    }
    public enum course
    {
        Java, DotNet
    }

}
