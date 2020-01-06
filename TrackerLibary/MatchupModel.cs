﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibary
{
	public class MatchupModel
	{
		public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();

		public TeamModel Winner { get; set; }
		public int MatchupRound { get; set; }

	}
}
