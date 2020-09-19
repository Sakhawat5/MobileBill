using System;
using System.Collections.Generic;
using System.Text;

namespace mobilebill
{
    public class MobileBill
    {
        public string Name { get; set; }
        public double Rate { get; set; }
        public double PulseRate { get; set; }
        public int PulseDuration { get; set; }
        public DateTime SessionStart { get; set; }
        public DateTime SessionEnd { get; set; }
    }
}
