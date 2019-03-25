using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Accounting.Models
{
    public class Organization
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public bool Active { get; set; }
        public string Comment { get; set; }
    }
}
