using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class SeedContextBasket
    {
        public SeedContextBasket(EntityTypeBuilder<Basket> entityBuilder)
        {
            entityBuilder.HasData(
                new Basket {
                    BasketId = 123,
                    Account = new Account
                    {
                        IdAccount = Guid.NewGuid(),
                        BillAddress = "2 Avenue NEW-YORK, USA",
                        IsClosed = true,
                        Open = DateTime.Today,
                        Closed = null,

                        User = new User
                        {

                        }
                    },

                });
        }
    }
}
