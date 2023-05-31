Personne (RazorCRUD).Guide d'installation et de lancement du projet
==============================================

Ce guide fournit les instructions nécessaires pour s'assurer que SQL Server Express est installé, cloner le projet et le lancer sans nécessiter d'actions supplémentaires préalables. Le fichier `program.cs` assure la migration automatiquement.

> Remarque : Veuillez noter que le projet utilise .NET Core 3.1 au lieu de la dernière version (par exemple, .NET 6) en raison de contraintes de temps.

Étapes
------

Suivez les étapes ci-dessous pour installer et exécuter le projet :

### 1\. Vérifier l'installation de SQL Server Express

Assurez-vous que SQL Server Express est installé sur votre système. Si vous ne l'avez pas encore installé, vous pouvez télécharger la dernière version depuis le site officiel de Microsoft et suivre les instructions d'installation appropriées.

### 2\. Cloner le projet

Clonez le projet à partir du référentiel GitHub en utilisant l'une des méthodes suivantes :

#### Méthode 1: Utilisation de l'interface en ligne de commande (CLI) de Git

1.  Ouvrez un terminal ou une fenêtre de commande.
    
2.  Accédez au répertoire dans lequel vous souhaitez cloner le projet.
    
3.  Exécutez la commande suivante pour cloner le projet :
    
    bashCopy code
    
    `git clone <URL_du_référentiel>`
    
    Remplacez `<URL_du_référentiel>` par l'URL du référentiel GitHub.
    

#### Méthode 2: Téléchargement direct

1.  Accédez au référentiel GitHub à l'URL suivante : `<URL_du_référentiel>`.
2.  Cliquez sur le bouton "Code" (ou "Code" en anglais).
3.  Sélectionnez "Download ZIP" (ou "Download ZIP" en anglais) pour télécharger le projet sous forme de fichier ZIP.
4.  Extrayez le contenu du fichier ZIP dans le répertoire de votre choix.

### 3\. Lancer le projet

Une fois le projet cloné, suivez ces étapes pour le lancer :

1.  Ouvrez le projet dans votre environnement de développement préféré.
2.  Accédez au fichier `program.cs` dans le projet.
3.  Assurez-vous que toutes les dépendances nécessaires sont installées (vérifiez le fichier `README.md` ou consultez la documentation du projet pour plus d'informations).
4.  Exécutez le projet en appuyant sur la touche de démarrage appropriée dans votre environnement de développement ou en utilisant la commande appropriée dans votre CLI.

Lors du lancement du projet, le fichier `program.cs` se chargera automatiquement de la migration, s'assurant ainsi que les modifications nécessaires sont apportées à la base de données.

C'est tout ! Vous devriez maintenant pouvoir cloner le projet, lancer l'application et bénéficier de la migration automatique sans avoir à effectuer de préparation supplémentaire.

N'hésitez pas à consulter la documentation du projet ou à contacter les développeurs si vous rencontrez des problèmes ou avez besoin d'une assistance supplémentaire.

Bon développement !