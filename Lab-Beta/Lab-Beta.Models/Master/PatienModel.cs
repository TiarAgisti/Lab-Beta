using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Beta.Models.Master
{
    public class PatienModel:CoreModel
    {
        public string CodePatien { get; set; }
        public string Name { get; set; }
        public char Gender { get; set; }
        public string PlaceOfBirth { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public string TelpHome { get; set; }
        public string TelpWork { get; set; }
        public string Email { get; set; }
        public string Notes { get; set; }

        public int BloodGroupId { get; set; }
        public int EducationId { get; set; }
        public int JobOId { get; set; }
        public int LocationId { get; set; }
        public BadImageFormatException Picture { get; set; }

    }
}
