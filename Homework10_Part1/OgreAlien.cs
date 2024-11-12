using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework10_Part1
{
    class OgreAlien : Alien
    {
        private const int damage = 1;

        public override int GetDamage()
        {
            return damage;
        }
        public OgreAlien(int h, string n)
        {
            this.Health = h;
            this.Name = n;
        }

        public OgreAlien()
        {
            this.Health = 100;
            this.Name = "";
        }
    }
}
