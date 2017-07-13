using Abstract_Factory.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
