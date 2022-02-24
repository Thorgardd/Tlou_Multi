using Sandbox;
using Sandbox.UI;
using Sandbox.UI.Construct;

public class ModulableImage : BaseImage
{
	public ModulableImage(
		string src,
		Styles styles = null
	) : base(styles)
	{
		SetTexture( src );
	}
	
}
