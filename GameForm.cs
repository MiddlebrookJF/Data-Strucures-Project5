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
	/// <summary>
	/// Class that handles the Game Form and its parts
	/// </summary>
	/// <seealso cref="System.Windows.Forms.Form" />
	public partial class GameForm : Form
	{
		#region Attributes and Properties
		Random rand = new Random();                 //Used to randomly load a state
		public string[] states;                     //Array of state names
		SortedDictionary<string, string> States;    //Dictionary of States and their Capitals	
		
		/// <summary>
		/// Gets or sets the file paths for all 50 state pictures.
		/// </summary>
		public string[] StatePictures { get; set; }

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
		/// Handles form loading to populate 
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
		/// Disables all.
		/// </summary>
		private void DisableAll()
		{
			CountDown.Enabled = false;
			tbTime.Text = "0";
			lbCapitals.Enabled = false;
			btnNext.Enabled = true;
		}

		/// <summary>
		/// Enables all.
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
		/// Gets the random state with picture.
		/// </summary>
		private void GetRandomStateWithPicture()
		{
			int iRandom = rand.Next(50);
			tbState.Text = states[iRandom];
			string picture = StatePictures[iRandom];
			pbState.ImageLocation = picture;
		}

		/// <summary>
		/// Gets the state pictures.
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
		/// Ends the round.
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
			//Choose new random State to guess the capital for
		}

		private void CountDown_Tick(object sender, EventArgs e)
		{
			tbTime.Text = (Int32.Parse(tbTime.Text) - 1).ToString();
			if (Int32.Parse(tbTime.Text) <= 0 && CountDown.Enabled)
				EndRound();
		}

		private void btnEnd_Click(object sender, EventArgs e)
		{
			CountDown.Enabled = false;
			lbCapitals.Enabled = false;
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
