using MyGameProject.Abstract;
using MyGameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGameProject.Concrete
{
    internal class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.GameName + " added.\n" +
               "Price: " + game.GamePrice +
               "\nCategory: " + game.GameCategory);
        }

        public void Delete(Game game)
        {

            Console.WriteLine(game.GameName + " removed");
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.GameName + " updated");
        }
    }
}
