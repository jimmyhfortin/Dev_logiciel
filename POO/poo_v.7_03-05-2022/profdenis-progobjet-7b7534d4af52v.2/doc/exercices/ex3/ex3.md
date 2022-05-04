# Programmation Orientée Objet

## Exercice 3 : Classes, propriétés, constructeurs, méthodes

Créez un solution pour cet exercice. Créez un projet de type *bibliothèque de
classes* qui contiendra toutes vos classes, sauf pour les `Program.cs`. Créez un
projet de type *application console* pour chaque partie de cet exercice.

### Partie A : Classe `Dice`

1. Créez une classe `Dice`, qui représente
   un [dé](https://fr.wikipedia.org/wiki/D%C3%A9)
    1. un dé peut avoir un nombre de faces entre 2 et 120, déterminé au moment
       de la construction du dé, et qui ne peut être modifié après la création
    2. les faces sont numérotées de 1 jusqu'au nombre de faces
    3. la valeur du dé est la valeur de la face sur le dessus de dé; la valeur
       du dé par défaut est 1
    4. un dé a une méthode `Throw`, pour lancer le dé, qui choisit de façon
       aléatoire la valeur d'une de ses faces, qui devient la valeur du dé
    5. la valeur du dé ne peut pas être modifiée de l'extérieur de la classe; la
       seule façon de modifier la valeur du dé est de le lancer
    6. redéfinissez les méthodes `Equals`, `GetHashCode` et `ToString`
    7. dans `ToString`,
        - si le nombre de faces n'est pas égal à 6, alors retournez simplement
          la valeur du dé converti en `string`
        - si le nombre de faces est exactement 6, alors retournez le
          [caractère unicode](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/char)
          qui correspond à la valeur du dé
            - essayez ceci pour voir un autre exemple d'écriture de caractère
              unicode : `Console.WriteLine("\u2685");`
2. Créez une petit application console (un petit jeu) qui utilisera votre
   classe `Dice`
    1. Demandez à l'utilisateur quel dé il/elle veut utiliser
        - vous pouvez soit demander le nombre de faces désirées sur le dé, soit
          créer d'avance quelques dés différents et demander lequel des dés le
          jeu doit utiliser
    2. Lancez le dé sans dévoiler la face obtenue
    3. Faites deviner le résultat obtenu
        1. donnez plusieurs chances de deviner la bonne face
        2. donnez aussi l'option d'abandonner la partie
        3. donnez des indices entre chaque essai
            - par exemple, indiquez quelque chose du genre *trop haut* ou *trop
              bas*

### Partie B : Liste et tableau de dés

1. Dans une autre application console, testez la création et l'utilisation d'un tableau de dés.
   1. créez un tableau de dés et remplissez-le de dés
   2. lancez tous les dés
   3. affichez les résultats
2. Répétez les mêmes étapes, mais pour une liste de dés.
3. Serait-il possible de regrouper ces fonctionnalités (pour un tableau et/ou une liste) dans une nouvelle classe? Si oui, créez une classe dans la bibliothèque de classes qui représente un tableau ou une liste de dés
   - plusieurs jeux nécessitent d'utiliser et de lancer plusieurs dés à la fois
   - vous pouvez ajouter des méthodes pour calculer le total de tous les dés, ainsi que des méthodes pour trouver la plus petite et la plus grande des valeurs obtenues sur les dés
4. Testez votre classe dans la même application console que les étapes 1. et 2.
