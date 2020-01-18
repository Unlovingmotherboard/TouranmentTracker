﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibary.Models
{
	/// <summary>
	/// Represents the a team.
	/// </summary>
	public class TeamModel
	{
		/// <summary>
		/// Represents a list of persons in the team
		/// </summary>
		public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();

		/// <summary>
		/// The name of the team
		/// </summary>
		public string TeamName { get; set; }
	}
}
