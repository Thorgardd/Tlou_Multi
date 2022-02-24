using Sandbox;
using Sandbox.UI;
using Sandbox.UI.Construct;
using System;

public class BaseButton : Button
{
	protected BaseButton( 
		string text,
		Action onClick = null,
		Styles styles = null
	) : base( text, null, onClick )
	{
		if ( styles != null )
			BuildStyle( styles );
	} 
	
	protected void BuildStyle(Styles styles)
	{
		Style.Bottom = styles.Bottom;
		Style.Content = styles.Content;
		Style.Cursor = styles.Cursor;
		Style.Display = styles.Display;
		Style.Height = styles.Height;
		Style.Left = styles.Left;
		Style.Opacity = styles.Opacity;
		Style.Order = styles.Order;
		Style.Overflow = styles.Overflow;
		Style.Position = styles.Position;
		Style.Right = styles.Right;
		Style.Top = styles.Top;
		Style.Transform = styles.Transform;
		Style.Transitions = styles.Transitions;
		Style.Width = styles.Width;
		Style.AlignContent = styles.AlignContent;
		Style.AlignItems = styles.AlignItems;
		Style.AlignSelf = styles.AlignSelf;
		Style.AspectRatio = styles.AspectRatio;
		Style.BackgroundColor = styles.BackgroundColor;
		Style.BackgroundAngle = styles.BackgroundAngle;
		Style.BackgroundImage = styles.BackgroundImage;
		Style.BackgroundRepeat = styles.BackgroundRepeat;
		Style.BackgroundRepeat = styles.BackgroundRepeat;
		Style.BackgroundTint = styles.BackgroundTint;
		Style.BoxShadow = styles.BoxShadow;
		Style.ColorInterpolation = styles.ColorInterpolation;
		Style.FilterBlur = styles.FilterBlur;
		Style.FilterBrightness = styles.FilterBrightness;
		Style.FilterContrast = styles.FilterContrast;
		Style.FilterInvert = styles.FilterInvert;
		Style.FilterSaturate = styles.FilterSaturate;
		Style.FilterSepia = styles.FilterSepia;
		Style.FilterTint = styles.FilterTint;
		Style.FilterHueRotate = styles.FilterHueRotate;
		Style.FlexDirection = styles.FlexDirection;
		Style.FlexBasis = styles.FlexBasis;
		Style.FlexGrow = styles.FlexGrow;
		Style.FlexShrink = styles.FlexShrink;
		Style.FlexWrap = styles.FlexWrap;
		Style.FontColor = styles.FontColor;
		Style.FontFamily = styles.FontFamily;
		Style.FontSize = styles.FontSize;
		Style.FontStyle = styles.FontStyle;
		Style.FontWeight = styles.FontWeight;
		Style.ImageRendering = styles.ImageRendering;
		Style.JustifyContent = styles.JustifyContent;
		Style.LetterSpacing = styles.LetterSpacing;
		Style.MarginBottom = styles.MarginBottom;
		Style.MarginLeft = styles.MarginLeft;
		Style.MarginRight = styles.MarginRight;
		Style.MarginTop = styles.MarginTop;
		Style.MaxHeight = styles.MaxHeight;
		Style.MaxWidth = styles.MaxWidth;
		Style.MinHeight = styles.MinHeight;
		Style.MinWidth = styles.MinWidth;
		Style.PaddingBottom = styles.PaddingBottom;
		Style.PaddingLeft = styles.PaddingLeft;
		Style.PaddingRight = styles.PaddingRight;
		Style.PaddingTop = styles.PaddingTop;
		Style.PixelSnap = styles.PixelSnap;
		Style.PointerEvents = styles.PointerEvents;
		Style.SoundIn = styles.SoundIn;
		Style.SoundOut = styles.SoundOut;
		Style.TextAlign = styles.TextAlign;
		Style.TextShadow = styles.TextShadow;
		Style.TextTransform = styles.TextTransform;
		Style.WhiteSpace = styles.WhiteSpace;
		Style.ZIndex = styles.ZIndex;
		Style.BackdropFilterBlur = styles.BackdropFilterBlur;
		Style.BackdropFilterBrightness = styles.BackdropFilterBrightness;
		Style.BackdropFilterContrast = styles.BackdropFilterContrast;
		Style.BackdropFilterInvert = styles.BackdropFilterInvert;
		Style.BackdropFilterSaturate = styles.BackdropFilterSaturate;
		Style.BackdropFilterSepia = styles.BackdropFilterSepia;
		Style.BackdropFilterHueRotate = styles.BackdropFilterHueRotate;
		Style.BackgroundPositionX = styles.BackgroundPositionX;
		Style.BackgroundPositionY = styles.BackgroundPositionY;
		Style.BackgroundSizeX = styles.BackgroundSizeX;
		Style.BackgroundSizeY = styles.BackgroundSizeY;
		Style.BorderBottomColor = styles.BorderBottomColor;
		Style.BorderBottomWidth = styles.BorderBottomWidth;
		Style.BorderImageFill = styles.BorderImageFill;
		Style.BorderImageRepeat = styles.BorderImageRepeat;
		Style.BorderImageSource = styles.BorderImageSource;
		Style.BorderLeftColor = styles.BorderLeftColor;
		Style.BorderLeftWidth = styles.BorderLeftWidth;
		Style.BorderRightColor = styles.BorderRightColor;
		Style.BorderRightWidth = styles.BorderRightWidth;
		Style.BorderTopColor = styles.BorderTopColor;
		Style.BorderTopWidth = styles.BorderTopWidth;
		Style.BorderBottomLeftRadius = styles.BorderBottomLeftRadius;
		Style.BorderBottomRightRadius = styles.BorderBottomRightRadius;
		Style.BorderImageWidthBottom = styles.BorderImageWidthBottom;
		Style.BorderImageWidthLeft = styles.BorderImageWidthLeft;
		Style.BorderImageWidthRight = styles.BorderImageWidthRight;
		Style.BorderImageWidthTop = styles.BorderImageWidthTop;
		Style.FilterHueRotate = styles.FilterHueRotate;
		Style.MixBlendMode = styles.MixBlendMode;
		Style.TextBackgroundAngle = styles.TextBackgroundAngle;
		Style.TextBackgroundImage = styles.TextBackgroundImage;
		Style.TextDecorationColor = styles.TextDecorationColor;
		Style.TextDecorationLine = styles.TextDecorationLine;
		Style.TextDecorationStyle = styles.TextDecorationStyle;
		Style.TextDecorationThickness = styles.TextDecorationThickness;
		Style.TextDecorationSkipInk = styles.TextDecorationSkipInk;
		Style.TextOverlineOffset = styles.TextOverlineOffset;
		Style.TextStrokeColor = styles.TextStrokeColor;
		Style.TextStrokeWidth = styles.TextStrokeWidth;
		Style.TextUnderlineOffset = styles.TextUnderlineOffset;
		Style.TextLineThroughOffset = styles.TextLineThroughOffset;
	}

	public virtual void Destroy()
	{
		Delete();
	}


}
