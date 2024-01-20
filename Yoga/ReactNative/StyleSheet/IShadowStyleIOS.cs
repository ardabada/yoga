using Yoga.Annotations;

namespace Yoga.ReactNative.StyleSheet;

public interface IShadowStyleIOS
{
    [iOS]
    Color? ShadowColor { get; set; }

    [iOS]
    Offset? ShadowOffset { get; set; }

    [iOS]
    AnimatableNumericValue? ShadowOpacity { get; set; }

    [iOS]
    double? ShadowRadius { get; set; }
}
