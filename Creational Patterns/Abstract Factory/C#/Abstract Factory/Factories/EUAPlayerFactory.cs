using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstract_Factory.Models;
using static Abstract_Factory.Models.Country;

namespace Abstract_Factory.Factories
{
    public class EUAPlayerFactory : IPlayerFactory
    {
        public Player CreateFootballPlayer()
        {
            return new Player { Name = "Landon Donovan", Nation = EUA };
        }

        public Player CreateTennisPlayer()
        {
            return new Player { Name = "Andre Agassi", Nation = EUA };
        }
    }
}
