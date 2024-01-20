using Yoga.ReactNative.StyleSheet.Enums;

namespace Yoga.ReactNative.StyleSheet;

public interface IImageStyle : IFlexStyle, IShadowStyleIOS
{
    ITransformsStyle? Transform { get; set; }

    ImageResizeMode? ResizeMode { get; set; }

    BackfaceVisibility? BackfaceVisibility { get; set; }

    AnimatableNumericValue? BorderBottomLeftRadius { get; set; }

    AnimatableNumericValue? BorderBottomRightRadius { get; set; }

    Color? BackgroundColor { get; set; }

    Color? BorderColor { get; set; }

    AnimatableNumericValue? BorderRadius { get; set; }

    AnimatableNumericValue? BorderTopLeftRadius { get; set; }

    AnimatableNumericValue? BorderTopRightRadius { get; set; }

    Color? OverlayColor { get; set; }

    Color? TintColor { get; set; }

    AnimatableNumericValue? Opacity { get; set; }

    ObjectFit? ObjectFit { get; set; }
}
