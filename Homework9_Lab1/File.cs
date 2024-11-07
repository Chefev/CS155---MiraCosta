using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework9_Lab1
{
    class File : Document
    {
		private string path_name;

		public string Path_Name
		{
			get { return path_name; }
			set { path_name = value; }
		}

		public File()
		{
			this.Text = "";
			this.Path_Name = "";
		}

		public File(string path_name, string text)
		{
			this.Text = text;
			this.Path_Name = path_name;
		}

        public override string ToString()
        {
			return $"This file is located at {this.Path_Name} and reads as follows:\n{this.Text}";
        }
    }
}
