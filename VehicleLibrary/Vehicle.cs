using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleLibrary
{
    public class Vehicle
    {
        public int Year { get; set; }
        public string Make { get; set; }
        public string Mode { get; set; }
        public string GetFullName()
        {
            return $"{Year} {Make} {Mode}";
        }
    }
}
