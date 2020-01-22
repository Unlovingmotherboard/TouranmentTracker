using System;
using System.Collections.Generic;
using System.Text;
using TrackerLibary.Models;
using TrackerLibary.DataAccess.TextHelpers;

namespace TrackerLibary.DataAccess
{
	public class TextConnector : IDataConnection
	{
		// TODO - Wire up the CreatePrize for text files.
		public PrizeModel CreatePrize(PrizeModel model)
		{
			// Load the text file
			// Convert the text to List<PrizeModel>
			// Find the ID
			// Add the new record with the new ID
			// Convert the prizes to List<string>
			// Save the List<string> to the text file

		}
	}
}
