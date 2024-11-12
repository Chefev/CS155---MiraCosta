using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework10_Part1
{
    class MarshmallowManAlien : Alien
    {
        private const int damage = 2;

        public override int GetDamage()
        {
            return damage;
        }

        public MarshmallowManAlien(int h, string n)
        {
            this.Health = h;
            this.Name = n;
        }

        public MarshmallowManAlien()
        {
            this.Health = 100;
            this.Name = "";
        }
    }
}
