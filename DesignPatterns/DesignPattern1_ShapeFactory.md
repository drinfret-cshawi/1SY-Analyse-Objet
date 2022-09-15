# *Design Patterns* : Première Partie

## Fabrique (*Factory Method*, *Virtual Constructor*)

### Intention

Définir une interface pour créer un objet, mais laisser les sous-classes décider
quelle classe doit être instanciée. La fabrique permet à une classe de
transférer la responsabilité de créer des objets aux sous-classes.

### Mise en contexte

Application de dessin, avec la possibilité de dessiner au moins 2 types
d'images, des images sur un `Canvas` (voir `ShapesLib`), ou des images de type *
AsciiArt*. On peut dessiner des figures géométriques sur ces images.

### Détails

1. Menu principal
    - Nouveau document
        - Canvas
        - Ascii Art
    - Ouvrir
    - Fermer
    - Sauvegarder
2. L'application doit créer soit une `CanvasApp`, soit une `AsciiApp`
3. Chaque app doit créer un document du bon type, `CanvasDoc` ou `AsciiDoc`
4. La méthode `CreateDoc` est abstraite parce que le type de document créé va
   dépendre du type d'image choisie
    - donc le menu principal doit créer le bon type d'application, mais le reste
      du code de l'interface graphique va travailler avec les classes
      abstraites `Application` et `Document`, sans connaitre le type exact
      d'image
    - si ce n'était pas le cas, il faudrait faire des `if ... else ...` ou
      des `switch` partout sur le type d'image pour utiliser les bonnes classes
    - en utilisant les classe abstraites, cela permet de faire bon usage du
      polymorphisme

````plantuml
@startuml
abstract class Document {
}

class CanvasDoc {
}
Document <|-- CanvasDoc

class AsciiDoc {
}
Document <|-- AsciiDoc

abstract class Application {
   +{abstract} CreateDocument() : Document
   +NewDocument() : Document
   +OpenDocument() : Document
}
Document "*" <-o "*" Application :docs  

class CanvasApp {
   +CreateDocument() : Document
}
Application <|-- CanvasApp
CanvasDoc <. CanvasApp

class AsciiApp {
   +CreateDocument() : Document
}
Application <|-- AsciiApp
AsciiDoc <. AsciiApp
@enduml
````

-------------------------------------------------------------------------------

## Fabrique Abstraite (*Abstract Factory*, *Kit*)

### Intention

Donner une interface pour créer une famille d'objets semblables ou dépendants
sans spécifier leur classe concrète.

### Mise en contexte

Continuation de l'exemple précédent. Pour créer les figures géométriques (
les `Shape`s), doit-on créer les version `CanvasApp` ou `AsciiApp` ? Il faut
éviter de faire des `if ... else ...` ou des `switch` partout.

### Détails

1. Bouton pour créer une ligne (ou un cercle ou un rectangle...) :
    - a-t-on besoin d'un `if` pour savoir quel objet créer exactement?
    - une ligne sur un `Canvas` ou une ligne `Ascii`?
2. Il faut créer 2 `ShapeFactory`, avec des méthodes pour chaque type de `Shape`
3. `CanvasApp` va créer une `CanvasShapeFactory`
4. `AsciiApp` va créer une `AsciiShapeFactory`
5. La classe abstraite `ShapeFactory` va être utilisée au niveau de la
   classe `Application`
6. Chaque application va avoir une méthode (ou peut-être une propriété) de
   type `ShapeFactory`
   - `App.ShapeFactory.createLine()` va retourner une nouvelle ligne, de type `Canvas` ou `Ascii`, selon la sous-classe utilisée au moment de la création
   - ce code sera utilisé, par exemple, dans le `onClick` (ou autre gestionnaire d’évènement) d'un bouton, ou d'un item de menu, ou d'un raccourci clavier, ...

````plantuml
@startuml
abstract class ShapeFactory {
   +{abstract} CreateLine() : Line
   +{abstract} CreateCircle() : Circle
}

class CanvasShapeFactory {
   +CreateLine() : Line
   +CreateCircle() : Circle
}
ShapeFactory <|-- CanvasShapeFactory

class AsciiShapeFactory {
   +CreateLine() : Line
   +CreateCircle() : Circle
}
ShapeFactory <|-- AsciiShapeFactory

@enduml
````