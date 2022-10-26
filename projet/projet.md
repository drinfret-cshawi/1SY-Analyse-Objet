# 420-1SY-SW Analyse Objet

## Projet (Épreuve Finale)

### Objectif principal

La compétence du cours est *Collaborer à la conception d’applications (0SY)*. Le
but du projet est de développer un projet en équipe en utilisant les notions
présentées dans le cours, en ligne avec la compétence du cours.

### Description générale du projet

Il y 2 possibilités : faire le projet suggéré plus bas (gestionnaire de musique)
, ou choisir votre propre sujet. Si vous choisissez votre propre sujet, il
faudra le faire approuver pour être certain qu'il est approprié. Dans les 2 cas,
il faudra répondre aux exigences données plus bas. Selon le projet choisi, il
est possible que les exigences soient ajustées au besoin.

#### Gestionnaire de musique

Vous devez créer un logiciel pour gérer des listes de lecture de pièces
musicales. Ce logiciel peut prendre différentes formes.

Vous pouvez faire un gestionnaire de fichiers MP3 (ou autres fichiers audio),
qui permet d'organiser les fichiers sous forme de listes de lecture et de faire
jouer les chansons. Les fichiers audio seraient situés dans un dossier local, et
vous pourriez utiliser une base de données locale, ou un fichier JSON, pour
conserver les méta-données sur ces fichiers (titre, durée, listes de lectures,
...).

Ou vous pouvez faire une application qui est plus orientée vers le web, avec des
liens vers le site web ou réseaux sociaux des artistes, avec des critiques
d'albums et/ou des recommendations organisées par genre ou par pays, pour faire
découvrir de la musique aux autres.

### Exigences

1. Équipes formées et dépôt Git partagé par les membres de l'équipe et le
   professeur au plus tard le **26 octobre**.
2. Sujet du projet choisi au plus tard le **2 novembre**
3. Diagramme de classe placé dans le dépôt Git au plus tard le **10 novembre**.
   Il sera possible de modifier le diagramme de classes plus tard si
   nécessaire (il sera alors dans un *commit* différent).
4. **Tests unitaires** : le code à tester dans les tests unitaires sera
   déterminé par les membres des équipes avec l'aide du professeur, selon les
   projets utilisés.
5. Normalement, le projet devrait utiliser les outils utilisés en classe (C#,
   xUnit, ...) pour développer une application bureau avec interface graphique,
   mais selon l'application choisie et les intérêts des équipes, d'autres
   outils/environnements pourraient être utilisés. Faites approuver vos choix
   pour être certain qu'ils soient appropriés.
6. Selon le type d'application développée, un installateur devra être créé (
   application bureau) ou l'application devra être déployée (web).
7. Vous devez intégrer des **_design patterns_** dans votre application. Combien
   et lesquels exactement dépend de votre application. Il faut en discuter avec
   le professeur au besoin.
    - Certains *design patterns* vont être plus faciles à intégrer au projet,
      par exemple ceux reliés aux bases de données (adaptateur) ou aux
      interfaces graphiques (MVC ou MVVM)
    - Mais il ne faut pas en utiliser seulement pour être capable de dire qu'on
      les a utilisé : il faut en faire une utilisation logique.
8. **Présentation** : les projets devront être présentés lors du dernier cours
   de la session (8 décembre). Les modalités de la présentation seront annoncées
   plus tard.
9. **Date limite** pour la remise finale du code : **15 décembre avant minuit**