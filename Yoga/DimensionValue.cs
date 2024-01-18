using Yoga.Enums;

namespace Yoga;

public record struct DimensionValue
{
    private DimensionValue(double value, Unit unit)
    {
        this.Value = value;
        this.Unit = unit;
    }

    public double Value { get; }

    public Unit Unit { get; }

    public static DimensionValue Points(double value) => new DimensionValue(value, Unit.Point);

    public static DimensionValue Percent(double value) => new DimensionValue(value, Unit.Percent);

    public static implicit operator DimensionValue(double value) => Points(value);
}
