﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibary
{
	public class TeamModel
	{
		public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();
		public string TeamName { get; set; }
	}
}
