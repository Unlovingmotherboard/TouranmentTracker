using System;
using System.Collections.Generic;
using System.Text;
using TrackerLibary.Models;

namespace TrackerLibary.DataAccess
{
	public interface IDataConnection
	{
		PrizeModel CreatePrize(PrizeModel model);
	}
}
