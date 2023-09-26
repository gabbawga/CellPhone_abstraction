## Context
An abstraction of a cell phone and provides ways for different brands and models to have their own behavior, enabling greater code reuse and using object orientation.

## Proposal
create a .NET console-type system, mapping an abstract class and specific classes for two types of cell phones: Nokia and iPhone.

![Diagrama classes](Imagens/diagrama.png)

## Rules and validations
1. The **Smartphone** class must be abstract, not allowing instantiation and serving only as a model.
2. The **Nokia** and **Iphone** classes must be child classes of Smartphone.
3. The **InstalarApplication** method must be overridden in the Nokia and iPhone classes, as both have different ways of installing an application.

