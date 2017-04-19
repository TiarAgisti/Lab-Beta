using Lab_Beta.Controller;
using Lab_Beta.BF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Beta.Master
{
    public partial class FrmDokter : Form
    {
        private BloodGroupController bloodController = null;
        public FrmDokter()
        {
            InitializeComponent();
            Populate();
        }

        private void Populate()
        {
            bloodController = new BloodGroupController();
            cbxBlood.DataSource = bloodController.ListComboBox();
        }
    }
}
