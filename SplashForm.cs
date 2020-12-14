//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project:		Project 5 - Associative Containers
//	File Name:		SplashForm.cs
//	Description:	Back-end for Splash screen form, which displays a welcome for 8 seconds.
//	Course:			CSCI 2210-940 - Data Structures
//	Author:			Jeffrey Richards, richardsjm@etsu.edu 
//	Created:		Thursday, December 3, 2020
//
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Windows.Forms;

namespace Project5
{
	/// <summary>
	/// Handles the Splash screen form, which welcomes the user to the application
	/// </summary>
	/// <seealso cref="System.Windows.Forms.Form" />
	public partial class SplashForm : Form
	{
		int countDown;

		/// <summary>
		/// Initializes a new instance of the <see cref="SplashForm"/> class.
		/// </summary>
		public SplashForm()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Handles the Load event of the SplashForm control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void SplashForm_Load(object sender, EventArgs e)
		{
			this.Text = "About Matching State Capitols";
			label1.Text = Application.ProductName;
			label2.Text = "© Jeffrey Richards 2020";
			countDown = 8;
			timer1.Enabled = true;
			timer1.Start();
		}

		/// <summary>
		/// Handles the Tick event of the timer1 control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void timer1_Tick(object sender, EventArgs e)
		{
			countDown--;
			if (countDown <= 0)
				this.Close();
		}
	}
}
