using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fantastical_Deathmatch.Models
{
   public class Orc:Creature
    {

        string[] nameGenerator = new string[]
        { "Grogar", "Xanzar", "Allaar", "Boogar", "Stagarr", "Cranbar", "Snowgar" };

        string[] titleGenerator = new string[]
        { "Wolftamer", "Dragonstabber", "Tinkerer", "Chef", "Destroyer", "Explosive", "Orc Annoyer" };

        string[] clanGenerator = new string[]
        { "Stonebird Clan", "Humanslayer Clan", "Wyrmskin Clan", "Rider Clan"};

        private static Random _rng = new Random();

        public Orc()
        {
            _creatureName = nameGenerator[_rng.Next(6)] + " the " + titleGenerator[_rng.Next(6)] + " of " + clanGenerator[_rng.Next(3)];

            _dodge = 4;

            _hitPoints -= 5;

            _armor += _rng.Next(0, 2);
        }
    }
}
