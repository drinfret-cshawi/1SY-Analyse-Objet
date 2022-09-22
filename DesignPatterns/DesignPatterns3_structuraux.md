# *Design Patterns* : Structuraux

## Adaptateur (*Adapter*, *Wrapper*)

### Intention

Convertir l'interface d'une classe vers une autre interface attendue par le
client. Un adaptateur permet à des classes de travailler ensemble qui
autrement ne le pourraient pas.

### Mise en contexte

Le but est d'isoler l'adaptation d'un sous-système, pour que le client n'aie pas
à se soucier des détails du sous-système, et également pour faciliter la
substitution du sous-système par un autre qui offre le même type de
fonctionnalité, mais possiblement avec une interface différente.

### Détails

Exemple avec les bases de données : connexion directe à la BD vs. adaptateur
entre le client et la BD.

- Une **connexion directe** à la BD évite d'avoir des couches de trop, donc il
  est
  souvent possible d'optimiser des requêtes de meilleure façon et d'utiliser des
  fonctionnalités de la BD directement.
- Avec un **adaptateur**, il est possible de présenter une interface plus simple
  au
  client, qui n'a pas besoin de s'occuper des détails de connexion à la base de
  données, ni du langage de requêtes (SQL ou autre).
- Également avec un **adaptateur**, il est plus facile de migrer vers des BD
  différentes, même vers des BD de types différents (relationelles vs. noSQL,
  ...).

Un exemple détaillé va être donné dans une solution C# disponible séparément.

-------------------------------------------------------------------------------

## Pont (*Bridge*)

### Intention

Découple une abstraction de son implémentation pour que les deux puissent
évoluer indépendamment.

### Mise en contexte

### Détails

-------------------------------------------------------------------------------

## Composite

### Intention

Composer des objets dans une structure arborescente pour représenter des
hiérarchies tout-parties. Une composite permet aux clients de gérer des objets
individuels et des compositions d'objets uniformément.

### Mise en contexte

Le but est d'avoir des objets qui peuvent contenir d'autres objets qui peuvent
eux-mêmes contenir d'autres objets, incluant des objets du même type
qu'eux-mêmes.

### Détails

Exemple le plus courant : un système de fichiers qui peut contenir des dossiers
et d'autres fichiers. Les dossiers peuvent contenir d'autres dossiers ainsi que
d'autres types de fichiers.

Deux types d'éléments : dossiers et fichiers. On pourrait aussi avoir plusieurs
types de fichiers, qui seraient représentés par des sous-classes de `File` dans
le diagramme de classes.

````plantuml
@startuml

abstract class Element {
}

class Folder {
}
Element <|-- Folder
Element "*" <--o Folder : children

class File {
}
Element <|-- File

@enduml
````

-------------------------------------------------------------------------------

## Décorateur (*Decorator*, *Wrapper*)

### Intention

Attacher des responsabilités additionnelles à un objet dynamiquement. Les
décorateurs offre une alternative flexible à l'extension de classe pour étendre
les fonctionnalités.

### Mise en contexte

Si on veut rapidement ajouter une propriété ou fonctionnalité à un objet ou une
méthode ou une propriété, on peut la décorer (ou l'envelopper) avec un
décorateur.

### Détails

Exemples :

- En C#, le décorateur `[JsonIgnore]` appliqué à une propriété ou un attribut
  d'une classe ajoute de l'information qui sera utilisé par le `JsonSerialiser`
  lors de la sérialisation d'un objet. La propriété ou l'attribut sera alors
  ignoré et ne se retrouvera pas dans le résultat de la sérialisation.
- En développement web, plusieurs *frameworks* utilisent des décorateurs pour
  envelopper des fonctions ou méthodes pour qu'elles servent de gestionnaire (*
  handler*) de requêtes sur certaines routes. Une fonction peut être décorée du
  chemin de la route (`/`, `/data/users/`, ...), de la méthode (`GET`, `POST`,
  ...), et possiblement d'autres informations. De cette façon, la fonction est
  enregistrée dans le serveur comme étant le gestionnaire de la route. Si aucune
  fonction n'est associée à une route, alors le serveur va probablement
  retourner un `404`.

-------------------------------------------------------------------------------

## Facade

### Intention

Offrir une interface unifiée vers un ensemble d'interfaces dans un sous-système.
Une facade définit une interface de plus haut niveau qui rend le sous-système
plus simple à utiliser.

### Mise en contexte

Il est souvent utile de fournir une version simplifiée d'un sous-système qui va
être plus facile à utiliser pour des clients qui n'ont pas besoins de toutes les
fonctionnalités du sous-système. La facade va inclure seulement ce qui est utile
pour le client, ce qui va aider au développement du client puisque qu'il y aura
moins de méthodes ou classes inutiles à filtrer par les programmeurs.

### Détails

````plantuml
@startuml

class Client {
}
Client -> Facade

class Facade {
  +{static} f1()
  +{static} f4()
  +{static} f5()
  +{static} f8()
}
Facade -> C
Facade -> B
Facade -> A

class A {
  +{static} f1()
  +{static} f2()
}

class B {
  +{static} f3()
  +{static} f4()
  +{static} f5()
  +{static} f6()
}

class C {
  +{static} f7()
  +{static} f8()
  +{static} f9()
}
@enduml
````

-------------------------------------------------------------------------------

## Poids-Mouche (*Flyweight*)

### Intention

Utiliser un système de partage pour pouvoir supporter un grand nombre d'objets
détaillés efficacement.

### Mise en contexte

Des applications, comme des applications de *CAD* ou des jeux vidéos, ont
souvent
besoin de charger ou de créer beaucoup d'objets similaires ou même identiques,
ce qui peut demander beaucoup de resources (mémoire et processeur). Le
vidangeur (*garbage collector*) va également travailler fort pour libérer la
mémoire utilisée par les objets qui ne sont plus utilisés.

Le but est de pouvoir partager et/ou réutiliser des objets, qui contiennent
peut-être des images ou d'autres données d'une taille non-négligeable, pour
diminuer les resources utilisées par l'application.

### Détails

À voir dans un autre cours.


-------------------------------------------------------------------------------

## Proxy (mandataire, substitut, *surrogate*)

### Intention

Offre un substitut ou un espace réservé pour un autre objet pour contrôler son
accès.

### Mise en contexte

- **Proxy virtuel** : Lors du chargement d'un gros document, qui contient
  peut-être d'autres documents
  comme des images ou des vidéos, si on attend que tout le document soit chargé
  au
  complet, incluant les images et les vidéos, on pourrait devoir attendre
  longtemps. Donc on peut utiliser des proxys pour contrôler le chargement des
  resources imbriquées. Pas besoin de charger une vidéo au complet au chargement
  du document (peut-être un page web), surtout si la vidéo n'est pas visible sur
  le document et/ou si la vidéo est mise sur pause par défaut au moment du
  chargement.
- **Proxy de protection** : contrôler l'accès à un objet qui est soumis à des
  règles d'accès (selon des permissions ou des rôles). On peut par exemple
  transformer des objets muables en objets immuables en permettant seulement des
  opérations en lecture seule pour certains utilisateurs, mais pas pour
  d'autres (des admins par exemple).
- **Proxy distant** (mandataire distant) : un proxy réseau peut servir
  d'intermédiaire pour contrôler ou logger les sites internet permis ou visités
  à partir d'un réseau interne.

### Détails

À venir

