using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework9_Lab1
{
    class Document
    {
        private string text;

        public string Text { get { return text; } set { text = value; } }

        public override string ToString()
        {
            return $"This document readers:\n{this.Text}";
        }

        public Document(string text)
        {
            this.text = text;
        }

        public Document()
        {
            this.text = "";
        }
    }
}
