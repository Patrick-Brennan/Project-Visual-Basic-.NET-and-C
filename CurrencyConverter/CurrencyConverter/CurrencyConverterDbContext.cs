using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter
{
    class CurrencyConverterDbContext : DbContext
    {
        const string DbName = "[Insert Database Name]";
        static string DbPath = Path.Combine(Environment.CurrentDirectory, DbName);
        public CurrencyConverterDbContext() : base($@"Data Source=[Insert Database Source]")
        { }
        public virtual DbSet<Conversion> Conversion { get; set; }
    }
}
 