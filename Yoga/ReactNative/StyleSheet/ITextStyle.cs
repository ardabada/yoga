using Yoga.ReactNative.StyleSheet.Enums;

namespace Yoga.ReactNative.StyleSheet;

public interface ITextStyle : IViewStyle
{
    FontVariant? FontVariant { get; set; }

    WritingDirection? WritingDirection { get; set; }

    TextVerticalAlign? TextAlignVertical { get; set; }

    VerticalAlign? VerticalAlign { get; set; }

    bool? IncludeFontPadding { get; set; }

    Color? Color { get; set; }

    string? FontFamily { get; set; }

    double? FontSize { get; set; }

    FontStyle? FontStyle { get; set; }

    FontWeight? FontWeight { get; set; }

    double? LetterSpacing { get; set; }

    double? LineHeight { get; set; }

    TextAlign? TextAlign { get; set; }

    TextDecorationLine? TextDecorationLine { get; set; }

    TextDecorationStyle? TextDecorationStyle { get; set; }

    Color? TextDecorationColor { get; set; }

    Color? TextShadowColor { get; set; }

    Offset? TextShadowOffset { get; set; }

    double? TextShadowRadius { get; set; }

    TextTransform? TextTransform { get; set; }

    UserSelect? UserSelect { get; set; }
}
