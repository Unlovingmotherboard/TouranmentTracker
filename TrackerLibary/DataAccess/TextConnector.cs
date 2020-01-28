﻿using System;
using System.Collections.Generic;
using System.Text;
using TrackerLibary.Models;
using TrackerLibary.DataAccess.TextHelpers;
using System.Linq;

namespace TrackerLibary.DataAccess
{
	public class TextConnector : IDataConnection
	{

		private const string PrizesFile = "PrizeModels.csv";

		public PersonModel CreatePerson(PersonModel model)
		{
			throw new NotImplementedException();
		}

		// TODO - Wire up the CreatePrize for text files.
		public PrizeModel CreatePrize(PrizeModel model)
		{
			// Load the text file and Convert the text to List<PrizeModel>
			List<PrizeModel> prizes = PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModels();

			// Find the max ID
			int currentId = 1;

			if (prizes.Count > 0)
			{
				currentId = prizes.OrderByDescending(x => x.Id).First().Id + 1;
			}

			model.Id = currentId;

			// Add the new record with the new ID
			prizes.Add(model);

			// Convert the prizes to List<string>
			// Save the List<string> to the text file
			prizes.SaveToPrizeFile(PrizesFile);

			return model;
		}

		public List<PersonModel> GetPerson_All()
		{
			throw new NotImplementedException();
		}
	}
}
