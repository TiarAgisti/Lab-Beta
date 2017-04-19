using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Beta.Models.Master
{
    public class StockModel:CoreModel
    {
        public string CodeStock { get; set; }
        public string Name { get; set; }
        public int Qty { get; set; }
        public string Unit { get; set; }
        public int TypeStockId { get; set; }
        public int GroupStockId { get; set; }
        public DateTime ExpDate { get; set; }
        public DateTime WarningDate { get; set; }
        public int WarningQty { get; set; }
        public int Status { get; set; }
    }
}
