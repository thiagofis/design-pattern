using Abstract_Factory.Models;
using static Abstract_Factory.Models.Country;

namespace Abstract_Factory.Factories
{
    public class BrazilianPlayerFactory : IPlayerFactory
    {
        public Player CreateFootballPlayer()
        {
            return new Player { Name = "Ronaldo", Nation = Brazil };
        }

        public Player CreateTennisPlayer()
        {
            return new Player { Name = "Gustavo Kuerten", Nation = Brazil };
        }
    }
}
