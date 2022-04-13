# Programmation Orientée Objet

## Exercice 1 : Dessiner des figures géométriques, version non-OO

### Partie 1

1. Exécutez l'exemple dans le `Program.cs` du projet `DrawShapes`
   1. il nécessite l'utilisation du paquet `SixLabors.ImageSharp`, qui peut être ajouté au projet à l'aide de `NuGet` (s'il n'est pas déjà installé)
   2. il nécessite également l'utilisation des classes `Draw` et `Canvas`, disponibles dans le projet `ShapesV1`
      - il n'est pas important, pour l'instant, de comprendre les détails du code de la classe `Canvas`, qui sera expliquée en détails plus tard
      - pour l'instant, il faut se concentrer sur son utilisation, comme dans les classes `Draw` et `Canvas`
2. Une image nommée `ex1.png` va être créée par ce programme, contenant seulement une ligne horizontale de couleur rouge
3. Dessinez 2 lignes horizontales de plus, placées à différents endroits, de longueurs et couleurs différentes
4. Où est placé le point `(0, 0)` (l'origine) sur le canvas ? Au centre ? Ou dans un coin ? Quel coin ?
5. Dans quelle direction les valeurs de `x` augmentent-elles ?
6. Dans quelle direction les valeurs de `y` augmentent-elles ?

### Partie 2

1. Complétez le code de la méthode `DrawVLine`, et testez-la dans le programme de `DrawShapes`
2. Complétez le code de la méthode `DrawRectangle`, et testez-la dans le programme de `DrawShapes`
3. Complétez le code de la méthode `DrawSquare`, et testez-la dans le programme de `DrawShapes`

### Partie 3 (plus difficile)

1. Complétez le code de la méthode `DrawLine`, et testez-la dans le programme de `DrawShapes`
2. Complétez le code de la méthode `DrawTriangle`, et testez-la dans le programme de `DrawShapes`
3. Complétez le code de la méthode `DrawCircle`, et testez-la dans le programme de `DrawShapes`
