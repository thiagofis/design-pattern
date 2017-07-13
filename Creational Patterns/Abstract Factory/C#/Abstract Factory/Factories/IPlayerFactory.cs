using Abstract_Factory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory.Factories
{
    public interface IPlayerFactory
    {
        Player CreateTennisPlayer();

        Player CreateFootballPlayer();
    }
}
