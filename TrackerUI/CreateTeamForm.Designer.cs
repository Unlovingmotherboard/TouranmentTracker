﻿namespace TrackerUI
{
	partial class CreateTeamForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTeamForm));
			this.headerLabel = new System.Windows.Forms.Label();
			this.teamNameValue = new System.Windows.Forms.TextBox();
			this.teamNameLabel = new System.Windows.Forms.Label();
			this.addTeamMemberButton = new System.Windows.Forms.Button();
			this.selectTeamMemberDropDown = new System.Windows.Forms.ComboBox();
			this.selectTeamMemberLabel = new System.Windows.Forms.Label();
			this.addNewMemberGroupBox = new System.Windows.Forms.GroupBox();
			this.createMemberButton = new System.Windows.Forms.Button();
			this.cellPhoneValue = new System.Windows.Forms.TextBox();
			this.cellphoneLabel = new System.Windows.Forms.Label();
			this.emailValue = new System.Windows.Forms.TextBox();
			this.emailLabel = new System.Windows.Forms.Label();
			this.lastNameValue = new System.Windows.Forms.TextBox();
			this.lastNameLabel = new System.Windows.Forms.Label();
			this.firstNameValue = new System.Windows.Forms.TextBox();
			this.firstNameLabel = new System.Windows.Forms.Label();
			this.teamMembersListBox = new System.Windows.Forms.ListBox();
			this.removeSelectedMemberButton = new System.Windows.Forms.Button();
			this.createTeamButton = new System.Windows.Forms.Button();
			this.addNewMemberGroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// headerLabel
			// 
			this.headerLabel.AutoSize = true;
			this.headerLabel.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.headerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.headerLabel.Location = new System.Drawing.Point(13, 9);
			this.headerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.headerLabel.Name = "headerLabel";
			this.headerLabel.Size = new System.Drawing.Size(223, 50);
			this.headerLabel.TabIndex = 2;
			this.headerLabel.Text = "Create Team";
			// 
			// teamNameValue
			// 
			this.teamNameValue.Location = new System.Drawing.Point(22, 92);
			this.teamNameValue.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.teamNameValue.Name = "teamNameValue";
			this.teamNameValue.Size = new System.Drawing.Size(305, 22);
			this.teamNameValue.TabIndex = 12;
			// 
			// teamNameLabel
			// 
			this.teamNameLabel.AutoSize = true;
			this.teamNameLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.teamNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.teamNameLabel.Location = new System.Drawing.Point(17, 59);
			this.teamNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.teamNameLabel.Name = "teamNameLabel";
			this.teamNameLabel.Size = new System.Drawing.Size(124, 30);
			this.teamNameLabel.TabIndex = 11;
			this.teamNameLabel.Text = "Team Name";
			// 
			// addTeamMemberButton
			// 
			this.addTeamMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
			this.addTeamMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
			this.addTeamMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
			this.addTeamMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.addTeamMemberButton.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.addTeamMemberButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.addTeamMemberButton.Location = new System.Drawing.Point(52, 231);
			this.addTeamMemberButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.addTeamMemberButton.Name = "addTeamMemberButton";
			this.addTeamMemberButton.Size = new System.Drawing.Size(237, 58);
			this.addTeamMemberButton.TabIndex = 20;
			this.addTeamMemberButton.Text = "Add Member";
			this.addTeamMemberButton.UseVisualStyleBackColor = true;
			this.addTeamMemberButton.Click += new System.EventHandler(this.addTeamMemberButton_Click);
			// 
			// selectTeamMemberDropDown
			// 
			this.selectTeamMemberDropDown.FormattingEnabled = true;
			this.selectTeamMemberDropDown.Location = new System.Drawing.Point(18, 170);
			this.selectTeamMemberDropDown.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.selectTeamMemberDropDown.Name = "selectTeamMemberDropDown";
			this.selectTeamMemberDropDown.Size = new System.Drawing.Size(309, 21);
			this.selectTeamMemberDropDown.TabIndex = 19;
			// 
			// selectTeamMemberLabel
			// 
			this.selectTeamMemberLabel.AutoSize = true;
			this.selectTeamMemberLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.selectTeamMemberLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.selectTeamMemberLabel.Location = new System.Drawing.Point(18, 137);
			this.selectTeamMemberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.selectTeamMemberLabel.Name = "selectTeamMemberLabel";
			this.selectTeamMemberLabel.Size = new System.Drawing.Size(207, 30);
			this.selectTeamMemberLabel.TabIndex = 18;
			this.selectTeamMemberLabel.Text = "Select Team Member";
			// 
			// addNewMemberGroupBox
			// 
			this.addNewMemberGroupBox.Controls.Add(this.createMemberButton);
			this.addNewMemberGroupBox.Controls.Add(this.cellPhoneValue);
			this.addNewMemberGroupBox.Controls.Add(this.cellphoneLabel);
			this.addNewMemberGroupBox.Controls.Add(this.emailValue);
			this.addNewMemberGroupBox.Controls.Add(this.emailLabel);
			this.addNewMemberGroupBox.Controls.Add(this.lastNameValue);
			this.addNewMemberGroupBox.Controls.Add(this.lastNameLabel);
			this.addNewMemberGroupBox.Controls.Add(this.firstNameValue);
			this.addNewMemberGroupBox.Controls.Add(this.firstNameLabel);
			this.addNewMemberGroupBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.addNewMemberGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.addNewMemberGroupBox.Location = new System.Drawing.Point(22, 318);
			this.addNewMemberGroupBox.Name = "addNewMemberGroupBox";
			this.addNewMemberGroupBox.Size = new System.Drawing.Size(305, 294);
			this.addNewMemberGroupBox.TabIndex = 21;
			this.addNewMemberGroupBox.TabStop = false;
			this.addNewMemberGroupBox.Text = "Add New Member";
			// 
			// createMemberButton
			// 
			this.createMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
			this.createMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
			this.createMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
			this.createMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.createMemberButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.createMemberButton.Location = new System.Drawing.Point(56, 219);
			this.createMemberButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.createMemberButton.Name = "createMemberButton";
			this.createMemberButton.Size = new System.Drawing.Size(176, 43);
			this.createMemberButton.TabIndex = 22;
			this.createMemberButton.Text = "Create Member";
			this.createMemberButton.UseVisualStyleBackColor = true;
			this.createMemberButton.Click += new System.EventHandler(this.createMemberButton_Click);
			// 
			// cellPhoneValue
			// 
			this.cellPhoneValue.Location = new System.Drawing.Point(138, 168);
			this.cellPhoneValue.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.cellPhoneValue.Name = "cellPhoneValue";
			this.cellPhoneValue.Size = new System.Drawing.Size(129, 35);
			this.cellPhoneValue.TabIndex = 29;
			// 
			// cellphoneLabel
			// 
			this.cellphoneLabel.AutoSize = true;
			this.cellphoneLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cellphoneLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.cellphoneLabel.Location = new System.Drawing.Point(17, 160);
			this.cellphoneLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.cellphoneLabel.Name = "cellphoneLabel";
			this.cellphoneLabel.Size = new System.Drawing.Size(106, 30);
			this.cellphoneLabel.TabIndex = 28;
			this.cellphoneLabel.Text = "Cellphone";
			// 
			// emailValue
			// 
			this.emailValue.Location = new System.Drawing.Point(138, 129);
			this.emailValue.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.emailValue.Name = "emailValue";
			this.emailValue.Size = new System.Drawing.Size(129, 35);
			this.emailValue.TabIndex = 27;
			// 
			// emailLabel
			// 
			this.emailLabel.AutoSize = true;
			this.emailLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.emailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.emailLabel.Location = new System.Drawing.Point(17, 121);
			this.emailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.emailLabel.Name = "emailLabel";
			this.emailLabel.Size = new System.Drawing.Size(63, 30);
			this.emailLabel.TabIndex = 26;
			this.emailLabel.Text = "Email";
			// 
			// lastNameValue
			// 
			this.lastNameValue.Location = new System.Drawing.Point(138, 90);
			this.lastNameValue.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.lastNameValue.Name = "lastNameValue";
			this.lastNameValue.Size = new System.Drawing.Size(129, 35);
			this.lastNameValue.TabIndex = 25;
			// 
			// lastNameLabel
			// 
			this.lastNameLabel.AutoSize = true;
			this.lastNameLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lastNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.lastNameLabel.Location = new System.Drawing.Point(17, 82);
			this.lastNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lastNameLabel.Name = "lastNameLabel";
			this.lastNameLabel.Size = new System.Drawing.Size(112, 30);
			this.lastNameLabel.TabIndex = 24;
			this.lastNameLabel.Text = "Last Name";
			// 
			// firstNameValue
			// 
			this.firstNameValue.Location = new System.Drawing.Point(138, 51);
			this.firstNameValue.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.firstNameValue.Name = "firstNameValue";
			this.firstNameValue.Size = new System.Drawing.Size(129, 35);
			this.firstNameValue.TabIndex = 23;
			// 
			// firstNameLabel
			// 
			this.firstNameLabel.AutoSize = true;
			this.firstNameLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.firstNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.firstNameLabel.Location = new System.Drawing.Point(17, 43);
			this.firstNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.firstNameLabel.Name = "firstNameLabel";
			this.firstNameLabel.Size = new System.Drawing.Size(113, 30);
			this.firstNameLabel.TabIndex = 22;
			this.firstNameLabel.Text = "First Name";
			// 
			// teamMembersListBox
			// 
			this.teamMembersListBox.FormattingEnabled = true;
			this.teamMembersListBox.Location = new System.Drawing.Point(374, 59);
			this.teamMembersListBox.Name = "teamMembersListBox";
			this.teamMembersListBox.Size = new System.Drawing.Size(309, 563);
			this.teamMembersListBox.TabIndex = 22;
			// 
			// removeSelectedMemberButton
			// 
			this.removeSelectedMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
			this.removeSelectedMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
			this.removeSelectedMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
			this.removeSelectedMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.removeSelectedMemberButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.removeSelectedMemberButton.Location = new System.Drawing.Point(704, 354);
			this.removeSelectedMemberButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.removeSelectedMemberButton.Name = "removeSelectedMemberButton";
			this.removeSelectedMemberButton.Size = new System.Drawing.Size(150, 37);
			this.removeSelectedMemberButton.TabIndex = 23;
			this.removeSelectedMemberButton.Text = "Remove Selected";
			this.removeSelectedMemberButton.UseVisualStyleBackColor = true;
			this.removeSelectedMemberButton.Click += new System.EventHandler(this.removeSelectedMemberButton_Click);
			// 
			// createTeamButton
			// 
			this.createTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
			this.createTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
			this.createTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
			this.createTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.createTeamButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.createTeamButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.createTeamButton.Location = new System.Drawing.Point(276, 673);
			this.createTeamButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.createTeamButton.Name = "createTeamButton";
			this.createTeamButton.Size = new System.Drawing.Size(237, 91);
			this.createTeamButton.TabIndex = 26;
			this.createTeamButton.Text = "Create Team";
			this.createTeamButton.UseVisualStyleBackColor = true;
			this.createTeamButton.Click += new System.EventHandler(this.createTeamButton_Click);
			// 
			// CreateTeamForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Snow;
			this.ClientSize = new System.Drawing.Size(867, 776);
			this.Controls.Add(this.createTeamButton);
			this.Controls.Add(this.removeSelectedMemberButton);
			this.Controls.Add(this.teamMembersListBox);
			this.Controls.Add(this.addNewMemberGroupBox);
			this.Controls.Add(this.addTeamMemberButton);
			this.Controls.Add(this.selectTeamMemberDropDown);
			this.Controls.Add(this.selectTeamMemberLabel);
			this.Controls.Add(this.teamNameValue);
			this.Controls.Add(this.teamNameLabel);
			this.Controls.Add(this.headerLabel);
			this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "CreateTeamForm";
			this.Text = "Create Team";
			this.addNewMemberGroupBox.ResumeLayout(false);
			this.addNewMemberGroupBox.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label headerLabel;
		private System.Windows.Forms.TextBox teamNameValue;
		private System.Windows.Forms.Label teamNameLabel;
		private System.Windows.Forms.Button addTeamMemberButton;
		private System.Windows.Forms.ComboBox selectTeamMemberDropDown;
		private System.Windows.Forms.Label selectTeamMemberLabel;
		private System.Windows.Forms.GroupBox addNewMemberGroupBox;
		private System.Windows.Forms.Button createMemberButton;
		private System.Windows.Forms.TextBox cellPhoneValue;
		private System.Windows.Forms.Label cellphoneLabel;
		private System.Windows.Forms.TextBox emailValue;
		private System.Windows.Forms.Label emailLabel;
		private System.Windows.Forms.TextBox lastNameValue;
		private System.Windows.Forms.Label lastNameLabel;
		private System.Windows.Forms.TextBox firstNameValue;
		private System.Windows.Forms.Label firstNameLabel;
		private System.Windows.Forms.ListBox teamMembersListBox;
		private System.Windows.Forms.Button removeSelectedMemberButton;
		private System.Windows.Forms.Button createTeamButton;
	}
}