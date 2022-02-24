namespace Sandbox.factions;

public class Fireflies : Faction
{
	public Fireflies()
	{
		SetName( "Lucioles" );
		SetDesc( "Vous faites parti d'un groupe armé qui croit en la création d'un vaccin au Cordycèps" );
		SetBackground( "assets/images/tlou_fireflies.png" );
		SetUniqueId( "FACTION_FIREFLIES" );
		AddModel( "models/citizen/citizen.vmdl" );
	}
}
