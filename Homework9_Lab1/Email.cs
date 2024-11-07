using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework9_Lab1
{
    class Email : Document 
    {
		private string sender;

		public string Sender
		{
			get { return sender; }
			set { sender = value; }
		}

		private string recipient;

		public string Recipient
		{
			get { return recipient; }
			set { recipient = value; }
		}

		private string title;

		public string Title
		{
			get { return title; }
			set { title = value; }
		}

		public Email(string sender, string recipient, string title, string text)
		{
			this.Text = text;
			this.Sender = sender;
			this.Recipient = recipient;
			this.Title = title;
		}


		public Email()
		{
			this.Text = "";
			this.Sender = "";
			this.Recipient = "";
			this.Title = "";
		}

        public override string ToString()
        {
			return $"This email was sent by {this.Sender}, recieved by {this.Recipient}, has a subject line of {this.Title}, and reads as follows:\n{this.Text}";
        }

    }
}
