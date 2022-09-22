# Principes OO

## SOLID
[https://en.wikipedia.org/wiki/SOLID](https://en.wikipedia.org/wiki/SOLID)

[https://fr.wikipedia.org/wiki/SOLID_(informatique)](https://fr.wikipedia.org/wiki/SOLID_(informatique))

### Responsabilité unique (Single responsibility principle SRP)
Une classe, une fonction ou une méthode doit avoir une et une seule responsabilité

### Ouvert/fermé (Open/closed principle)
Une entité applicative (classe, fonction, module ...) doit être fermée à la modification directe mais ouverte à l'extension

### Substitution de Liskov (Liskov substitution principle)
Une instance de type `T` doit pouvoir être remplacée par une instance de type `G`, tel que `G` sous-type de `T`, sans que cela ne modifie la cohérence du programme

### Ségrégation des interfaces (Interface segregation principle)
Préférer plusieurs interfaces spécifiques pour chaque client plutôt qu'une seule interface générale

### Inversion des dépendances (Dependency inversion principle)
Il faut dépendre des abstractions, pas des implémentations


## DRY / WET
[https://en.wikipedia.org/wiki/Don%27t_repeat_yourself](https://en.wikipedia.org/wiki/Don%27t_repeat_yourself)

[https://fr.wikipedia.org/wiki/Ne_vous_répétez_pas](https://fr.wikipedia.org/wiki/Ne_vous_répétez_pas)

### DRY (Don't Repeat Yourself)

### Opposé de DRY: WET (Write Everything Twice)

## KISS
[https://en.wikipedia.org/wiki/KISS_principle](https://en.wikipedia.org/wiki/KISS_principle)

[https://fr.wikipedia.org/wiki/Principe_KISS](https://fr.wikipedia.org/wiki/Principe_KISS)

### Keep it simple, stupid

## Loi de Demeter (LoD)
[https://en.wikipedia.org/wiki/Law_of_Demeter](https://en.wikipedia.org/wiki/Law_of_Demeter)

[https://fr.wikipedia.org/wiki/Loi_de_Déméter](https://fr.wikipedia.org/wiki/Loi_de_Déméter)

### Principe de connaissance minimale

## Tell Don't ask
[https://martinfowler.com/bliki/TellDontAsk.html](https://martinfowler.com/bliki/TellDontAsk.html)

*Tell-Don't-Ask is a principle that helps people remember that object-orientation is about bundling data with the functions that operate on that data. It reminds us that rather than asking an object for data and acting on that data, we should instead tell an object what to do.*