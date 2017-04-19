using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Beta.Models.Master
{
    public class UserModel:CoreModel
    {
        public string UserName { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public int DepartementId { get; set; }
        public int GroupUserId { get; set; }
        public string Email { get; set; }
        public bool Status { get; set; }
        public byte Picture { get; set; }
    }
}
