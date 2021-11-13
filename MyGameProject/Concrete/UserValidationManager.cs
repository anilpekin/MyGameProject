using MyGameProject.Abstract;
using MyGameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGameProject.Concrete
{
    internal class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 1991 && gamer.FirstName == "ANIL" && gamer.LastName=="PEKİN" && gamer.IdentityNumber==12345)
            {
                return true;
            }
            else
            {
                return false;
            }
         
        }
    }
}
