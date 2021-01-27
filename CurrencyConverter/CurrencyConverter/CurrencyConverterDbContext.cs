using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CurrencyConverter.Domain;

namespace CurrencyConverter
{
    class CurrencyConverterDbContext : DbContext
    {
        public virtual DbSet<Conversion> Conversion { get; set; }
    }
}
 