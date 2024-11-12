using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework10_Part1
{
    class Alien
    {
        private int health;

        public int Health
        {
            get { return health; }
            set { health = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }



        public Alien(int h, string n)
        {
            this.Health = h;
            this.Name = n;
        }

        public Alien()
        {
            this.Health = 100;
            this.Name = "";
        }

        public virtual int GetDamage()
        {
            return 0;
        }
    }
}
