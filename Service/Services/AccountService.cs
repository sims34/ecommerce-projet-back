using Model.Models;
using Repository.Interfaces;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Services
{
    public class AccountService : ServiceBase<Account>, IAccountService
    {
        private readonly IAccountRepository _accountRepository;
        public AccountService(IAccountRepository repo) : base(repo)
        {
            _accountRepository = repo;
        }
    }
}
