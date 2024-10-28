using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSPproyecto.Data.Entities
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Grade { get; set; }         
        public string Adress { get; set; }
        public int Phone { get; set; }
        public string Section { get; set; }
        public string ExternalKey { get; set; }
        public int Scolarship {  get; set; }
        public int PaymentPlan { get; set; }
        public Image Image { get; set; }
        public string PathToCertificate { get; set; }
    }
}
