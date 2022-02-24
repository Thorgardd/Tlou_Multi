using System.Collections.Generic;

namespace Sandbox.factions;

public abstract class Faction
{
	private string name { get; set; }
	private string description { get; set; }
	private string background { get; set; }
	private string uniqueId { get; set; }
	private List<string> models = new List<string>();

	#region Get / Set

	public string GetName()
	{
		return name;
	}

	public void SetName( string value )
	{
		name = value;
	}

	public string GetDesc()
	{
		return description;
	}

	public void SetDesc(string value)
	{
		description = value;
	}

	public string GetBackground()
	{
		return background;
	}

	public void SetBackground(string value)
	{
		background = value;
	}

	public string GetUniqueId()
	{
		return uniqueId;
	}

	public void SetUniqueId( string value )
	{
		uniqueId = value;
	}

	protected Faction AddModel(string model)
	{
		this.models.Add( model );
		return this;
	}

	public List<string> GetModels()
	{
		return this.models;
	}

	#endregion
}
