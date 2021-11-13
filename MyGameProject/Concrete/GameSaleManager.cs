using MyGameProject.Abstract;
using MyGameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGameProject.Concrete
{
    internal class GameSaleManager : IGameSaleService
    {
        public void Sale(Gamer gamer, Game game, Campaign campaign)
        {
            double newPrice = game.GamePrice - (game.GamePrice * (campaign.CampaignDiscount / 100));
            Console.WriteLine(game.GameName + " sold to " + gamer.FirstName + " " + gamer.LastName );
            Console.WriteLine("Discounted Price : " + newPrice + " $");
            
        }
    }
}
