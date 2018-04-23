using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MyXtraGrid
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			for (int i = 0; i <= 9; i++)
			{
				dataTable1.Rows.Add(new object[] {"Item Wg " + i.ToString()});
			}
		}
	}
}