using Sandbox;
using Sandbox.factions;

public partial class Character : Player
{
	[Net] private string name { get; set; }
	[Net] private string description { get; set; }
	[Net] public int health { get; set; }
	[Net] public Faction faction { get; set; }

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

	#endregion
}
