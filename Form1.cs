using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void radButton5_Click(object sender, EventArgs e)
		{
			string message = "Your are doing great!";
			MessageBox.Show(message);
		}

		private void radButton1_Click(object sender, EventArgs e)
		{
			string message = "Your are doing great from second button!";
			MessageBox.Show(message);
		}
	}
}
