using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fantastical_Deathmatch.Models
{
   public class Creature
    {

        //this is for makin the random nombers
        private static Random _rng = new Random();

        public int _hitPoints;
        public bool _isDead;
        public string _creatureName;
        public int counter = 0;
        public int _dodge = 0;
        public int _armor = 1;

        public int GetHitPoints() { return _hitPoints; }
        public int SetHitPoints(int hp)
        {
            _hitPoints = hp + _rng.Next(10);
            return _hitPoints;
        }

        public bool IsDead()
        {
            if (_hitPoints <= 0) { _isDead = true; }
            else { _isDead = false; }
            return _isDead;
        }

        public void Hit(int damage)
        {
            damage -= _armor;
            _hitPoints -= damage;
            if (_hitPoints <= 0)
            {
                Console.WriteLine($"{_creatureName} has died.");
                _isDead = true;
            }
            else
            {
                Console.WriteLine($"{_armor} damage was blocked!");
                Console.WriteLine($"{_creatureName} has {_hitPoints} health.");
                _isDead = false;
            }
        }

        public void Attack(Creature enemy)
        {
            // fields
            int damage = _rng.Next(2, 12);
            int critchance = _rng.Next(1, 20);
            int hitchance = _rng.Next(1, 10);
            // crit chance
            if (critchance >= 19)
            {
                damage += 10;
                Console.WriteLine();
                Console.WriteLine($"{_creatureName} Crits for {damage} !!!");
                Console.WriteLine();
                counter -= 1;
            }
            else
            {
                Console.WriteLine($"{_creatureName} strikes for {damage}.");
            }

            if (hitchance <= _dodge)
            {
                enemy.Miss();
            }
            else
            {
                enemy.Hit(damage);
            }
        }

        public void Miss()
        {
            Console.WriteLine("and he missed!");
        }
    }
}
