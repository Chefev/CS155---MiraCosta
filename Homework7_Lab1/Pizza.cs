using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7_Lab1
{
    class Pizza
    {
        private string _size;

        public string Size
        {
            get { return _size; }
            set { _size = value; }
        }

        private int _cheesenum;

        public int Cheesenum
        {
            get { return _cheesenum; }
            set { _cheesenum = value; }
        }

        private int _pepperoninum;

        public int Pepperoninum
        {
            get { return _pepperoninum; }
            set { _pepperoninum = value; }
        }

        private int _hamnum;

        public int Hamnum
        {
            get { return _hamnum; }
            set { _hamnum = value; }
        }

        public Pizza()
        {
            _size = "small";
            _cheesenum = 1;
            _pepperoninum = 0;
            _hamnum = 0;
        }

        public Pizza(string size, int cheesenum, int pepperoninum, int hamnum)
        {
            _size = size;
            _cheesenum = cheesenum;
            _pepperoninum = pepperoninum;
            _hamnum = hamnum;
        }

        public double CalculateCost()
        {
            double cost = 0;
            switch (_size)
            {
                case "small":
                    cost += 10;
                    break;
                case "medium":
                    cost += 12;
                    break;
                case "large":
                    cost += 14;
                    break;
            }

            cost += ((_cheesenum * 2) + (_pepperoninum * 2) + (_hamnum * 2));
            return cost;
        }

        override public string ToString()
        {
            return $"This pizza is size {_size}, with {_cheesenum} cheese toppings, {_pepperoninum} pepperoni toppings, and {_hamnum} ham toppings. It costs a total of ${this.CalculateCost()}";
        }
    }
}
