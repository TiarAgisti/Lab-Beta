using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab_Beta.Models.Master;
using Lab_Beta.BF.Master;

namespace Lab_Beta.Controller.Master
{
    public class AccountBankController
    {
        public void Save(AccountBankModel model)
        {
            try
            {
                AccountBankBFC bfc = new AccountBankBFC();
                bfc.Save(model);
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message.ToString());
            }
        }
    }
}
