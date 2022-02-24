using Sandbox;
using Sandbox.UI;
using System.Collections.Generic;
using System;

public class Form : BasePanel
{
	private List<ModulableTextEntry> TextEntryList { get; set; }
	private List<ModulableButton> ButtonList { get; set; }

	public Form(Styles styles = null)
	{
		TextEntryList = new List<ModulableTextEntry>();
		ButtonList = new List<ModulableButton>();
		if ( styles != null )
			BuildStyle( styles );
	}

	public Form AddTextEntry(
		string placeholder = "",
		string name = "",
		Styles styles = null,
		List<Rule> rules = null
	) {
		var newTextEntry = new ModulableTextEntry( placeholder, name, styles, rules );
		AddChild(newTextEntry);
		TextEntryList.Add( newTextEntry );
		return this;
	}

	public Form AddButton(
		string text,
		Action onClick = null,
		Styles styles = null
	) {
		var newButton = new ModulableButton( text, onClick, styles );
		AddChild( newButton );
		ButtonList.Add( newButton );
		return this;
	}

	public Form AddSubmitButton( 
		string text,
		Action onClick = null,
		Styles styles = null
	) {
		var newButton = new ModulableButton( text, null, styles );
		newButton.AddEventListener("onclick", () =>
		{
			if ( onClick == null ) return;
			if ( TextEntryList.Count >= 1 )
			{
				foreach ( var textEntry in TextEntryList )
				{
					if ( textEntry.HasRule() )
					{
						if ( !textEntry.CheckRule() )
							return;
					}
				}
			}
			onClick.Invoke();
		});
		AddChild( newButton );
		ButtonList.Add( newButton );
		return this;
	}

	public Dictionary<string, string> GetAllData()
	{
		var output = new Dictionary<string, string>();
		if ( TextEntryList.Count >= 1 )
		{
			foreach ( var textEntry in TextEntryList )
			{
				output.Add( textEntry.GetName(), textEntry.Text );
			}
		}
		return output;
	}
	
	public string GetData( string name )
	{
		return "";
	}




}
