namespace Sandbox;

public class Srv_Commands
{
	[ServerCmd( "/infos" )]
	public static void Infos()
	{
		var character = ConsoleSystem.Caller.Pawn as Character;
		if ( character == null ) return;
		
		Log.Info( character.GetName() );
		Log.Info( character.GetDesc() );
		Log.Info( character.GetFaction() );
	}

	[ServerCmd( "/getfaction" )]
	public static void Factions()
	{
		var character = Local.Client.Pawn as Character;
		if ( character == null )
			return;
		Log.Info( character.GetFaction() );
	}
}
