using Abstract_Factory.Models;

namespace Abstract_Factory.Factories
{
    public interface IPlayerFactory
    {
        Player CreateTennisPlayer();

        Player CreateFootballPlayer();
    }
}
