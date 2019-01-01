using Model;
using Model.Models;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Repositories
{
    public class CardRepository : RepositoryBase<Basket>, ICardRepository
    {
        public CardRepository(AppDbContext context) : base(context)
        {
        }
    }
}
