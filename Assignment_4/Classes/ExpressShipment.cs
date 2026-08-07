using Assignment_4.Structs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_4.Classes
{
    public class ExpressShipment : Shipment
    {
        private decimal extraFee;

        public decimal ExtraFee
        {
            get { return extraFee; }
            set { extraFee = (value >= 0) ? value : extraFee; }
        }
    
   
        public override decimal EstimatedCost
        {
            get { return base.EstimatedCost + ExtraFee; }
        }


        public ExpressShipment(string tcode, string desc, decimal weight, decimal fee, DeliveryAddress destination, decimal extraFee)
            : base(tcode, desc, weight, fee, destination)
        {
            ExtraFee = extraFee;
        }
    }
}
