using DesignPatternChallenge.Abstractions;

namespace DesignPatternChallenge.Decorators;

public class CaramelDecorator : BeverageDecorator
{
    public CaramelDecorator(IBeverage beverage) : base(beverage) { }

    public override decimal GetCost()
        => base.GetCost() + 0.80m;

    public override string GetDescription()
        => base.GetDescription() + " + Caramelo";
}