namespace Yoga.ReactNative.StyleSheet;

public interface ITransformsStyle : IPerspectiveTransform, 
    IRotateTransform, IRotateXTransform, IRotateYTransform, IRotateZTransform,
    IScaleTransform, IScaleXTransform, IScaleYTransform,
    ITranslateXTransform, ITranslateYTransform, 
    ISkewXTransform, ISkewYTransform, 
    IMatrixTransform
{
    DimensionValue[]? TransformOrigin { get; set; }
}

public interface IPerspectiveTransform
{
    AnimatableNumericValue? Perspective { get; set; }
}

public interface IRotateTransform
{
    AnimatableStringValue? Rotate { get; set; }
}

public interface IRotateXTransform
{
    AnimatableStringValue? RotateX { get; set; }
}

public interface IRotateYTransform
{
    AnimatableStringValue? RotateY { get; set; }
}

public interface IRotateZTransform
{
    AnimatableStringValue? RotateZ { get; set; }
}

public interface IScaleTransform
{
    AnimatableNumericValue? Scale { get; set; }
}

public interface IScaleXTransform
{
    AnimatableNumericValue? ScaleX { get; set; }
}

public interface IScaleYTransform
{
    AnimatableNumericValue? ScaleY { get; set; }
}

public interface ITranslateXTransform
{
    AnimatableNumericValue? TranslateX { get; set; }
}

public interface ITranslateYTransform
{
    AnimatableNumericValue? TranslateY { get; set; }
}

public interface ISkewXTransform
{
    AnimatableStringValue? SkewX { get; set; }
}

public interface ISkewYTransform
{
    AnimatableStringValue? SkewY { get; set; }
}

public interface IMatrixTransform
{
    AnimatableNumericValue[]? Matrix { get; set; }
}
