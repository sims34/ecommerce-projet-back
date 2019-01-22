using Microsoft.EntityFrameworkCore;
using Model.Factories;
using Model.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class SeedContextLogin
    {
        public SeedContextLogin(ModelBuilder entityBuilder)
        {
            entityBuilder.Entity<Login>().HasData(LoginFactory.DefaultLogin);
        }
    }
}
