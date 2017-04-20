using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab_Beta.Models.Master;
using Lab_Beta.EDM;

namespace Lab_Beta.BF.Master
{
    public class AccountBankBFC
    {
        public void Save(AccountBankModel obj)
        {
            try
            {
                LaboratoriesEntities ent = new LaboratoriesEntities();
                AccountBank accBank = new AccountBank();
                accBank.Id = obj.Id;
                accBank.Name = obj.Name;
                accBank.UserCreate = obj.UserCreate;
                accBank.DateCreate = obj.DateCreate;
                accBank.UserModify = obj.UserModify;
                accBank.DateModify = obj.DateModify;
                accBank.IsActive = obj.IsActive;
                ent.AccountBanks.Add(accBank);
                ent.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message.ToString());
            }
        }
    }
}
