using System;
using System.Windows.Forms;

namespace Accounting.Models
{
    public class Contract
    {
        public long Id { get; set; }
        public string ContractNumber { get; set; }
        public long Organization { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public float TargetVolume { get; set; }
        public float ProcessedVolume { get; set; }
    }
}


