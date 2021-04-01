using Newtonsoft.Json;
using System;

namespace BridgeMonitor.Models
{
    public class Temps
    {
        public string boat_name { get; set; }
        public string closing_type { get; set; }
        public DateTime closing_date { get; set; }
        public DateTime reopening_date { get; set; }
    }
}
