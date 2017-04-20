using Lab_Beta.EDM;
using Lab_Beta.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Beta.BF
{
    public class BloodGroupBF
    {
        private LaboratoriesEntities db = null;

        public List<BloodGroupModel> SelectComboBox()
        {
            db = new LaboratoriesEntities();

            List<BloodGroupModel> data = db.BloodGroups.Where(i => i.IsActive == true)
                                        .Select(i => new BloodGroupModel
                                           {
                                               Id = i.Id,
                                               Name = i.Name
                                           }).ToList();

            return data;
        }
    }
}
