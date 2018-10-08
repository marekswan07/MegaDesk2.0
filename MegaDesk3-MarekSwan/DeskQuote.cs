using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk3_MarekSwan
{
    class DeskQuote
    {
        public bool RushOrder { get; set; }
        public int RushValue { get; set; }
        public string CustName { get; set; }
        public DateTime QuoteDate { get; set; }
        public float QuotePrice { get; set; }
    }
}
