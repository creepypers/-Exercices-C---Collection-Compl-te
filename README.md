# Exercices C# - Collection Complète

## Description

Ce projet contient les solutions pour 7 exercices de programmation en C#. Il s'agit d'une application console qui propose un menu interactif permettant de tester différents algorithmes et fonctionnalités. Le projet est maintenant organisé de manière modulaire avec chaque exercice dans son propre fichier.

## Structure du Projet

```
SolT1/
├── SolT1.sln                    # Solution Visual Studio
├── SolT1/
│   ├── SolT1.csproj            # Projet C# (ExercicesCSharp)
│   ├── Program.cs               # Point d'entrée principal et menu
│   ├── Exercice1_Kayak.cs      # Exercice 1 : Calcul des prix kayak
│   ├── Exercice2_KayakPlus.cs  # Exercice 2 : Gestion multi-familles
│   ├── Exercice3_MaxTaxe.cs    # Exercice 3 : Calcul des taxes
│   ├── Exercice4_ChangerLaCasse.cs # Exercice 4 : Transformation de chaînes
│   ├── Exercice5_Password.cs   # Exercice 5 : Générateur de mots de passe
│   ├── Exercice6_E.cs          # Exercice 6 : Dessin de la lettre E
│   ├── Exercice7_QCM.cs        # Exercice 7 : Système de quiz
│   ├── App.config              # Configuration de l'application
│   └── Properties/             # Propriétés de l'assembly
```

## Prérequis

- **Framework .NET** : Version 4.7.2 ou supérieure
- **IDE** : Visual Studio 2017+ ou Visual Studio Code avec extensions C#
- **Système d'exploitation** : Windows, macOS ou Linux

## Installation et Compilation

1. **Cloner ou télécharger** le projet
2. **Ouvrir** le fichier `SolT1.sln` dans Visual Studio
3. **Restaurer** les packages NuGet si nécessaire
4. **Compiler** le projet (Ctrl+Shift+B)
5. **Exécuter** l'application (F5)

## Architecture Modulaire

Le projet suit maintenant une architecture modulaire et organisée :

- **Program.cs** : Point d'entrée principal avec menu et routage vers les exercices
- **Classes statiques** : Chaque exercice est implémenté dans sa propre classe avec des méthodes publiques
- **Séparation des responsabilités** : Chaque fichier gère un exercice spécifique
- **Maintenabilité** : Facilite la modification et l'extension des exercices

## Fonctionnalités

### 1. 🚣‍♂️ Kayak (`Exercice1_Kayak.cs`)
- **Objectif** : Calculer le prix des locations de kayak selon l'âge
- **Tarifs** :
  - Moins de 2 ans : Gratuit
  - 2-11 ans : 5$
  - 12-64 ans : 12$
  - 65+ ans : 10$
- **Méthode** : `Exercice1_Kayak.Kayak()`

### 2. 🚣‍♂️ KayakPlus (`Exercice2_KayakPlus.cs`)
- **Objectif** : Gestion des locations pour plusieurs familles avec statistiques
- **Fonctionnalités** :
  - Calcul des prix par famille
  - Comptage des personnes par catégorie d'âge
  - Total des recettes de la journée
- **Méthode** : `Exercice2_KayakPlus.Kayakplus()`

### 3. 💰 MaxTaxe (`Exercice3_MaxTaxe.cs`)
- **Objectif** : Calculer les taxes pour 6 couples et identifier celui qui paie le plus
- **Taux d'imposition** :
  - ≤ 25 000$ : 0%
  - 25 001$ - 60 000$ : 15%
  - > 60 000$ : 20%
- **Réduction** : 2% par enfant
- **Méthode** : `Exercice3_MaxTaxe.MaxTaxe()`

### 4. 🔤 ChangerLaCasse (`Exercice4_ChangerLaCasse.cs`)
- **Objectif** : Transformer une chaîne de caractères
- **Transformations** :
  - Espaces → #
  - Minuscules → Majuscules
  - Majuscules → Minuscules
  - Autres caractères → Inchangés
- **Méthode** : `Exercice4_ChangerLaCasse.ChangerLaCasse()`

### 5. 🔐 Password (`Exercice5_Password.cs`)
- **Objectif** : Générer un mot de passe aléatoire
- **Composition** :
  - Lettres minuscules (a-z)
  - Lettres majuscules (A-Z)
  - Chiffres (0-9)
- **Méthode** : `Exercice5_Password.Password()`

### 6. 📐 E (`Exercice6_E.cs`)
- **Objectif** : Dessiner la lettre "E" en console
- **Personnalisation** :
  - Nombre de lignes et colonnes configurables
  - Choix du caractère (* ou ♥)
- **Méthode** : `Exercice6_E.E()`

### 7. ❓ QCM (`Exercice7_QCM.cs`)
- **Objectif** : Système de quiz à choix multiples
- **Fonctionnalités** :
  - 10 questions prédéfinies
  - 4 questions aléatoires par session
  - 3 choix par question
  - Notation : A (4/4), B (3/4), D (2/4), E (0-1/4)
- **Méthode** : `Exercice7_QCM.QCM()`

## Utilisation

1. **Lancer** l'application
2. **Choisir** un exercice (1-7) dans le menu
3. **Suivre** les instructions à l'écran
4. **Retourner** au menu principal après chaque exercice
5. **Quitter** avec -1

## Développement

### Ajouter un nouvel exercice
1. Créer un nouveau fichier `Exercice8_Nom.cs`
2. Implémenter une classe statique avec la méthode publique
3. Ajouter l'option dans le menu principal de `Program.cs`
4. Ajouter le fichier au projet dans `SolT1.csproj`

### Modifier un exercice existant
1. Localiser le fichier correspondant
2. Modifier la logique selon les besoins
3. Tester les modifications
4. Recompiler le projet

### Structure d'un exercice
```csharp
using System;

namespace SolT1
{
    public static class ExerciceX_Nom
    {
        public static void NomMethode()
        {
            // Logique de l'exercice
        }
        
        private static void MethodePrivee()
        {
            // Méthodes utilitaires privées
        }
    }
}
```

## Avantages de la Structure Modulaire

✅ **Organisation** : Chaque exercice a son propre fichier  
✅ **Maintenabilité** : Facile de modifier un exercice sans affecter les autres  
✅ **Lisibilité** : Code plus clair et structuré  
✅ **Réutilisabilité** : Possibilité d'utiliser les classes dans d'autres projets  
✅ **Débogage** : Plus facile de localiser et corriger les problèmes  
✅ **Collaboration** : Plusieurs développeurs peuvent travailler sur différents exercices  

## Dépannage

### Erreurs courantes
- **FormatException** : Vérifier que les entrées utilisateur sont des nombres valides
- **IndexOutOfRangeException** : Contrôler les limites des tableaux
- **Console.ReadKey()** : Attendre l'appui d'une touche pour continuer

### Solutions
- Toujours valider les entrées utilisateur
- Utiliser des boucles `do-while` pour la saisie
- Gérer les cas limites et les erreurs

## Licence

Ce projet est destiné à des fins éducatives et de formation.

## Contact

Pour toute question ou suggestion concernant ce projet, veuillez contacter l'équipe de développement.

---

**Note** : Ce projet est conçu pour l'apprentissage des concepts de base de la programmation en C# et peut être utilisé comme référence pour d'autres exercices similaires. La structure modulaire facilite l'apprentissage et la maintenance du code.
