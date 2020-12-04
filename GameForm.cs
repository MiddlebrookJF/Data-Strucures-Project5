using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project5
{
	public partial class GameForm : Form
	{
		public GameForm()
		{
			InitializeComponent();
		}

		private void GameForm_Load(object sender, EventArgs e)
		{
			this.Text = $"{Application.ProductName} by {Application.CompanyName}";
			StreamReader sr = new StreamReader(@"..\..\states.txt");

		}
	}
}
