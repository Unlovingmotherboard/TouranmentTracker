using System;
using System.Collections.Generic;
using System.Text;
using TrackerLibary.Models;

namespace TrackerLibary.DataAccess
{
	public interface IDataConnection
	{
		PrizeModel CreatePrize(PrizeModel model);
		PersonModel CreatePerson(PersonModel model);
		List<PersonModel> GetPerson_All();
		TeamModel CreateTeam(TeamModel model);
	}
}
