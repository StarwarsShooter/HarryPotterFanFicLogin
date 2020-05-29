using System;
using System.Collections.Generic;
using System.Text;

namespace HarryPotterFanFicLogin.Interfaces.Handlers
{
    public interface IAccountDataBaseHandler
    {
        List<IAccount> GetAllAccounts();

        void CreateAccount(IAccount A1);

        void UpdateAccount(IAccount A1);

        void DeleteAccount(int ID);
        IAccount GetById(IAccount eventRegistration);
    }
}