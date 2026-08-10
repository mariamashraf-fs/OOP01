using Assignment_4.Structs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_4.Classes
{
    //Assignment_6
    public class PriorityInternationalShipment : InternationalShipment
    {
        public PriorityInternationalShipment(string tcode, string desc, decimal weight, decimal fee, DeliveryAddress destination, 
            string country, decimal customsFee)
            : base(tcode, desc, weight, fee, destination, country, customsFee) { }

        public sealed override void GenerateCustomsReport()
        {
            base.GenerateCustomsReport();
            Console.WriteLine("Priority Handling: Customs report expedited.");
        }
    }
}
