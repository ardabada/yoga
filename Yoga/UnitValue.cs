using Yoga.Enums;

namespace Yoga;

public record struct UnitValue
{
    private UnitValue(double value, Unit unit)
    {
        this.Value = value;
        this.Unit = unit;
    }

    public double Value { get; }

    public Unit Unit { get; }

    public static UnitValue Points(double value) => new UnitValue(value, Unit.Point);

    public static UnitValue Percent(double value) => new UnitValue(value, Unit.Percent);

    public static implicit operator UnitValue(double value) => Points(value);
}
