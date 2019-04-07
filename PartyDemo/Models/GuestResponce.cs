using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartyDemo.Models
{
    public class GuestResponce
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public bool? WillAttend { get; set; }
    }
}
