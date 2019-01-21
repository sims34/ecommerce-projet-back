using Model.Models;
using Repository.Interfaces;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Services
{
    public class InventoryService : ServiceBase<InventoryItem>, IInventoryService
    {
        private readonly IInventoryRepository _inventoryRepository;
        public InventoryService(IInventoryRepository repo) : base(repo)
        {
            _inventoryRepository = repo;
        }

        public override InventoryItem Find(Guid id)
        {
            return _inventoryRepository.Find(id);
        }
        public override List<InventoryItem> GetAll()
        {
            return _inventoryRepository.GetAll();
        }
        public override void Add(InventoryItem entity)
        {
            _inventoryRepository.Add(entity);
        }
    }
}