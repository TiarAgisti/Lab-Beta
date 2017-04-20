using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab_Beta.Models.Master;
using Lab_Beta.Controller.Master;

namespace Lab_Beta.Pengaturan
{
    public partial class FrmPengaturanPembayaran : Form
    {
        public FrmPengaturanPembayaran()
        {
            InitializeComponent();
        }

        private AccountBankModel SetModel()
        {
            AccountBankModel model = new AccountBankModel();
            model.Name = this.txtNamaAkun.Text;
            model.DateCreate = model.DateModify = DateTime.Now;
            model.UserCreate = model.UserModify = 1;
            return model;
        }

        void ClearText()
        {
            this.txtNamaAkun.Clear();
        }

        void Save()
        {
            try
            {
                AccountBankController obj = new AccountBankController();
                //SetModel();
                obj.Save(this.SetModel());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnSimpanAkun_Click(object sender, EventArgs e)
        {
            //MahasiswaController mhsController = new MahasiswaController();
            //MahasiswaModel model = new MahasiswaModel();
            //model.Jurusan = txtJurusan.Text;
            //model.Nama = txtNama.Text;
            //model.NIM = txtNim.Text;
            //mhsController.Save(model);

            //MessageBox.Show("Sukses");
            //this.txtNim.Clear();
            //this.txtNama.Clear();
            //this.txtJurusan.Clear();
            this.Save();
            this.ClearText();
            MessageBox.Show("Sukses");
        }
    }
}
