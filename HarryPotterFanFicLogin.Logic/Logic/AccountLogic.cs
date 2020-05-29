using HarryPotterFanFicLogin.Interfaces;
using HarryPotterFanFicLogin.Interfaces.Handlers;
using HarryPotterFanFicLogin.Interfaces.Logic_Classes;
using HarryPotterFanFicLogin.Logic.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace HarryPotterFanFicLogin.Logic
{
    public class AccountLogic : IAccountLogic
    {
        private readonly IAccountDataBaseHandler _accountDataBaseHandler;

        public AccountLogic(IAccountDataBaseHandler accountDataBaseHandler)
        {
            _accountDataBaseHandler = accountDataBaseHandler;
        }

        private IAccountDataBaseHandler AccountDataBaseHandler { get; }

        public void CreateAccount(IAccount account)
        {
            var _account = new Account()
            {

            };
            AccountDataBaseHandler.CreateAccount(_account);
        }

        public List<IAccount> GetAllAccounts()
        {
            return AccountDataBaseHandler.GetAllAccounts();
        }

        public IAccount UpdateAccount(IAccount account)
        {
            AccountDataBaseHandler.UpdateAccount(account);
            return account;
        }

        public void DeleteAccount(int accountId)
        {
            AccountDataBaseHandler.DeleteAccount(accountId);
        }

        public IAccount GetById(IAccount account)
        {
            return AccountDataBaseHandler.GetById(account);
        }
    }
}