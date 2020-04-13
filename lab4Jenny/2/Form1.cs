using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2
{
	
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string st;
			st = textBox1.Text.ToString();
			string line = st;
			string maxword = "blablabla";
			string[] words = line.Split(' ', '.', '!', '?', ':', ';');
			int max = 0;
			foreach (string word in words)
				if (word.Length > max)
				{
					max = word.Length;
					maxword = word;					
				}
			label1.Text = max.ToString() + " - максимальное количество символов " + " ";
			foreach (string word in words)
				if (word.Length == max) {
					label1.Text += " " + word ;
				}
				
		}
	}
}
