using System;

namespace Accounting.Models
{
    public class Registry
    {
        public long Id { get; set; }
        public long Organization { get; set; }
        public long Contract { get; set; }
        public long Container { get; set; }
        public long Platform { get; set; }
        public long Driver { get; set; }
        public long Car { get; set; }
        public DateTime Entered { get; set; }
    }
}
