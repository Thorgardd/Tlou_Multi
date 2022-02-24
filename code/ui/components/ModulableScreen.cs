using Sandbox;
using Sandbox.UI;
using Sandbox.UI.Construct;

public class ModulableScreen : BasePanel
{
	public ModulableScreen(
		string pathTemplate = null,
		string classname = null,
		Styles styles = null
	) : base(styles)
	{
		if ( pathTemplate != null )
			SetTemplate( pathTemplate );
		
		if (classname != null)
			SetClass( classname, true );
	}





	public override void Destroy()
	{
		base.Destroy();
	}
}
