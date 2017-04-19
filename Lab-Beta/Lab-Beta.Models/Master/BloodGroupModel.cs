using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Beta.Models
{
    public class BloodGroupModel:CoreModel
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Rhesus { get; set; }
    }
}
