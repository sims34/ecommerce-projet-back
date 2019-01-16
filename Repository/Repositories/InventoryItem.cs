using Model.Models;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Repositories
{
    public class InventoryItem : RepositoryBase<InventoryItem>, IInventoryRepository

    {
        private Article article;
        private int quantityToAdd;

        public InventoryItem(Article article, int quantityToAdd)
        {
            this.article = article;
            this.quantityToAdd = quantityToAdd;
        }
    }
}
