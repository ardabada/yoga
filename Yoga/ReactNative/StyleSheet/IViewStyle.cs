using Yoga.ReactNative.StyleSheet.Enums;

namespace Yoga.ReactNative.StyleSheet;

public interface IViewStyle : IFlexStyle, IShadowStyleIOS
{
    ITransformsStyle? Transform { get; set; }

    BackfaceVisibility? BackfaceVisibility { get; set; }
    Color? BackgroundColor { get; set; }
    Color? BorderBlockColor { get; set; }
    Color? BorderBlockEndColor { get; set; }
    Color? BorderBlockStartColor { get; set; }
    Color? BorderBottomColor { get; set; }
    AnimatableNumericValue? BorderBottomEndRadius { get; set; }
    AnimatableNumericValue? BorderBottomLeftRadius { get; set; }
    AnimatableNumericValue? BorderBottomRightRadius { get; set; }
    AnimatableNumericValue? BorderBottomStartRadius { get; set; }
    Color? BorderColor { get; set; }
    BorderCurve? BorderCurve { get; set; }
    Color? BorderEndColor { get; set; }
    AnimatableNumericValue? BorderEndEndRadius { get; set; }
    AnimatableNumericValue? BorderEndStartRadius { get; set; }
    Color? BorderLeftColor { get; set; }
    AnimatableNumericValue? BorderRadius { get; set; }
    Color? BorderRightColor { get; set; }
    Color? BorderStartColor { get; set; }
    AnimatableNumericValue? BorderStartEndRadius { get; set; }
    AnimatableNumericValue? BorderStartStartRadius { get; set; }
    BorderStyle? BorderStyle { get; set; }
    Color? BorderTopColor { get; set; }
    AnimatableNumericValue? BorderTopEndRadius { get; set; }
    AnimatableNumericValue? BorderTopLeftRadius { get; set; }
    AnimatableNumericValue? BorderTopRightRadius { get; set; }
    AnimatableNumericValue? BorderTopStartRadius { get; set; }
    AnimatableNumericValue? Opacity { get; set; }
    double? Elevation { get; set; }
    PointerEvents? PointerEvents { get; set; }
}