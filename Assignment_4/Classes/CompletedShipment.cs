using Assignment_4.Structs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_4.Classes
{
    //Assignment_6
    public sealed class CompletedShipment : Shipment
    {
        public CompletedShipment(string tcode,string desc,decimal weight,decimal fee,DeliveryAddress destination)
            : base(tcode, desc, weight, fee, destination) { }

      
    }
}
