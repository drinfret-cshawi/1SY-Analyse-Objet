# 420-1SY-SW Analyse Objet

## Labo #3 : Itérateur

### Objectif principal

Appliquer le *design pattern* ***Itérateur*** à une structure de données en utilisant le **TDD** (*Test Driven Development*).

### Détails

1. Créez une bibliothèque de classes et y copiez le fichier `IPriorityQueue.cs`.
2. Créez une classe nommée `PriorityQueue` qui implémente cette interface.
3. Générez toutes les méthodes manquantes automatiquement. Ne complétez pas le code de cette classe immédiatement. Laissez les `throw new NotImplementedException()` en place pour l'instant.
4. Ajoutez les propriétés et/ou attributs et constructeur(s) nécessaires à cette classe.
5. Créez une classe interne pour l'énumérateur (ou itérateur).
6. Créez un projet de tests `xUnit` pour tester vos classes.
7. Écrivez vos tests en vous basant sur les méthodes de l'interface. Les tests devraient normalement échouer parce que les méthodes ne sont pas complètes.
8. Faites passer vos tests un à un en complétant le code nécessaire dans vos classes.

## Remise

Prenez soin de donner des noms appropriés à vos projets dans votre solution.
Vous devriez utiliser des projets de type *.Net/.Net Core 6*. Placez votre
solution dans un dépôt Git privé sur GitHub, et partagez-le seulement avec
l'utilisateur `drinfret-cshawi` . Votre code devrait être dans la branche
principale du dépôt Git.

**Date de remise** : 19 octobre, avant minuit