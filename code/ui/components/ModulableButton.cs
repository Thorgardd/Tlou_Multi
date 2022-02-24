using Sandbox;
using Sandbox.DataModel;
using Sandbox.UI;
using Sandbox.UI.Construct;
using System;

public class ModulableButton : BaseButton
{
	public ModulableButton(
		string text,
		Action onClick = null,
		Styles styles = null
	) : base(text, onClick, styles)
	{
		
	}
}
