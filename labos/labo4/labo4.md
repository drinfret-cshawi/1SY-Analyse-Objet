# 420-1SY-SW Analyse Objet

## Labo #4 : *Mock* d'une source de données

### Objectif principal

Appliquer le *design pattern* ***Mock Object*** à une source de données lors du
développement d'une application en utilisant le **TDD** (*Test Driven
Development*).

### Détails

Complétez les projets `CollegeLib`, `CollegeDataLib` et `CollegeLibDataTest`, en
se basant sur le code déjà présent et les informations données plus bas.

1. Modifiez les classes `StudyProgram`, `Course` et `CourseOffering` de la même
   façon que la classe `Person`. Elle doivent implémenter
   l'interface `IComparable<>` et la méthode `CompareTo`.
    - `StudyProgram` : comparer le nom des programmes
    - `Course` : comparer le code des cours
    - `CourseOffering` : comparer l'année, suivi de la session et ensuite du
      code de cours.
2. Ajoutez des méthodes statiques dans la classe `Sorting` pour être capable de
   trier les objets des différentes classes selon les critères suivants. Chaque
   critère de tri doit avoir les options croissante (`SortOrder.Asc`) ou
   décroissante (`SortOrder.Desc`)
    - `Person` : trier selon l'ordre par défaut
    - `Person` : trier par date de naissance
    - `Course` : trier selon l'ordre par défaut
    - `Course` : trier par nom
    - `CourseOffering` : trier selon l'ordre par défaut
3. Créez des *mocks* pour `StudyProgram`, `Course` et `CourseOffering` semblable
   au mock de `Person`.
4. Testez vos *mocks* à la manière du *mock* de `Person`. Créez des classes de
   tests différentes pour chaque mock.
5. Testez toutes toutes les méthodes de tri. Créez des classes de tests
   différentes pour chaque classe, sauf pour `Person`, dans lequel vous devez
   ajouter des tests au fichier existant.

## Remise

Prenez soin de donner des noms appropriés à vos projets dans votre solution.
Vous devriez utiliser des projets de type *.Net/.Net Core 6*. Placez votre
solution dans un dépôt Git privé sur GitHub, et partagez-le seulement avec
l'utilisateur `drinfret-cshawi` . Votre code devrait être dans la branche
principale du dépôt Git.

**Date de remise** : 3 novembre, avant minuit