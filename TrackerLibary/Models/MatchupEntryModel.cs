using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibary.Models
{
	public class MatchupEntryModel
	{
		/// <summary>
		/// Represents: one team in the matchup.
		/// </summary>
		public TeamModel TeamCompeting { get; set; }

		/// <summary>
		/// Represents the score for this particular team.
		/// </summary>
		public double Score { get; set; }

		/// <summary>
		/// Represents the matchup that this team came.
		/// from the winner
		/// </summary>
		public MatchupModel ParentMatchup { get; set; }

		/// <summary>
		/// Can document here
		/// </summary>
		/// <param name="initialScore">
		/// And document here for the parameter.
		/// </param>
		public MatchupEntryModel(double initialScore)
		{
			Console.WriteLine();
		}
	}
}
