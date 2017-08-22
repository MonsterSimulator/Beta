using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Fantastical_Deathmatch
{
    class Workflow
    {
        string c1;
        string c2;
        int coinflip;

        public object _creatureName { get; private set; }

        public void NameSelection()
        {
            Console.WriteLine("**********************************");
            Console.WriteLine("Welcome to Fantastical Deathmatch!");
            Console.WriteLine("**********************************");
        }

        public void Battle(Creature c1, Creature c2)
        {
            c1.SetHitPoints(40);
            c2.SetHitPoints(40);

            while (c1.IsDead() == false && c2.IsDead() == false)
            {
                Thread.Sleep(2000);
                if (coinflip == 1) { c1.Attack(c2); coinflip = 2; }
                else { Console.WriteLine(); c2.Attack(c1); coinflip = 1; Console.WriteLine(); }
            }
            Console.WriteLine("And we have a winnnnnneerrrrr!");
            Console.ReadLine();
        }

        public Creature SummonCreature()
        {
            Console.WriteLine("Choose your fighter - (G)oblin, (O)rc, (S)keleton");
            var summon = Console.ReadLine();
            Creature Creature = new Creature();
            switch (summon)
            {
                case "G":
                    Creature = new Goblin();
                    break;
                case "O":
                    Creature = new Orc();
                    break;
                case "S":
                    Creature = new Skeleton();
                    break;
            }
            return Creature;
        }

        public void Intro()
        {
            Console.WriteLine("Today's Fighters are:");
            Console.WriteLine($"{_creatureName} equipped with a club");
        }

        public void CoinFlip()
        {
            Random _rng = new Random();
            coinflip = _rng.Next(1, 2);
        }
    }
}
