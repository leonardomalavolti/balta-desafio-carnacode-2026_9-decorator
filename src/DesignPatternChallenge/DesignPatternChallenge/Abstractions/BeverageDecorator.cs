namespace DesignPatternChallenge.Abstractions;

public abstract class BeverageDecorator(IBeverage _beverage) : IBeverage
{
    public virtual decimal GetCost()
        => _beverage.GetCost();

    public virtual string GetDescription()
        => _beverage.GetDescription();
}