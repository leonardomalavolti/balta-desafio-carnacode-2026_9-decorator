using DesignPatternChallenge.Abstractions;
using DesignPatternChallenge.Beverages;
using DesignPatternChallenge.Decorators;

Console.WriteLine("=== Sistema de Pedidos - Cafeteria (Decorator) ===\n");

// Pedido 1: Espresso simples
IBeverage order1 = new Espresso();
Console.WriteLine($"{order1.GetDescription()} = R$ {order1.GetCost():N2}");

// Pedido 2: Espresso com Leite
IBeverage order2 = new MilkDecorator(new Espresso());
Console.WriteLine($"{order2.GetDescription()} = R$ {order2.GetCost():N2}");

// Pedido 3: Cappuccino com Chocolate e Chantilly
IBeverage order3 = new WhippedCreamDecorator(
                        new ChocolateDecorator(
                            new Cappuccino()));
Console.WriteLine($"{order3.GetDescription()} = R$ {order3.GetCost():N2}");

// Pedido 4: Chá com TODOS os complementos
IBeverage order4 =
    new CaramelDecorator(
        new WhippedCreamDecorator(
            new ChocolateDecorator(
                new MilkDecorator(
                    new Tea()))));

Console.WriteLine($"{order4.GetDescription()} = R$ {order4.GetCost():N2}");

Console.WriteLine("\n=== BENEFÍCIOS DO DECORATOR ===");
Console.WriteLine("✔ Elimina explosão de classes");
Console.WriteLine("✔ Permite adicionar comportamento dinamicamente");
Console.WriteLine("✔ Segue Open/Closed Principle");
Console.WriteLine("✔ Cada complemento é independente");
Console.WriteLine("✔ Fácil adicionar novo complemento sem alterar código existente");