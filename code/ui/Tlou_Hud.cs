using System.Collections.Generic;
using Sandbox;
using Sandbox.ui;
using Sandbox.UI;
using Sandbox.ui.character;
using Sandbox.Utils;

[Library]
public partial class Tlou_Hud : HudEntity<RootPanel>
{
	private Form form { get; set; }
	public Tlou_Hud()
	{
		if ( !IsClient )
			return;
		
		RootPanel.StyleSheet.Load( $"{DirPath.GetUiPath()}/Tlou_Hud.scss" );
		
		// TODO - REMPLACER LE PANEL PAR FACTION_SELECTION
		var factionSelection = RootPanel.AddChild<FactionSelection>();
	}
}
