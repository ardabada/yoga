using Yoga.Annotations;
using Yoga.Enums;

namespace Yoga.ReactNative.StyleSheet;

public interface IFlexStyle
{
    /// <summary>
    /// <c>alignContent</c> controls how rows align in the cross direction, overriding the alignContent of the parent.
    /// </summary>
    /// <see href="https://reactnative.dev/docs/layout-props#aligncontent"/>
    /// <remarks>
    /// Allowed values: 
    /// <see cref="Align.FlexStart"/>, <see cref="Align.FlexEnd"/>, 
    /// <see cref="Align.Center"/>, <see cref="Align.Stretch"/>, 
    /// <see cref="Align.SpaceBetween"/>, <see cref="Align.SpaceAround"/>, <see cref="Align.SpaceEvenly"/>
    /// </remarks>
    Align? AlignContent { get; set; }

    Align? AlignItems { get; set; }

    Align? AlignSelf { get; set; }

    DimensionValue? AspectRatio { get; set; }

    double? BorderBottomWidth { get; set; }

    double? BorderEndWidth { get; set; }

    double? BorderLeftWidth { get; set; }

    double? BorderRightWidth { get; set; }

    double? BorderStartWidth { get; set; }

    double? BorderTopWidth { get; set; }

    double? BorderWidth { get; set; }

    DimensionValue? Bottom { get; set; }

    Display? Display { get; set; }

    DimensionValue? End { get; set; }

    DimensionValue? FlexBasis { get; set; }

    FlexDirection? FlexDirection { get; set; }

    double? RowGap { get; set; }

    double? Gap { get; set; }

    double? ColumnGap { get; set; }

    double? FlexGrow { get; set; }

    double? FlexShrink { get; set; }

    Wrap? FlexWrap { get; set; }

    DimensionValue? Height { get; set; }

    Justify? JustifyContent { get; set; }

    DimensionValue? Left { get; set; }

    DimensionValue? Margin { get; set; }

    DimensionValue? MarginBottom { get; set; }

    DimensionValue? MarginEnd { get; set; }

    DimensionValue? MarginHorizontal { get; set; }

    DimensionValue? MarginLeft { get; set; }

    DimensionValue? MarginRight { get; set; }

    DimensionValue? MarginStart { get; set; }

    DimensionValue? MarginTop { get; set; }

    DimensionValue? MarginVertical { get; set; }

    DimensionValue? MaxHeight { get; set; }

    DimensionValue? MaxWidth { get; set; }

    DimensionValue? MinHeight { get; set; }

    DimensionValue? MinWidth { get; set; }

    Overflow? Overflow { get; set; }

    DimensionValue? Padding { get; set; }

    DimensionValue? PaddingBottom { get; set; }

    DimensionValue? PaddingEnd { get; set; }

    DimensionValue? PaddingHorizontal { get; set; }

    DimensionValue? PaddingLeft { get; set; }

    DimensionValue? PaddingRight { get; set; }

    DimensionValue? PaddingStart { get; set; }

    DimensionValue? PaddingTop { get; set; }

    DimensionValue? PaddingVertical { get; set; }

    Position? Position { get; set; }

    DimensionValue? Right { get; set; }

    DimensionValue? Start { get; set; }

    DimensionValue? Top { get; set; }

    DimensionValue? Width { get; set; }

    double? ZIndex { get; set; }

    [iOS]
    Direction? Direction { get; set; }
}

