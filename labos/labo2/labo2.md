# 420-1SY-SW Analyse Objet

## Labo #2 : Application de dessin (version console)

### Objectif principal

Créer un diagramme de classes pour une application de dessin, et ensuite créer
les classes qui correspondent, en se basant sur l'application décrite dans les
notes de cours *Design Patterns : Première Partie*, et sur le projet `ShapesLib`
. Vous devez une petite application console, une *preuve de concept*, qui
utilise ces classes.

### Détails

1. Créez une nouvelle solution pour ce labo. Il devra contenir au moins 2
   projets, soit une bibliothèque de classes et une application console.
2. À partir des notes de cours *Design Patterns : Première Partie* et du
   projet `ShapesLib`, créez un diagramme de classe pour cette application.
    - Il n'est pas nécessaire d'inclure les classes de l'application console
      dans ce diagramme.
    - Il doit y avoir les classes pour les 2 types d'images (`Canvas`
      et `Ascii`)
    - Il pourrait être utile d'utiliser des espaces de nom différentes pour
      organiser vos classes
    - Placez votre diagramme de classes directement dans votre dossier de
      solution (et non pas dans une des dossiers de projet), dans le
      fichier `README.md`
3. Créez vos classes, en utilisant, et modifiant au besoin, les classes du
   projet `ShapesLib`.
    - Pour les images de type `Ascii`, vous devez créer les classes `AsciiApp`,
      `AsciiDoc` et `AsciiShapeFactory` correctement, mais vous n'êtes pas
      obligé de
      compléter toutes les classes qui correspondent aux classes de
      type `Canvas` qui sont dans le projet `ShapeLib`. Vous pouvez laisser
      des `NotImplementedException` dans les méthodes de ces classes.
    - L'idée est de produire un *proof of concept* (preuve de concept), donc le
      code utilisant la bibliothèque de classe devra utiliser les fabriques
      correctement, mais seulement une des fabriques fonctionnera complètement.
4. Créez une application console, qui sera évidemment limitée dans ses
   fonctions, mais qui utilisera les *design patterns* de fabrique correctement.
   L'application devra avoir, au minimum, les fonctionnalités suivantes :
    1. Menu principal
        - Créez un nouveau document de type `Canvas`
        - Créez un nouveau document de type `Ascii`
        - Modifier le document présentement ouvert (sous-menu)
            - ajouter une ligne
            - ajouter un cercle
            - ... (ajouter pour chacune des figures géométriques)
        - Sauvegarder le document présentement ouvert
        - Quitter
    2. Veuillez noter qu'il n'est pas question ici d'ouvrir un fichier contenant
       un document, ni de modifier le document présentement ouvert. Vous pouvez
       enregistrer le document en format png, et ouvrir le fichier png de
       l'extérieur de votre application pour voir les résultats.  

## Remise

Prenez soin de donner des noms appropriés à vos projets dans votre solution.
Vous devriez utiliser des projets de type *.Net/.Net Core 6*. Placez votre
solution dans un dépôt Git privé sur GitHub, et partagez-le seulement avec
l'utilisateur `drinfret-cshawi` . Votre code devrait être dans la branche
principale du dépôt Git.

**Date de remise** : 6 octobre, avant minuit