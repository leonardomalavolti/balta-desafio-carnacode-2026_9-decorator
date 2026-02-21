using DesignPatternChallenge.Abstractions;

namespace DesignPatternChallenge.Decorators;

public class WhippedCreamDecorator : BeverageDecorator
{
    public WhippedCreamDecorator(IBeverage beverage) : base(beverage) { }

    public override decimal GetCost()
        => base.GetCost() + 1.00m;

    public override string GetDescription()
        => base.GetDescription() + " + Chantilly";
}