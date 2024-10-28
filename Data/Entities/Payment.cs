using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSPproyecto.Data.Entities
{
    internal class Payment
    {
        public PaymentDetail[] Detail;
        public int id { get; set; }
        public DateTime? PaymentDate { get; set; }
        public float TotalAmount { get; set; }
    }
}
