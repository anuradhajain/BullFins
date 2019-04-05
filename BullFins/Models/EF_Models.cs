using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BullFins.Models
{
    public class EF_Models
    {
        public class Company
        {
            [Key]
            public string symbol { get; set; }
            public string name { get; set; }
            public string date { get; set; }
            public bool isEnabled { get; set; }
            public string type { get; set; }
            public string iexId { get; set; }
        }

        public class StockStats
        {
            [Key]
            public string symbol { get; set; }
            public decimal dividendRate { get; set; }
            public decimal revenue { get; set; }
            public decimal grossProfit { get; set; }
            public decimal cash { get; set; }
            public decimal debt { get; set; }
            public decimal revenuePerShare { get; set; }

        }
        
        public class Chart
        {
            [Key]
            public string symbol { get; set; }
            public string date { get; set; }
            public decimal volume { get; set; }
            public decimal open { get; set; }
            public decimal high { get; set; }
            public decimal low { get; set; }
            public decimal close { get; set; }
            public decimal change { get; set; }

        }
        
        public class ErrorViewModel
        {
            public string RequestId { get; set; }
            public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
        }
    }
}
