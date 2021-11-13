using MyGameProject.Abstract;
using MyGameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGameProject.Concrete
{
    internal class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer)==true)
            {
                Console.WriteLine("Signed up");
            }
            else
            {
                Console.WriteLine("Verification failed");
            }
            
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Updated");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Deleted");
        }
    }
}
