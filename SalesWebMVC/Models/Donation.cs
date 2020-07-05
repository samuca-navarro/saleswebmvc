using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMVC.Models
{
    public class Donation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Value { get; set; }

        public Donation()
        {

        }

        public Donation(int id, string name, double value)
        {
            Id = id;
            Name = name;
            Value = value;
        }
    }
}
