# *Design Patterns* : Comportementaux (*Behavioral*)

## Itérateur (*Iterator*, *Enumerator*, *Cursor*)

### Intention

Fournir un moyen de parcourir séquentiellement les éléments d'un objet composé.

### Mise en contexte

On a une collection d'objets (une liste, un tableau, un graphe, ...) et on
doit parcourir tous les objets de cette collection, possiblement avec une
boucle (`for`, `foreach` ou `while`).

### Détails

````plantuml
@startuml
class Client {}

interface ICollection<T> {
    +CreateIterator() : IIterator<T>
}

interface IIterator<T> {
    +Next() : T
    +Done() : bool
}

class Collection<T> {
    +CreateIterator() : IIterator<T>
}

class Iterator<T> {
    +Next() : T
    +Done() : bool
}

Client --> ICollection
Client --> IIterator

ICollection <|.. Collection
IIterator <|.. Iterator

Collection .> Iterator
@enduml
````

Pour parcourir tous les éléments d'une `Collection`, on peut créer un `Iterator`
, et faire une boucle sur l'itérateur tant que `Done` retourne faux (tant que ce
n'est pas fini).

````csharp
ICollection<int> col = new Collection<int>();
//...
IIterator<int> iter = col.CreateIterator();
while (!iter.Done()) {
    int x = iter.Next();
    //...
}
````

-------------------------------------------------------------------------------