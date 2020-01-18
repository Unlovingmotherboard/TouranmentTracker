using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Dapper;
using TrackerLibary.Models;

	//@PlaceNumber int,
	//@PlaceName nvarchar(100),
	//@PrizeAmount money,
	//@PrizePercentage float,
	//@id int = 0 output

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
			using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Tournaments")))
			{
				var p = new DynamicParameters();
				p.Add("@PlaceNumber", model.PlaceNumber);
				p.Add("@PlaceName", model.PlaceName);
				p.Add("@PrizeAmount", model.PriceAmount);
				p.Add("@PrizePercentage", model.PrizePercentage);
				p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

				connection.Execute("dbo.spPrizes_Insert", p, commandType: CommandType.StoredProcedure);

				model.Id = p.Get<int>("@id");

				return model;
			}
		}
	}
}
