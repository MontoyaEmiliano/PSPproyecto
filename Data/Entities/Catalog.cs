using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSPproyecto.Data.Entities
{
    internal class Catalog
    {
        public int Id {  get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public float Amount { get; set; }
    }
}
