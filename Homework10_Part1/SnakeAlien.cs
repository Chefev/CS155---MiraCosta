using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework10_Part1
{
    class SnakeAlien : Alien
    {
        private const int damage = 0;

        public override int GetDamage()
        {
            return damage;
        }
        public SnakeAlien(int h, string n)
        {
            this.Health = h;
            this.Name = n;
        }

        public SnakeAlien()
        {
            this.Health = 100;
            this.Name = "";
        }
    }
}
