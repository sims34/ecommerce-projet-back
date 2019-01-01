using Model.Models;
using Repository.Interfaces;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Services
{
    public class AdminService : ServiceBase<Admin>, IAdminService
    {
        public AdminService(IRepositoryBase<Admin> repo) : base(repo)
        {
        }


    }
}
