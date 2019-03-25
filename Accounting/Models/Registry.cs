using System;

namespace Accounting.Models
{
    public class Registry
    {
        public long Id { get; set; }
        public long Organization { get; set; }
        public long OrganizationContainer { get; set; }
        public DateTime Date { get; set; }
        public long Driver { get; set; }
        public long Car { get; set; }
    }
}
