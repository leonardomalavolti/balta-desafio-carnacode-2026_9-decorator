using DesignPatternChallenge.Abstractions;

namespace DesignPatternChallenge.Decorators;

public class MilkDecorator : BeverageDecorator
{
    public MilkDecorator(IBeverage beverage) : base(beverage) { }

    public override decimal GetCost()
        => base.GetCost() + 0.50m;

    public override string GetDescription()
        => base.GetDescription() + " + Leite";
}
