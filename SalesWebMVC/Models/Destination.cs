using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMVC.Models
{
    public class Destination
    {
        public int Id { get; set; }
        public string Cause { get; set; }

        public Destination()
        {

        }

        public Destination(int id, string cause)
        {
            Id = id;
            Cause = cause;
        }
    }


}
