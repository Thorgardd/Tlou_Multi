using Sandbox;
using Sandbox.DataModel;
using Sandbox.UI;
using System.Collections.Generic;

public class ModulableTextEntry : BaseTextEntry
{
	private string Name { get; set; }
	public ModulableTextEntry(
		string placeholder = "",
		string name = "",
		Styles styles = null,
		List<Rule> rules = null
	) : base(name, styles, rules)
	{
		Placeholder = placeholder;
	}
}
