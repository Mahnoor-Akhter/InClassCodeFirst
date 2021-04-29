using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClassCodeFirst
{
	public class Team
	{
		public int TeamID { get; set; }

		public string TeamName { get; set; }

		public string Location { get; set; }
		public string HomeGround { get; set; }
		public virtual List<Player> Players { get; set; }
	}//end of class

	public class Player
	{
		public  int PlayerID { get; set; }

		public string Name { get; set; }

		public string Position { get; set; }

public int TeamID { get; set; }
		public virtual Team Team { get; set; }

	}


	public class TeamData:DbContext
	{
		public TeamData(): base("MyTeamData") { }//give db it's name

		public DbSet<Player> Players { get; set; }//creartes Player table

		public DbSet<Team> Teams { get; set; }//creats teams table

	}
	

}
