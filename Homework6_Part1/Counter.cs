using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6_Part1
{
    internal class Counter
    {
        int count;
        public Counter() {
            count = 0;
        }

        public int get()
        {
            return this.count;
        }

        public void reset()
        {
            this.count = 0;
        }

        public void add()
        {
            this.count++;
        }

        public void subtract()
        {
            if (count > 0)
            {
                this.count--;
            }
        }

        public void print()
        {
            Console.WriteLine($"The counter is currently at {this.count.ToString()}");
            Console.WriteLine();
        }
    }
}
