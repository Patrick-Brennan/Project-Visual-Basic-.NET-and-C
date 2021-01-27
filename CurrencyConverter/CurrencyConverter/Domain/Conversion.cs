using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter.Domain
{
    class Conversion
    {
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string lbResult { get; set; }

        [Required]
        [StringLength(200)]
        public string lbDate { get; set; }
    }
}
 