using Model.Models;

namespace Repository.Interfaces
{
    public interface IAdminRepository : IRepositoryBase<Admin>
    {
        void GetUserName();
        void GetLogin();
    }
}
