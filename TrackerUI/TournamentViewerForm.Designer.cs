namespace TrackerUI
{
	partial class TournamentViewerForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TournamentViewerForm));
			this.headerLabel = new System.Windows.Forms.Label();
			this.tournamentName = new System.Windows.Forms.Label();
			this.roundLabel = new System.Windows.Forms.Label();
			this.roundDropDown = new System.Windows.Forms.ComboBox();
			this.unplayedOnlyCheckbox = new System.Windows.Forms.CheckBox();
			this.matchupListBox = new System.Windows.Forms.ListBox();
			this.teamOneName = new System.Windows.Forms.Label();
			this.teamOneScoreLabel = new System.Windows.Forms.Label();
			this.teamOneScoreValue = new System.Windows.Forms.TextBox();
			this.teamTwoScoreValue = new System.Windows.Forms.TextBox();
			this.teamTwoScoreLabel = new System.Windows.Forms.Label();
			this.teamTwoName = new System.Windows.Forms.Label();
			this.versusLabel = new System.Windows.Forms.Label();
			this.scoreButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// headerLabel
			// 
			this.headerLabel.AutoSize = true;
			this.headerLabel.Font = new System.Drawing.Font("Candara Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.headerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.headerLabel.Location = new System.Drawing.Point(11, 10);
			this.headerLabel.Name = "headerLabel";
			this.headerLabel.Size = new System.Drawing.Size(218, 45);
			this.headerLabel.TabIndex = 0;
			this.headerLabel.Text = "Tournament:";
			this.headerLabel.Click += new System.EventHandler(this.label1_Click);
			// 
			// tournamentName
			// 
			this.tournamentName.AutoSize = true;
			this.tournamentName.Font = new System.Drawing.Font("Candara Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tournamentName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.tournamentName.Location = new System.Drawing.Point(216, 10);
			this.tournamentName.Name = "tournamentName";
			this.tournamentName.Size = new System.Drawing.Size(138, 45);
			this.tournamentName.TabIndex = 1;
			this.tournamentName.Text = "<none>";
			this.tournamentName.Click += new System.EventHandler(this.label1_Click_1);
			// 
			// roundLabel
			// 
			this.roundLabel.AutoSize = true;
			this.roundLabel.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.roundLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.roundLabel.Location = new System.Drawing.Point(15, 118);
			this.roundLabel.Name = "roundLabel";
			this.roundLabel.Size = new System.Drawing.Size(71, 26);
			this.roundLabel.TabIndex = 2;
			this.roundLabel.Text = "Round";
			// 
			// roundDropDown
			// 
			this.roundDropDown.FormattingEnabled = true;
			this.roundDropDown.Location = new System.Drawing.Point(92, 115);
			this.roundDropDown.Name = "roundDropDown";
			this.roundDropDown.Size = new System.Drawing.Size(262, 34);
			this.roundDropDown.TabIndex = 3;
			// 
			// unplayedOnlyCheckbox
			// 
			this.unplayedOnlyCheckbox.AutoSize = true;
			this.unplayedOnlyCheckbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.unplayedOnlyCheckbox.Font = new System.Drawing.Font("Candara", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.unplayedOnlyCheckbox.Location = new System.Drawing.Point(92, 167);
			this.unplayedOnlyCheckbox.Name = "unplayedOnlyCheckbox";
			this.unplayedOnlyCheckbox.Size = new System.Drawing.Size(199, 37);
			this.unplayedOnlyCheckbox.TabIndex = 4;
			this.unplayedOnlyCheckbox.Text = "Unplayed Only";
			this.unplayedOnlyCheckbox.UseVisualStyleBackColor = true;
			// 
			// matchupListBox
			// 
			this.matchupListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.matchupListBox.FormattingEnabled = true;
			this.matchupListBox.ItemHeight = 26;
			this.matchupListBox.Location = new System.Drawing.Point(19, 234);
			this.matchupListBox.Name = "matchupListBox";
			this.matchupListBox.Size = new System.Drawing.Size(335, 340);
			this.matchupListBox.TabIndex = 5;
			// 
			// teamOneName
			// 
			this.teamOneName.AutoSize = true;
			this.teamOneName.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.teamOneName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.teamOneName.Location = new System.Drawing.Point(402, 175);
			this.teamOneName.Name = "teamOneName";
			this.teamOneName.Size = new System.Drawing.Size(119, 26);
			this.teamOneName.TabIndex = 6;
			this.teamOneName.Text = "<team one>";
			// 
			// teamOneScoreLabel
			// 
			this.teamOneScoreLabel.AutoSize = true;
			this.teamOneScoreLabel.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.teamOneScoreLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.teamOneScoreLabel.Location = new System.Drawing.Point(402, 234);
			this.teamOneScoreLabel.Name = "teamOneScoreLabel";
			this.teamOneScoreLabel.Size = new System.Drawing.Size(62, 26);
			this.teamOneScoreLabel.TabIndex = 7;
			this.teamOneScoreLabel.Text = "Score";
			// 
			// teamOneScoreValue
			// 
			this.teamOneScoreValue.Location = new System.Drawing.Point(470, 231);
			this.teamOneScoreValue.Name = "teamOneScoreValue";
			this.teamOneScoreValue.Size = new System.Drawing.Size(100, 33);
			this.teamOneScoreValue.TabIndex = 8;
			// 
			// teamTwoScoreValue
			// 
			this.teamTwoScoreValue.Location = new System.Drawing.Point(470, 444);
			this.teamTwoScoreValue.Name = "teamTwoScoreValue";
			this.teamTwoScoreValue.Size = new System.Drawing.Size(100, 33);
			this.teamTwoScoreValue.TabIndex = 11;
			// 
			// teamTwoScoreLabel
			// 
			this.teamTwoScoreLabel.AutoSize = true;
			this.teamTwoScoreLabel.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.teamTwoScoreLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.teamTwoScoreLabel.Location = new System.Drawing.Point(402, 447);
			this.teamTwoScoreLabel.Name = "teamTwoScoreLabel";
			this.teamTwoScoreLabel.Size = new System.Drawing.Size(62, 26);
			this.teamTwoScoreLabel.TabIndex = 10;
			this.teamTwoScoreLabel.Text = "Score";
			// 
			// teamTwoName
			// 
			this.teamTwoName.AutoSize = true;
			this.teamTwoName.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.teamTwoName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.teamTwoName.Location = new System.Drawing.Point(402, 388);
			this.teamTwoName.Name = "teamTwoName";
			this.teamTwoName.Size = new System.Drawing.Size(121, 26);
			this.teamTwoName.TabIndex = 9;
			this.teamTwoName.Text = "<team two>";
			// 
			// versusLabel
			// 
			this.versusLabel.AutoSize = true;
			this.versusLabel.Font = new System.Drawing.Font("Candara", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.versusLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.versusLabel.Location = new System.Drawing.Point(451, 304);
			this.versusLabel.Name = "versusLabel";
			this.versusLabel.Size = new System.Drawing.Size(72, 42);
			this.versusLabel.TabIndex = 12;
			this.versusLabel.Text = "-VS-";
			// 
			// scoreButton
			// 
			this.scoreButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
			this.scoreButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
			this.scoreButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
			this.scoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.scoreButton.Location = new System.Drawing.Point(606, 305);
			this.scoreButton.Name = "scoreButton";
			this.scoreButton.Size = new System.Drawing.Size(117, 50);
			this.scoreButton.TabIndex = 13;
			this.scoreButton.Text = "Score";
			this.scoreButton.UseVisualStyleBackColor = true;
			// 
			// TournamentViewerForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 26F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Snow;
			this.ClientSize = new System.Drawing.Size(828, 889);
			this.Controls.Add(this.scoreButton);
			this.Controls.Add(this.versusLabel);
			this.Controls.Add(this.teamTwoScoreValue);
			this.Controls.Add(this.teamTwoScoreLabel);
			this.Controls.Add(this.teamTwoName);
			this.Controls.Add(this.teamOneScoreValue);
			this.Controls.Add(this.teamOneScoreLabel);
			this.Controls.Add(this.teamOneName);
			this.Controls.Add(this.matchupListBox);
			this.Controls.Add(this.unplayedOnlyCheckbox);
			this.Controls.Add(this.roundDropDown);
			this.Controls.Add(this.roundLabel);
			this.Controls.Add(this.tournamentName);
			this.Controls.Add(this.headerLabel);
			this.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.Name = "TournamentViewerForm";
			this.Text = "Tournament Viewer";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label headerLabel;
		private System.Windows.Forms.Label tournamentName;
		private System.Windows.Forms.Label roundLabel;
		private System.Windows.Forms.ComboBox roundDropDown;
		private System.Windows.Forms.CheckBox unplayedOnlyCheckbox;
		private System.Windows.Forms.ListBox matchupListBox;
		private System.Windows.Forms.Label teamOneName;
		private System.Windows.Forms.Label teamOneScoreLabel;
		private System.Windows.Forms.TextBox teamOneScoreValue;
		private System.Windows.Forms.TextBox teamTwoScoreValue;
		private System.Windows.Forms.Label teamTwoScoreLabel;
		private System.Windows.Forms.Label teamTwoName;
		private System.Windows.Forms.Label versusLabel;
		private System.Windows.Forms.Button scoreButton;
	}
}

