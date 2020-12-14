//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project:		Project 5 - Associative Containers
//	File Name:		Program.cs
//	Description:	Driver for Project5 which runs the Splash screen and Game forms.
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
	/// Creates the SplashForm and GameForm forms for the state matching game
	/// </summary>
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new SplashForm());
			Application.Run(new GameForm());
		}
	}
}
