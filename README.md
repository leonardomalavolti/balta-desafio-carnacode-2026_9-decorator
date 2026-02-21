![ES-4](https://github.com/user-attachments/assets/a2e54098-8641-46ca-8c71-399f54624d9f)

# 🥁 CarnaCode 2026 - Desafio 09 - Decorator

Oi, eu sou o **Leonardo Malavolti** e este é o espaço onde compartilho minha jornada de aprendizado durante o desafio **CarnaCode 2026**, realizado pelo [balta.io](https://balta.io). 👻  

Aqui você vai encontrar projetos, exercícios e códigos que estou desenvolvendo durante o desafio. O objetivo é colocar a mão na massa, testar ideias e registrar minha evolução no mundo da tecnologia.

---

## 📚 Sobre este desafio

No desafio **Decorator** eu precisei resolver um problema real implementando o padrão de projeto correspondente.

Durante esse processo, trabalhei conceitos importantes como:

- ✅ Boas práticas de desenvolvimento
- ✅ Código limpo
- ✅ Princípios SOLID
- ✅ Design Patterns aplicados a cenários reais
- ✅ Composição em vez de herança excessiva

---

## 🚨 Problema

Uma cafeteria oferece bebidas base (Café, Cappuccino, Chá) e múltiplos complementos (Leite, Chocolate, Chantilly, Caramelo).

A modelagem original apresentava dois grandes problemas:

### ❌ Abordagem 1 — Herança excessiva
Criar uma classe para cada combinação possível:

- EspressoComLeite  
- EspressoComLeiteEChocolate  
- CappuccinoComChocolate  
- ...

Isso gera:

- Explosão combinatória de classes  
- Código duplicado  
- Dificuldade para manutenção  
- Violação de boas práticas de design  

---

### ❌ Abordagem 2 — Flags booleanas

Utilizar propriedades booleanas como:

```csharp
public bool ComLeite { get; set; }
public bool ComChocolate { get; set; }
```

Isso gera:

- Classe gigante com múltiplos `if`
- Violação do Open/Closed Principle
- Dificuldade para adicionar novos complementos
- Código menos expressivo e menos extensível

---

## ✅ Solução com o Pattern Decorator

O padrão **Decorator** resolve esse problema permitindo:

- Adicionar comportamento dinamicamente
- Encapsular cada complemento em uma classe própria
- Manter a interface consistente
- Estender o sistema sem modificar código existente

### 💡 Como funciona

1. Criamos uma interface `IBeverage`
2. As bebidas base implementam essa interface
3. Criamos um `BeverageDecorator` abstrato
4. Cada complemento herda do decorator e adiciona seu comportamento

Exemplo de uso:

```csharp
IBeverage pedido =
    new CaramelDecorator(
        new WhippedCreamDecorator(
            new ChocolateDecorator(
                new MilkDecorator(
                    new Espresso()))));

Console.WriteLine($"{pedido.GetDescription()} = R$ {pedido.GetCost():N2}");
```

---

## 🎯 Benefícios da Solução

✔ Elimina explosão combinatória  
✔ Respeita Open/Closed Principle  
✔ Permite composição dinâmica em runtime  
✔ Código mais limpo e organizado  
✔ Alta extensibilidade  
✔ Baixo acoplamento  

---

## 🧠 Conceitos reforçados

Durante esse desafio, reforcei principalmente:

- Composição > Herança  
- Princípio da Responsabilidade Única  
- Aberto para extensão, fechado para modificação  
- Encapsulamento de comportamento  

---

## 🏁 Sobre o CarnaCode 2026

O desafio **CarnaCode 2026** consiste em implementar todos os **23 Design Patterns clássicos** em cenários reais.

Ao longo da jornada, os participantes desenvolvem a habilidade de:

- Identificar códigos não escaláveis  
- Aplicar padrões corretamente  
- Melhorar legibilidade e arquitetura  
- Evoluir a maturidade técnica  

---

## 📖 eBook - Fundamentos dos Design Patterns

Minha principal fonte de estudo durante o desafio foi o eBook gratuito:

👉 [Fundamentos dos Design Patterns](https://lp.balta.io/ebook-fundamentos-design-patterns)

---

## 📌 Veja meu progresso no desafio

🔗 [Incluir aqui o link do repositório central do CarnaCode]

---

🚀 Seguimos para o próximo padrão!
