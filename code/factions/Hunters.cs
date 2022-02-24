namespace Sandbox.factions;

public partial class Hunters : Faction
{
	public Hunters()
	{
		SetName( "Chasseurs" );
		SetDesc( "Vous faites parti des chasseurs qui luttent en clan pour survivre dans ce monde semé de mort." );
		SetBackground( "assets/images/tlou_hunters.png" );
		SetUniqueId( "FACTION_HUNTERS" );
		AddModel( "models/citizen/citizen.vmdl" );
	}
}
