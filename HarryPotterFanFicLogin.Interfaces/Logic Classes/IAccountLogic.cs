using System;
using System.Collections.Generic;
using System.Text;

namespace HarryPotterFanFicLogin.Interfaces.Logic_Classes
{
    public interface IAccountLogic
    {
        void CreateAccount(IAccount account);
        List<IAccount> GetAllAccounts();
        IAccount UpdateAccount(IAccount account);
        void DeleteAccount(int accountId);
        IAccount GetById(IAccount account);
    }
}