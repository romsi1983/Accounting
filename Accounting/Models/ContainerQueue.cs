using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;

namespace Accounting.Models
{
    public class ContainerQueue
    {
        public long Id { get; set; }
        public long Container { get; set; }
        public long Dayspast { get; set; }
        public bool Processed { get; set; }
    }
}
