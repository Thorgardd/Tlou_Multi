using Sandbox.UI;
using Sandbox.UI.Construct;
using Sandbox;
using Sandbox.factions;

namespace Sandbox.ui.character;

public class CharCreateMenu : Panel
{
	public CharCreateMenu()
	{
		var ImageBg = new ModulableImage( "/assets/images/BgCharCreate.png",
			new Styles()
			{
				Position = PositionMode.Absolute,
				Height = Length.Parse( "100vh" ),
				Width = Length.Parse( "100vw" ),
				BackgroundRepeat = BackgroundRepeat.NoRepeat,
				ZIndex = 1
			});
		
		var blackFilter = new ModulableScreen( null, null,
			new Styles()
			{
				MinHeight = Length.Parse( "100vh" ),
				Position = PositionMode.Relative,
				Height = Length.Percent( 100 ),
				Width = Length.Percent( 100 ),
				BackgroundColor = new Color( 0,0,0, 0.8f),
				ZIndex = 2,
				PointerEvents = "all",
				Display = DisplayMode.Flex,
				JustifyContent = Justify.Center,
				AlignItems = Align.Center
			} );

		var container = new ModulableScreen( null, null, new Styles()
		{
			Height = Length.Parse( "50%" ),
			Width = Length.Parse( "80%" ),
			Display = DisplayMode.Flex,
			FlexDirection = FlexDirection.Row,
			JustifyContent = Justify.SpaceBetween,
			AlignItems = Align.Center
		});

		var smBlackScreen = new ModulableScreen( null, null,
			new Styles()
			{
				Display = DisplayMode.Flex,
				JustifyContent = Justify.Center,
				AlignItems = Align.Center,
				Position = PositionMode.Absolute,
				Height = Length.Parse( "100%" ),
				Width = Length.Parse( "100%" ),
				BackgroundColor = new Color( 0, 0, 0, 0.65f )
			} );
		smBlackScreen.AddClass( "borderRadius" );
		
		var smBlackScreen2 = new ModulableScreen( null, null,
			new Styles()
			{
				Display = DisplayMode.Flex,
				JustifyContent = Justify.Center,
				AlignItems = Align.Center,
				Position = PositionMode.Absolute,
				Height = Length.Parse( "100%" ),
				Width = Length.Parse( "100%" ),
				BackgroundColor = new Color( 0, 0, 0, 0.65f )
			} );
		smBlackScreen2.AddClass( "borderRadius" );
		
		var buttonHunter = new ModulableButton( "", () => HunterSelect() , new Styles()
		{
			Position = PositionMode.Relative,
			Height = Length.Pixels( 390 ),
			Width = Length.Pixels( 420 ),
			Display = DisplayMode.Flex,
			JustifyContent = Justify.Center,
			AlignItems = Align.Center
		});
		buttonHunter.AddClass( "shading_hunter" );
		buttonHunter.AddClass( "borderRadius" );
		
		var hunterImage = new ModulableImage( "/assets/images/tlou_hunters.png", new Styles()
		{
			Height = Length.Parse( "70%" ),
			Width = Length.Parse( "70%" )
		});
		
		var buttonFirefly = new ModulableButton( "", () => FireflySelect(), new Styles()
		{
			Position = PositionMode.Relative,
			Height = Length.Pixels( 390 ),
			Width = Length.Pixels( 420 ),
			Display = DisplayMode.Flex,
			JustifyContent = Justify.Center,
			AlignItems = Align.Center,
		});
		buttonFirefly.AddClass( "shading_firefly" );
		buttonFirefly.AddClass( "borderRadius" );
		
		var fireflyImage = new ModulableImage( "/assets/images/tlou_fireflies.png", new Styles()
		{
			Height = Length.Parse( "55%" ),
			Width = Length.Parse( "70%" )
		});

		buttonHunter.AddChild( smBlackScreen );
		buttonFirefly.AddChild( smBlackScreen2 );
		smBlackScreen.AddChild( hunterImage );
		smBlackScreen2.AddChild( fireflyImage );
		container.AddChild( buttonHunter );
		container.AddChild( buttonFirefly );
		/*container.AddChild( gameTitle );*/
		blackFilter.AddChild( container );
		AddChild( ImageBg );
		AddChild( blackFilter );
	}


	public void HunterSelect()
	{
		this.Delete( false );

		var hunter = new Hunters();
		var character = Local.Client.Pawn as Character;
		if ( character == null )
			return;
		character.SetName( "Eren Jäger" );
		character.SetDesc( "Le meilleur chasseur avec sa horde de titans." );
		character.SetFaction( hunter );
	}

	public void FireflySelect()
	{
		this.Delete( false );

		var firefly = new Fireflies();
		var character = Local.Client.Pawn as Character;
		if ( character == null )
			return;
		character.SetName( "Eren Jäger" );
		character.SetDesc( "Le meilleur chasseur avec sa horde de titans." );
		character.SetFaction( firefly );
	}
}
