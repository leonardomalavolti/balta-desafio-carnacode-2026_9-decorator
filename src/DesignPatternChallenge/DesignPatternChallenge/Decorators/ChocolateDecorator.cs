using DesignPatternChallenge.Abstractions;

namespace DesignPatternChallenge.Decorators;

public class ChocolateDecorator : BeverageDecorator
{
    public ChocolateDecorator(IBeverage beverage) : base(beverage) { }

    public override decimal GetCost()
        => base.GetCost() + 0.70m;

    public override string GetDescription()
        => base.GetDescription() + " + Chocolate";
}
