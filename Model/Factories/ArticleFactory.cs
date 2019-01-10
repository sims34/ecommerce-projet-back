using Model.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Factories
{
    public class ArticleFactory
    {
        public static Article[] DefaultArticles = new Article[]
        {
            
            new Article
                 {
                     IdArticle = new Guid("78ace119-29bc-4903-a68f-fa10db32bcbf"),
                     PriceHT = 12,
                     Tax = 3,
                     Activate = true,
                     Label = "Creme hydradanteXXL",
                    Description = "Poterit ut Antiochensi dispelleret Antiochensi ut obsecranti principibus victu adesset.",
                     DelievryTime = 3
                 }
            ,
                new Article
                {
                    IdArticle = new Guid("78ace119-29bc-4903-a68f-fa10db32bcaa"),
                    Label = "Creme hydradanteXXL",
                    Description = "Poterit ut Antiochensi dispelleret Antiochensi ut obsecranti principibus victu adesset.",
                    PriceHT = 12,
                    Tax = 3,
                    Activate = true,
                    DelievryTime = 3
                },
                new Article
                {
                    IdArticle = new Guid("78ace119-29bc-4903-a68f-fa10db32bcbb"),
                    Label = "pomade tonic",
                    Description = "Poterit ut Antiochensi dispelleret Antiochensi ut obsecranti principibus victu adesset.",
                    PriceHT = 12,
                    Tax = 3,
                    Activate = true,
                    DelievryTime = 3
                }
        };
    
    }
}
