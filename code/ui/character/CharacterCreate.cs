using System.Collections.Generic;
using Sandbox.UI;

namespace Sandbox.ui.character;

public class CharacterCreate : Panel
{
	public CharacterCreate()
	{
		// TODO
		
		var ImageBg = new ModulableImage( "/assets/images/BgCharCreate.png",
			new Styles()
			{
				Position = PositionMode.Absolute,
				Height = Length.Parse( "100vh" ),
				Width = Length.Parse( "100vw" ),
				BackgroundRepeat = BackgroundRepeat.NoRepeat,
				ZIndex = 1
			} );

		var Container = new ModulableScreen( null, null, new Styles()
		{
			Height = Length.Percent( 100 ),
			Width = Length.Percent( 100 ),
			MinHeight = Length.Parse( "100vh" ),
			Position = PositionMode.Absolute,
			BackgroundColor = Color.Red,
			ZIndex = 2
		} );
		
		var ChNameEntry = new ModulableTextEntry( "Nom...", null, new Styles()
		{
			Height = Length.Parse( "30vh" ),
			Width = Length.Parse( "50vw" )
		}, null );
		
		Container.AddChild( ChNameEntry );
		AddChild( ImageBg );
		AddChild( Container );
	}
}
