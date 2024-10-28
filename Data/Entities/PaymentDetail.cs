using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSPproyecto.Data.Entities
{
    internal class PaymentDetail
    {
        public Catalog[] CatalogPayments;
        public int Scolarship { get; set; }
        public float FinalAmount { get; set; }
        public int Category { get; set; }
    }
}
