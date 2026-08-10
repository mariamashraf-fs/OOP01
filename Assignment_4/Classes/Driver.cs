using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_4.Classes
{
    //Assignment_6
    public class Driver
    {
        private string name ="";

        public string Name
        {
            get { return name; }
            set {  if (!string.IsNullOrWhiteSpace(value))
                    name = value;
            }
        }

        public Driver(string name)
        {
            Name = name;
        }
    }
}
