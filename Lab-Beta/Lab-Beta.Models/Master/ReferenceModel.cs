using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Beta.Models.Master
{
    public class ReferenceModel:CoreModel
    {
        public string ReferenceName { get; set; }
        public string ContactName { get; set; }
        public string Address { get; set; }
        public int Location_ID { get; set; }
        public string TelpHome { get; set; }
        public string TelpWork { get; set; }
        public string Email { get; set; }

        public double Discount { get; set; }
        public int AccountBankID { get; set; }
        public int MethodPaymentID { get; set; }

        public string AccountNumber { get; set; }
        public string AccountName { get; set; }
    }
}
