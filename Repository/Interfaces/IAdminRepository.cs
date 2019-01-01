using Model.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Interfaces
{
    public interface IAdminRepository : IRepositoryBase<Admin>
    {
        void GetUserName();
        void GetLogin();
    }
}
