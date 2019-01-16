using Model.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Interfaces
{
    public interface IInventoryRepository :  IRepositoryBase<InventoryItem>
    {
        void AddArticle(Article article, int quantityToAdd);
       
    }
}
