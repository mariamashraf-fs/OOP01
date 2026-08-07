using Assignment_4.Structs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_4.Classes
{
    public class StandardShipment : Shipment
    {
        public StandardShipment (string tcode, string desc, decimal weight, decimal fee, DeliveryAddress destination)
            : base(tcode, desc, weight, fee, destination)
        {

        }
    }

}
