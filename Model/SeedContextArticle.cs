using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class SeedContextArticle
    {
        public SeedContextArticle(EntityTypeBuilder<Article> entityBuilder)
        {
            entityBuilder.HasData(
                 new Article
                 {
                     IdArticle = Guid.NewGuid(),
                     Label = "POMADE hydradanteXXL-MXL",
                     Description = "Poterit ut Antiochensi dispelleret Antiochensi ut obsecranti principibus victu adesset.",
                     PriceHT = 12,
                     Tax = 3,
                     Activate = true,
                     DelievryTime = 3
                 },
                new Article
                {
                    IdArticle = Guid.NewGuid(),
                    Label = "Creme hydradanteXXL",
                    Description = "Poterit ut Antiochensi dispelleret Antiochensi ut obsecranti principibus victu adesset.",
                    PriceHT = 12,
                    Tax = 3,
                    Activate = true,
                    DelievryTime = 3
                },
                new Article
                {
                    IdArticle = Guid.NewGuid(),
                    Label = "pomade tonic",
                    Description = "Poterit ut Antiochensi dispelleret Antiochensi ut obsecranti principibus victu adesset.",
                    PriceHT = 12,
                    Tax = 3,
                    Activate = true,
                    DelievryTime = 3
                }
                );
        }
    }
}
