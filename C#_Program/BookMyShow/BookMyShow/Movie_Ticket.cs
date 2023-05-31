using System;
using System.Collections.Generic;
using System.Deployment.Application;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookMyShow
{
    
    abstract internal class Movie_Ticket
    {
        public string Movie_Name { get; set; }
        public string Theatre_Name { get; set; }
        public int Show_Time { get; set; }
        public int No_Of_Seat { get; set; }
        public int Ticket_Price { get; set; }
      
        //creating abstract method Calculate_Ticket_Price
        public abstract string Calculate_Ticket_Price();
       

    }
    //derived class Online_Booking
    class Online_Booking : Movie_Ticket

    {
        public Online_Booking(int No_Of_Seat, int Ticket_Price)
        {
            
            this.No_Of_Seat = No_Of_Seat;
            this.Ticket_Price = Ticket_Price;
        }
        public float Discount { get;set; }
       
        public override string Calculate_Ticket_Price()
        {
            float tp = No_Of_Seat * Ticket_Price;
            Discount = tp * 0.10f;
                tp=tp-Discount;
            return "Total Price:"+tp.ToString();
        }
    }
    class Box_Office : Movie_Ticket
    {
        public Box_Office(int No_Of_Seat, int Ticket_Price)
        {
            
            this.No_Of_Seat = No_Of_Seat;
            this.Ticket_Price = Ticket_Price;
        }
        public float Booking_Amount { get; set; }
        
        public override string Calculate_Ticket_Price()
        {
            float tp = No_Of_Seat * Ticket_Price ;
            Booking_Amount = 20;
            tp = tp + Booking_Amount;
            return "Ticket Price:" + tp.ToString();
        }

    }
}
