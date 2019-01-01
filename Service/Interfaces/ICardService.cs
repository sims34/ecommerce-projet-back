using Model.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Interfaces
{
    public interface ICardService : IServiceBase<Basket>
    {
        void CronCardValidation(ICardService card);
    }
}
