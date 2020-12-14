//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project:		Project 5 - Associative Containers
//	File Name:		GameForm.cs
//	Description:	Back-end class for the primary Form of the state matching application
//	Course:			CSCI 2210-940 - Data Structures
//	Author:			Jeffrey Richards, richardsjm@etsu.edu 
//	Created:		Thursday, December 3, 2020
//
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Project5
{
	/// <summary>
	/// Class that handles the Game Form and its parts, which gives the user a state-matching game.
	/// </summary>
	/// <seealso cref="System.Windows.Forms.Form" />
	public partial class GameForm : Form
	{
		#region Attributes and Properties
		private Random rand = new Random();                 //Used to randomly load a state
		private string[] states;                     //Array of state names

		/// <summary>
		/// Dictionary of States and their Capitals	
		/// </summary>
		private SortedDictionary<string, string> States { get; set; }
		/// <summary>
		/// Gets or sets the file paths for all 50 state pictures.
		/// </summary>
		private string[] StatePictures { get; set; }
		#endregion

		/// <summary>
		/// Initializes a new instance of the <see cref="GameForm"/> class.
		/// </summary>
		public GameForm()
		{
			InitializeComponent();
			this.Icon = new Icon(@"..\..\Resources\Capitol.ico");
			DisableAll();
			States = new SortedDictionary<string, string>();
			tbAttempts.Text = "0";
			tbCorrect.Text = "0";
		}

		/// <summary>
		/// Handles form loading to populate States and get the game ready
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void GameForm_Load(object sender, EventArgs e)
		{
			this.Text = $"{Application.ProductName} by {Application.CompanyName}";
			StreamReader sr = new StreamReader(@"..\..\Resources\states.txt");
			for (int i = 0; i < 50; i++)
			{
				string line = sr.ReadLine();
				string[] fields = line.Split(',');
				string state = fields[1].Trim();
				string capital = fields[0].Trim();
				States.Add(state, capital);
			}
			sr.Close();

			GetStatePictures();
			lbCapitals.DataSource = States.Values.ToArray();			//Load list of Capitals
			states = States.Keys.ToArray();

			EnableAll();

		}

		/// <summary>
		/// Disables the timer and Capitols list box while enabling the Next Question button
		/// </summary>
		private void DisableAll()
		{
			CountDown.Enabled = false;
			tbTime.Text = "0";
			lbCapitals.Enabled = false;
			btnNext.Enabled = true;
		}

		/// <summary>
		/// Enables the timer and Capitols list box while disabling the Next Question button to start the next round
		/// </summary>
		private void EnableAll()
		{
			CountDown.Enabled = true;
			lbCapitals.Enabled = true;
			btnNext.Enabled = false;
			tbTime.Text = "20";
			//Start round
			GetRandomStateWithPicture();
			CountDown.Start();
		}

		/// <summary>
		/// Gets the random state for the user to guess, along with its picture
		/// </summary>
		private void GetRandomStateWithPicture()
		{
			int iRandom = rand.Next(50);
			tbState.Text = states[iRandom];
			string picture = StatePictures[iRandom];
			pbState.ImageLocation = picture;
		}

		/// <summary>
		/// Loads the StatePictures from file
		/// </summary>
		private void GetStatePictures()
		{
			string pictureDir = @"..\..\StatePictures";
			var files = from file in Directory.GetFiles(pictureDir)
						orderby file
						select file;
			StatePictures = files.ToArray();
		}

		/// <summary>
		/// Handles the SelectedIndexChanged event of the lbCapitals control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void lbCapitals_SelectedIndexChanged(object sender, EventArgs e)
		{
			if(CountDown.Enabled)
				EndRound();
		}

		/// <summary>
		/// Ends a round of guessing, adjusting score accordingly.
		/// </summary>
		private void EndRound()
		{
			DisableAll();
			tbAttempts.Text = (Int32.Parse(tbAttempts.Text) + 1).ToString();	//Update score

			string correctCapitol = States[tbState.Text];						//Get the correct answer
			if((string)lbCapitals.SelectedItem == correctCapitol)						//If correct answer was selected...
			{
				tbCorrect.Text = (Int32.Parse(tbCorrect.Text) + 1).ToString();
				MessageBox.Show("That's correct! Your score has increased.", "Correct", MessageBoxButtons.OK);
			}
			else
				MessageBox.Show($"You did not pick the right answer. The capitol was {correctCapitol}.", "Incorrect", MessageBoxButtons.OK);
		}

		/// <summary>
		/// Handles the Click event of the btnNext control, starting the next round of guessing the capital.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void btnNext_Click(object sender, EventArgs e)
		{
			EnableAll();
		}

		/// <summary>
		/// Handles the Tick event of the CountDown control (every 1 second)
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void CountDown_Tick(object sender, EventArgs e)
		{
			tbTime.Text = (Int32.Parse(tbTime.Text) - 1).ToString();
			if (Int32.Parse(tbTime.Text) <= 0 && CountDown.Enabled)
				EndRound();
		}

		/// <summary>
		/// Handles the Click event of the btnEnd control, which ends the current game.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void btnEnd_Click(object sender, EventArgs e)
		{
			//disable necessary controls
			CountDown.Enabled = false;
			lbCapitals.Enabled = false;
			//calculate percent correct from score
			int attempts = Int32.Parse(tbAttempts.Text);
			int correct = Int32.Parse(tbCorrect.Text);
			int percentCorrect;
			percentCorrect = (attempts > 0) ? (correct * 100 / attempts)  :  0;
			MessageBox.Show($"Thanks for playing! Your final score was {correct}/{attempts}, and you " +
				$"answered {percentCorrect}% of questions correct.", "Game Ended", MessageBoxButtons.OK);
			//reset attempts and correct counters
			tbAttempts.Text = "0";
			tbCorrect.Text = "0";
			EnableAll();
		}

	}
}
