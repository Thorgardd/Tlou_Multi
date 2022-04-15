using Sandbox;
using Sandbox.factions;

public partial class Character : Player
{
	[Net] private string name { get; set; }
	[Net] private string description { get; set; }
	[Net] private int health { get; set; }
	[Net] private Faction faction { get; set; }
	private Entity Pawn;

	/// <summary>
	/// Default init
	/// </summary>
	public Character()
	{
		/* Default inventory bar on HUD */
		Inventory = new Inventory( this );
		health = 100;
	}

	/// <summary>
	/// Initialize using this client
	/// </summary>
	public Character( Client cl, string name, string description ) : this()
	{
		// Load clothing from client data
		Clothing.LoadFromClient( cl );

		this.name = name;
		this.description = description;
	}
	
	

	#region Getter / Setter

	public string GetName()
	{
		return name;
	}

	public void SetName( string nameParam )
	{
		name = nameParam;
	}

	public string GetDesc()
	{
		return description;
	}

	public void SetDesc( string descParam )
	{
		description = descParam;
	}

	public int GetHealth()
	{
		return health;
	}

	public void SetHealth(int healthParam)
	{
		health = healthParam;
	}

	public Faction GetFaction()
	{
		return faction;
	}

	public void SetFaction( Faction factionParam )
	{
		faction = factionParam;
	}
	
	public void SetPawn(Entity pawnParam)
	{
		Pawn = pawnParam;
	}
	public Entity GetPawn()
	{
		return Pawn;
	}

	#endregion
}
