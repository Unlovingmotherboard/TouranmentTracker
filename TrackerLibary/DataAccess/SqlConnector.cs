using System;
using System.Collections.Generic;
using System.Text;
using TrackerLibary.Models;

namespace TrackerLibary.DataAccess
{
	public class SqlConnector : IDataConnection
	{
		// TODO - Make the CreatePrize method actually save to the database.
		/// <summary>
		/// Saves a new prize to the database.
		/// </summary>
		/// <param name="model">the prize information</param>
		/// <returns>The prize information, including the unqie indetifier.</returns>
		public PrizeModel CreatePrize(PrizeModel model)
		{
			model.Id = 1;

			return model;
		}
	}
}
