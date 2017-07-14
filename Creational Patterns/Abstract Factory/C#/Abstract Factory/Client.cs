using Abstract_Factory.Factories;
using System;

namespace Abstract_Factory
{
    class Client
    {
        static void Main(string[] args)
        {
            IPlayerFactory brazilianPlayerFactory = new BrazilianPlayerFactory();
            var brazilianFootballPlayer = brazilianPlayerFactory.CreateFootballPlayer();
            var brazilianTennisPlayer = brazilianPlayerFactory.CreateTennisPlayer();

            IPlayerFactory euaPlayerFactory = new EUAPlayerFactory();
            var euaFootballPlayer = euaPlayerFactory.CreateFootballPlayer();
            var euaTennisPlayer = euaPlayerFactory.CreateTennisPlayer();

            Console.WriteLine(brazilianFootballPlayer);
            Console.WriteLine(brazilianTennisPlayer);
            Console.WriteLine(euaFootballPlayer);
            Console.WriteLine(euaTennisPlayer);
            Console.ReadKey();
        }
    }
}
