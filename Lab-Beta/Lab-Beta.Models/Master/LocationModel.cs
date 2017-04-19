using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Beta.Models.Master
{
    public class LocationModel
    {
        public int Id { get; set; }
        public string CodeLocation { get; set; }
        public string Name { get; set; }
        public string Province { get; set; }
        public Int16 City { get; set; }
        public Int16 District { get; set; }
        public Int16 Locality { get; set; }
    }
}
