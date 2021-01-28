using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter
{
    class Conversion
    {
        public string Results { get; set; }

        public string Timestamp { get; set; }

        public Conversion(string results, string timestamp)
        {
            this.Results = results;
            this.Timestamp = timestamp;
        }

        public override string ToString()
        {
            return string.Format("{0}, {1}", this.Results, this.Timestamp);
        }

        public string ToDataString()
        {
            return string.Format("{0};{1}", this.Results, this.Timestamp);
        }
    }
}
 