using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7_Part1
{
    public class Odometer
    {
        private int _miles;
        private int _fuel;

        public string getMiles()
        {
            return _miles.ToString();
        }

        public string getFuel()
        {
            return _fuel.ToString();
        }
        
        public Odometer() 
        {
            _miles = 0;
            _fuel = 0;
        }

        public Odometer(int miles, int fuel)
        {
            _miles = miles;
            _fuel = fuel;
        }

        public void reset()
        {
            _miles = 0;
            _fuel = 0;
        }

        public void add(int mile, int fuel)
        {
            _miles += mile;
            _fuel += fuel;
        }

        public string getMPG()
        {
            return (_miles / _fuel).ToString();
        }
    }
}
