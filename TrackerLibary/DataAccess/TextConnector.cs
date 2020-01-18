using System;
using System.Collections.Generic;
using System.Text;
using TrackerLibary.Models;

namespace TrackerLibary.DataAccess
{
	public class TextConnector : IDataConnection
	{
		// TODO - Wire up the CreatePrize for text files.
		public PrizeModel CreatePrize(PrizeModel model)
		{
			model.Id = 1;

			return model;
		}
	}
}
