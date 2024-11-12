using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework10_Part1
{
    class AlienPack
    {
        private Alien[] aliens;

        public AlienPack(int numaliens)
        {
            aliens = new Alien[numaliens];
        }
        public void AddAlien(Alien newAlien, int index)
        {
            aliens[index] = newAlien;
        }
        public Alien[] GetAliens()
        {
            return aliens;
        }
        public int CalculateDamage()
        {
            int damage = 0;
            for (int i =0; i < aliens.Length; i++)
            {
                damage += aliens[i].GetDamage();
            }

            return damage;
        }
    }
}
