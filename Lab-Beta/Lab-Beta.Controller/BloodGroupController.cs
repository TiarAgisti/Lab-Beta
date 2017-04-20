using Lab_Beta.BF;
using Lab_Beta.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Beta.Controller
{
    public class BloodGroupController
    {
        private BloodGroupBF bloodBF = null;

        public List<BloodGroupModel> ListComboBox()
        {
            bloodBF = new BloodGroupBF();
            return bloodBF.SelectComboBox();
        }

    }
}
