# *Design Patterns* : Deuxième Partie

## Monteur (*Builder*)

### Intention

Construire un objet complexe étape par étape.

### Mise en contexte

Différence avec une fabrique abstraite :

- **Fabrique abstraite** : construire des objets, *simples* ou *complexes*,
  d'une
  *même famille*
    - construire des `Shape`s de toutes sortes
- **Monteur** : construire un objet *complexe étape par étape*.
    - Construire des `Shape`s complexes composées de plusieurs autres formes

### Détails

Exemple dans [GoF](https://en.wikipedia.org/wiki/Design_Patterns) : Labyrinthe.

Créer des labyrinthes étape par étape :

1. Construire un labyrinthe vide
2. Ajouter des salles
3. Ajouter des portes
4. etc.

````plantuml
@startuml
abstract MazeBuilder {
  +{abstract} BuildMaze()
  +{abstract} BuildRoom()
  +{abstract} BuildDoor()
  +{abstract} GetMaze()
}

class Maze {
}
MazeBuilder --> Maze
@enduml
````

**Notes** :

1. On pourrait avoir beaucoup plus de méthodes que celles données pour les
   labyrinthes complexes.
2. Il faudrait évidemment ajuster les signatures de ces méthodes pour y ajouter
   des paramètres.
3. Il n'est pas obligatoire d'avoir une classe et des méthodes abstraites. On
   pourrait avoir seulement des classes et méthodes concrètes, avec la
   possibilité d'avoir des méthodes vides au besoin.

-------------------------------------------------------------------------------

## Prototype

### Intention

Spécifier les types d'objets à créer en utilisant une instance prototype, et
créer de nouveaux objets en copiant ce prototype.

### Mise en contexte

**Application principale** : cloner des objets, comme pour un copier-coller.

### Détails

Selon les besoins, on peut effectuer une copie en _surface_ ou en _profondeur_
d'un objet prototype.

- **Copie de surface** (_shallow copy_):
    - seulement les références aux attributs ou propriétés sont
      copiés, donc le clone va partager des références au mêmes objets avec
      l'objet
      original (à condition évidemment d'avoir des attributs ou propriétés de
      type
      référence dans l'objet)
    - si les objets partagés sont modifiés, alors l'objet original et ses clones
      vont voir les modifications
- **Copie en profondeur** (_deep copy_):
    - les attributs et propriétés de type référence sont eux aussi clonés, donc
      les références du clone seront vers des objets différents, mais avec le
      même contenu, que l'objet original
    - pour une copie en profondeur complète, il faut effectuer une copie en
      profondeur sur tous les attributs et propriétés de type référence
      récursivement

En C#, il a différentes façons de cloner des objets

1. `Object.MemberwiseClone()` : copie de surface
2. `ICloneable.Clone()` : copie de surface ou profonde, selon les besoins
3. Constructeur de copie :
    - copie de surface ou profonde, selon les besoins
    - un constructeur de copie est un constructeur qui accepte un seul
      paramètre, du même type que la classe
    - exemple : `public Circle(Circle circle)`

-------------------------------------------------------------------------------

## Singleton

### Intention

S'assurer qu'une classe ne peut avoir qu'une seule instance.

### Mise en contexte

Dans certaines applications, il n'est pas logique d'avoir plusieurs instances
d'une classe. Comme par exemple dans une application avec interface graphique (
mobile ou bureau), il n'est souvent pas logique d'avoir plus d'une fenêtre
principale.

Dans d'autre applications, il faut s'assurer de bien gérer les resources pour
éviter d'avoir de applications trop gourmandes en termes de mémoire ou de
processeur ou de réseau ... Comme par exemple dans une application qui utilise
une base de données, on ne peut avoir qu'un seul pool de connexions à la base de
données. Avoir plusieurs pools de connexions serait plus difficile à gérer et
consommerait plus de resources.

Ou il faut bien synchroniser l'accès à une resource partagée pour éviter de la
corrompre. Les applications avec plusieurs fils d'exécution (avec des _thread_
ou avec des `asynch`/`await`) ont normalement besoin de partager certaines
structures de données en mémoire, et de synchroniser leur utilisation de ces
structures.

### Détails

1. On peut mettre tous les constructeurs d'une classe en mode d'accès privé (ou
   potentiellement protégé), ce qui empêchera d'autres classes de créer des
   instances de cette classe.
2. Ensuite on ajoute un attribut privé statique pour contenir la référence à
   l'unique instance
3. La méthode statique `GetInstance` doit retourner la référence à l'unique
   instance. La
   première fois, l'attribut privé statique sera `null`, donc on devra créer
   l'unique instance au premier appel de `GetInstance`, et la placer dans
   l'attribut prévu à cet effet, avant de retourner la référence à l'unique
   instance.
4. Alternativement, on pourrait utiliser une propriété avec un *getter* public
   qui ferait le même travail de la méthode `GetInstance`, et un *setter* privé
   qui serait utilisé seulement par le *getter* lors de sa première utilisation.
5. Une autre option serait d'utiliser
   un [constructeur statique en C#](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/static-constructors)
   , ou
   un [bloc d'initialisation statique](https://www.c-sharpcorner.com/UploadFile/3614a6/static-initialization-block-in-java/)
   dans d'autres langages.