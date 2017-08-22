using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
   public class Orc:Creature
    {

        private static Random _rng = new Random();

        private int _hitPoints;
        private string _name;
        private bool _isDead;

        public int GetHitPoints() { return _hitPoints; }
        public int SetHitPoints(int hp) {
            _hitPoints = hp + _rng.Next(15);
            return _hitPoints;
        }
        public string GetName() { return _name; }
        public string SetName(string name) { _name = name; return _name;}

        public bool IsDead() { return _isDead; }
        
        //public void Attack(Creature enemy)
    }
}
