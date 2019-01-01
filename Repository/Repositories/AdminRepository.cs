using Model;
using Model.Models;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Repositories
{
    public class AdminRepository : RepositoryBase<Article>, IAdminRepository
    {
        public AdminRepository(AppDbContext context) : base(context)
        {
        }
       

        public virtual void GetLogin()
        {
            
        }

        public virtual void GetUserName()
        {

        }
    }
}
