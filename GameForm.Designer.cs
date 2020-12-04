
namespace Project5
{
	partial class GameForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.lbCapitals = new System.Windows.Forms.ListBox();
			this.tbCorrect = new System.Windows.Forms.TextBox();
			this.tbAttempts = new System.Windows.Forms.TextBox();
			this.tbState = new System.Windows.Forms.TextBox();
			this.tbTime = new System.Windows.Forms.TextBox();
			this.lblWhatCapital = new System.Windows.Forms.Label();
			this.lblTime = new System.Windows.Forms.Label();
			this.lblAttempts = new System.Windows.Forms.Label();
			this.lblCorrect = new System.Windows.Forms.Label();
			this.pbState = new System.Windows.Forms.PictureBox();
			this.lblListBox = new System.Windows.Forms.Label();
			this.CountDown = new System.Windows.Forms.Timer(this.components);
			this.btnNext = new System.Windows.Forms.Button();
			this.btnEnd = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pbState)).BeginInit();
			this.SuspendLayout();
			// 
			// lbCapitals
			// 
			this.lbCapitals.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbCapitals.FormattingEnabled = true;
			this.lbCapitals.ItemHeight = 16;
			this.lbCapitals.Location = new System.Drawing.Point(402, 42);
			this.lbCapitals.Name = "lbCapitals";
			this.lbCapitals.Size = new System.Drawing.Size(119, 340);
			this.lbCapitals.Sorted = true;
			this.lbCapitals.TabIndex = 0;
			this.lbCapitals.SelectedIndexChanged += new System.EventHandler(this.lbCapitals_SelectedIndexChanged);
			// 
			// tbCorrect
			// 
			this.tbCorrect.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbCorrect.Location = new System.Drawing.Point(266, 311);
			this.tbCorrect.Name = "tbCorrect";
			this.tbCorrect.ReadOnly = true;
			this.tbCorrect.Size = new System.Drawing.Size(31, 24);
			this.tbCorrect.TabIndex = 1;
			// 
			// tbAttempts
			// 
			this.tbAttempts.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbAttempts.Location = new System.Drawing.Point(108, 311);
			this.tbAttempts.Name = "tbAttempts";
			this.tbAttempts.ReadOnly = true;
			this.tbAttempts.Size = new System.Drawing.Size(31, 24);
			this.tbAttempts.TabIndex = 2;
			// 
			// tbState
			// 
			this.tbState.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbState.Location = new System.Drawing.Point(207, 54);
			this.tbState.Name = "tbState";
			this.tbState.ReadOnly = true;
			this.tbState.Size = new System.Drawing.Size(156, 24);
			this.tbState.TabIndex = 3;
			this.tbState.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// tbTime
			// 
			this.tbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbTime.ForeColor = System.Drawing.SystemColors.Highlight;
			this.tbTime.Location = new System.Drawing.Point(76, 176);
			this.tbTime.Name = "tbTime";
			this.tbTime.ReadOnly = true;
			this.tbTime.Size = new System.Drawing.Size(72, 29);
			this.tbTime.TabIndex = 4;
			// 
			// lblWhatCapital
			// 
			this.lblWhatCapital.AutoSize = true;
			this.lblWhatCapital.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblWhatCapital.Location = new System.Drawing.Point(47, 57);
			this.lblWhatCapital.Name = "lblWhatCapital";
			this.lblWhatCapital.Size = new System.Drawing.Size(149, 18);
			this.lblWhatCapital.TabIndex = 5;
			this.lblWhatCapital.Text = "What is the capital of:";
			// 
			// lblTime
			// 
			this.lblTime.AutoSize = true;
			this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTime.Location = new System.Drawing.Point(56, 147);
			this.lblTime.Name = "lblTime";
			this.lblTime.Size = new System.Drawing.Size(119, 18);
			this.lblTime.TabIndex = 6;
			this.lblTime.Text = "Time Remaining:";
			// 
			// lblAttempts
			// 
			this.lblAttempts.AutoSize = true;
			this.lblAttempts.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAttempts.Location = new System.Drawing.Point(93, 282);
			this.lblAttempts.Name = "lblAttempts";
			this.lblAttempts.Size = new System.Drawing.Size(66, 18);
			this.lblAttempts.TabIndex = 7;
			this.lblAttempts.Text = "Attempts";
			// 
			// lblCorrect
			// 
			this.lblCorrect.AutoSize = true;
			this.lblCorrect.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCorrect.Location = new System.Drawing.Point(253, 282);
			this.lblCorrect.Name = "lblCorrect";
			this.lblCorrect.Size = new System.Drawing.Size(58, 18);
			this.lblCorrect.TabIndex = 8;
			this.lblCorrect.Text = "Correct";
			// 
			// pbState
			// 
			this.pbState.Location = new System.Drawing.Point(207, 111);
			this.pbState.Name = "pbState";
			this.pbState.Size = new System.Drawing.Size(156, 147);
			this.pbState.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbState.TabIndex = 9;
			this.pbState.TabStop = false;
			// 
			// lblListBox
			// 
			this.lblListBox.AutoSize = true;
			this.lblListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblListBox.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblListBox.Location = new System.Drawing.Point(399, 21);
			this.lblListBox.Name = "lblListBox";
			this.lblListBox.Size = new System.Drawing.Size(122, 18);
			this.lblListBox.TabIndex = 10;
			this.lblListBox.Text = "Select the Capital";
			// 
			// CountDown
			// 
			this.CountDown.Interval = 1000;
			this.CountDown.Tick += new System.EventHandler(this.CountDown_Tick);
			// 
			// btnNext
			// 
			this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNext.Location = new System.Drawing.Point(63, 349);
			this.btnNext.Name = "btnNext";
			this.btnNext.Size = new System.Drawing.Size(112, 33);
			this.btnNext.TabIndex = 11;
			this.btnNext.Text = "Next Question";
			this.btnNext.UseVisualStyleBackColor = true;
			this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
			// 
			// btnEnd
			// 
			this.btnEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEnd.Location = new System.Drawing.Point(222, 349);
			this.btnEnd.Name = "btnEnd";
			this.btnEnd.Size = new System.Drawing.Size(112, 33);
			this.btnEnd.TabIndex = 12;
			this.btnEnd.Text = "End Game";
			this.btnEnd.UseVisualStyleBackColor = true;
			this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
			// 
			// GameForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(540, 414);
			this.Controls.Add(this.btnEnd);
			this.Controls.Add(this.btnNext);
			this.Controls.Add(this.lblListBox);
			this.Controls.Add(this.pbState);
			this.Controls.Add(this.lblCorrect);
			this.Controls.Add(this.lblAttempts);
			this.Controls.Add(this.lblTime);
			this.Controls.Add(this.lblWhatCapital);
			this.Controls.Add(this.tbTime);
			this.Controls.Add(this.tbState);
			this.Controls.Add(this.tbAttempts);
			this.Controls.Add(this.tbCorrect);
			this.Controls.Add(this.lbCapitals);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(556, 453);
			this.MinimumSize = new System.Drawing.Size(556, 453);
			this.Name = "GameForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.GameForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.pbState)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox lbCapitals;
		private System.Windows.Forms.TextBox tbCorrect;
		private System.Windows.Forms.TextBox tbAttempts;
		private System.Windows.Forms.TextBox tbState;
		private System.Windows.Forms.TextBox tbTime;
		private System.Windows.Forms.Label lblWhatCapital;
		private System.Windows.Forms.Label lblTime;
		private System.Windows.Forms.Label lblAttempts;
		private System.Windows.Forms.Label lblCorrect;
		private System.Windows.Forms.PictureBox pbState;
		private System.Windows.Forms.Label lblListBox;
		private System.Windows.Forms.Timer CountDown;
		private System.Windows.Forms.Button btnNext;
		private System.Windows.Forms.Button btnEnd;
	}
}

