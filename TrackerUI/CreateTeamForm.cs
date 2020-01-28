﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibary;
using TrackerLibary.Models;

namespace TrackerUI
{
	public partial class CreateTeamForm : Form
	{

		private List<PersonModel> availableTeamMembers = GlobalConfig.Connection.GetPerson_All();
		private List<PersonModel> selectedTeamMembers = new List<PersonModel>();

		public CreateTeamForm()
		{
			InitializeComponent();

			//Creating sample data. Replace this with a connection to DB.
			//CreateSampleData();

			//This adds the data to the form
			WireUpLists();
		}

		private void CreateSampleData()
		{
			availableTeamMembers.Add(new PersonModel { FirstName = "Jose", LastName = "HernandeZ" });
			availableTeamMembers.Add(new PersonModel { FirstName = "Shayla", LastName = "Young" });

			selectedTeamMembers.Add(new PersonModel { FirstName = "Jane", LastName = "Smoth" });
			selectedTeamMembers.Add(new PersonModel { FirstName = "Bill", LastName = "Jones" });
		}

		public void WireUpLists()
		{
			selectTeamMemberDropDown.DataSource = null;
			selectTeamMemberDropDown.DataSource = availableTeamMembers;
			selectTeamMemberDropDown.DisplayMember = "FullName";

			teamMembersListBox.DataSource = null;
			teamMembersListBox.DataSource = selectedTeamMembers;
			teamMembersListBox.DisplayMember = "FullName";
		}

		private void createMemberButton_Click(object sender, EventArgs e)
		{
			if (ValidateForm())
			{
				PersonModel p = new PersonModel();

				p.FirstName = firstNameValue.Text;
				p.LastName = lastNameValue.Text;
				p.EmailAddress = emailValue.Text;
				p.CellphoneNumber = cellPhoneValue.Text;

				p = GlobalConfig.Connection.CreatePerson(p);

				selectedTeamMembers.Add(p);

				WireUpLists();

				firstNameValue.Text = "";
				lastNameValue.Text = "";
				emailValue.Text = "";
				cellPhoneValue.Text = "";
			}
			else
			{
				MessageBox.Show("You need to fill in all the fields");
			}
		}

		private bool ValidateForm()
		{
			//TODO - Add validation to the form

			if (firstNameValue.Text.Length == 0)
			{
				return false;
			}

			if (lastNameValue.Text.Length == 0)
			{
				return false;
			}

			if (emailValue.Text.Length == 0)
			{
				return false;
			}

			if (cellPhoneValue.Text.Length == 0)
			{
				return false;
			}

			return true;
		}

		private void addTeamMemberButton_Click(object sender, EventArgs e)
		{
			PersonModel p = (PersonModel)selectTeamMemberDropDown.SelectedItem;

			if (p != null)
			{
				availableTeamMembers.Remove(p);
				selectedTeamMembers.Add(p);

				WireUpLists();
			}
		}

		private void removeSelectedMemberButton_Click(object sender, EventArgs e)
		{
			PersonModel p = (PersonModel)teamMembersListBox.SelectedItem;

			if (p != null)
			{
				availableTeamMembers.Add(p);
				selectedTeamMembers.Remove(p);

				WireUpLists();
			}
		}
	}
}
