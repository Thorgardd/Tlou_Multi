using Sandbox;
using System;
using System.Linq;
using Sandbox.UI;
using Sandbox.ui.character;

namespace Sandbox
{
	public partial class TlouGame : Game
	{
		private Tlou_Hud Tlou_Hud;
		
		public TlouGame()
		{
			if ( IsServer )
			{
				Tlou_Hud = new Tlou_Hud();
				// Do not delete me on map cleanup
				Tlou_Hud.Parent = this;
			}
		}
        
        
		/// <summary>
		/// Event called when a client join the server
		/// </summary>
		/// <param name="client">Client</param>
		public override void ClientJoined( Client client )
		{
			base.ClientJoined( client );
			var player = new Character( client, "Eren Jäger", "Best Titan we've ever known" );
			client.Pawn = player;
    
			// Get all of the spawnpoints
			var spawnpoints = Entity.All.OfType<SpawnPoint>();
    
			// chose a random one
			var randomSpawnPoint = spawnpoints.OrderBy( x => Guid.NewGuid() ).FirstOrDefault();
    
			// if it exists, place the pawn there
			if ( randomSpawnPoint != null )
			{
				var tx = randomSpawnPoint.Transform;
				tx.Position = tx.Position + Vector3.Up * 50.0f; // raise it up
				client.Pawn.Transform = tx;
			}
    			
			player.Respawn();
		}
    	
    	
		/// <summary>
		/// Event called when a player do noclip
		/// </summary>
		/// <param name="player">Client Entity</param>
		public override void DoPlayerNoclip( Client player )
		{
			if ( player.Pawn is Player basePlayer )
			{
				if ( basePlayer.DevController is NoclipController )
				{
					Log.Info( "Noclip Mode Off" );
					basePlayer.DevController = null;
				}
				else
				{
					Log.Info( "Noclip Mode On" );
					basePlayer.DevController = new NoclipController();
				}
			}
		}
	}
}
