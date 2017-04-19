using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Beta.Models.Master
{
    public class DoctorModel:CoreModel
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }


        public int Location_ID { get; set; }
        public int BloodGroup_ID { get; set; }
        public int Specialist_Id { get; set; }

        public string TelpHome { get; set; }
        public string TelpWork { get; set; }
        public string Email { get; set; }
        public double Fee { get; set; }
        public int AccountBank_ID { get; set; }
        public int MethodPayment_ID { get; set; }

        public string AccountNumber { get; set; }
        public string AccountName { get; set; }
    }
}
