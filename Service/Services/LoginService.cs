using Model.Models;
using Repository.Interfaces;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Services
{
    public class LoginService : ServiceBase<Login>, ILoginService
    {
        private readonly ILoginRepository _loginRepository;
        public LoginService(ILoginRepository repo) : base(repo)
        {
            _loginRepository = repo;
        }
    }
}
