using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Beta.Models.Master
{
    public class AccessModel
    {
        public int Id { get; set; }
        public int GroupUserId { get; set; }
        public string NameOption { get; set; }
        public string Controller { get; set; }
        public string Action { get; set; }
        public string ImageClass { get; set; }
        public bool Status { get; set; }
        public bool isParent { get; set; }
        public int parentId { get; set; }
    }
}
