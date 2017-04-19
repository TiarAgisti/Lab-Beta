using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Beta.Models
{
    public class CoreModel
    {
        public int Id { get; set; }
        public Nullable<int> UserCreate { get; set; }
        public Nullable<System.DateTime> DateCreate { get; set; }
        public Nullable<int> UserModify { get; set; }
        public Nullable<System.DateTime> DateModify { get; set; }
        public bool IsActive { get; set; }
    }
}
