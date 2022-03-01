# Evaluation en cours de formation

Une société spécialisée dans les ressources humaines souhaite changer de système de cvthèque. Elle
fait appel à vos services pour développer la partie Back Office de l’application. La partie Front Office
Web est, quant à elle, développée par un autre prestataire et le site est actuellement en cours de
développement. Vous recevez les données saisies sur la partie web par les candidats sous la forme
d’un fichier csv de la part de cet autre prestataire. Le back office devra exploiter les données du fichier
csv.

Sur la partie Web, un candidat renseigne plusieurs informations :

	- Nom
	- Prénom
	- Date de naissance
	- Age
	- 2 lignes d’adresse personnelle
	- Code postal de l’adresse personnelle
	- Ville de l’adresse personnelle
	- Numéro de téléphone fixe
	- Numéro de téléphone portable
	- Email personnel
	- Profil recherché
	- Compétences (maximum 10)
	- Page professionnelle (s’il en a une)
	- Page Linkedin (s’il en a une)
	- Page Viadeo (s’il en a une)
	- Page Facebook professionnelle (s’il en a une)
	- CV au format PDF ou word (docx)

Selon vos informations, les champs qui doivent être obligatoires sur le site sont :

	- Nom
	- Prénom
	- Date de naissance
	- Numéro de téléphone portable
	- Email personnel
	- Profil recherché
	- Compétences (minimum 5)

L’âge doit être calculé automatiquement par le site mais un bug est connu et en cours sur ce point.
Donc ce calcul automatique sur le site n’est pas opérationnel. Aucun délai n’est prévu pour la
résolution du bug.

Vous recevez également tous les fichiers déposés par les candidats, le nom du fichier (sans l’extension)
correspond au numéro de candidat sur le site.

Vous avez reçu un cahier des charges de la part de la société cliente dont voici les principaux extraits :

- L’application Back Office doit être graphique
- A l’ouverture de l’application, une fenêtre principale s’affiche contenant une liste des
candidats avec leurs informations essentielles (Nom, prénom, date de naissance, âge, numéro
de téléphone portable, email personnel, profil recherché, ville, toutes les compétences
renseignées par le candidat séparées par un retour à la ligne). Cette liste devra être triée par
défaut par nom de candidat.
- L’âge de tous les candidats doit apparaître
- Cette liste doit être triable par nom ou par profil recherché ou par âge ou par ville. Le tri doit
s’effectuer en cliquant sur l’entête de colonne. Deux tris par colonne sont possibles :
• Le nom, la ville, le profil recherché de A à Z et de Z à A
• L’âge du plus petit au plus grand et du plus grand au plus petit
- Une zone de texte de recherche doit permettre de rechercher les candidats pour une ville
saisie, pour un âge saisi ou pour une compétence saisie. Afin d’aider l’utilisateur, une liste de
suggestions (par rapport aux données présentes pour les candidats) doit apparaître dans le cas
d’une recherche par compétence ou par ville
- Dans le cas d’une recherche, la liste de la fenêtre principale se rafraîchit pour faire apparaître
le résultat de recherche
- Quand on vide la zone de texte de recherche, la totalité des résultats s’affiche de nouveau. Le
critère de tri que nous avions utilisé avant la recherche doit s’appliquer de nouveau. Si aucun
tri particulier n’était présent avant de faire notre recherche, on applique le tri par défaut.
- Une fonctionnalité d’ajout de candidat devra être possible au cas où celui-ci ne passe pas par
le dépôt de candidature sur le site (suite à la réception d’un mail par exemple). Une fenêtre
d’ajout présentera la totalité des champs à remplir pour le candidat. On accèdera à cette
fenêtre d’ajout par un bouton présent sur la fenêtre principale.
- Une fonctionnalité de modification des informations des candidats devra être possible. En
sélectionnant un candidat et en appuyant sur un bouton modifier sur la fenêtre principale, on
accèdera à la totalité des informations d’un candidat qu’on peut ensuite modifier tant que l’on
veut.
- Une liste des compétences devra être alimentée par les données saisies par les candidats. Ce
qui suppose un traitement des doublons. On dispose donc dans l’ajout, la modification, la
recherche, d’une liste de compétences nettoyée (sans doublons) et triée par nom.
- En double-cliquant sur un candidat dans la liste de notre fenêtre principale, son cv s’affichera.
Si celui-ci est au format pdf, c’est le navigateur edge qui gèrera l’affichage du CV. Si celui-ci est
au format word (docx), c’est l’application word qui ouvrira le fichier.
- La liste des candidats devra pouvoir être exportée sous format CSV. Un bouton d’export sur la
fenêtre principale devra être présent. Si la liste est triée, le critère de tri devra être conservé
dans le fichier d’export CSV. Si la liste contient un résultat de recherche, le fichier exporté ne
doit contenir que ce résultat de recherche. Enfin, après la génération du fichier CSV,
l’application Excel devra ouvrir directement le fichier exporté.

# Travail à réaliser

Réalisez l’application graphique en C#. Vous disposez de 35 heures pour réaliser la totalité des
fonctionnalités en suivant les consignes suivantes :

- A la fin du premier jour et toutes les 4 heures à partir du deuxième jour, vous devez réaliser
des tests sur l'application d'un(e) camarade (différent à chaque période de tests). Toutes les
fonctionnalités non encore développées devront faire apparaître un message disant « Cette
fonctionnalité n’a pas été développée ».
- L'utilisation de GIT n'est pas recommandée mais obligatoire ainsi que l'utilisation de branches
et un nombre correct de commit convenablement commentés devra être effectué.
- Tout besoin en ressources architecturales (serveur ou autre) devra faire l'objet d'une demande
auprès de l'équipe Système (votre formateur) qui vous fournira les ressources nécessaires dans
un délai raisonnable (mais avant-hier n'en est pas un). Cette demande devra être réalisée
avant la fin de la première journée de l'évaluation.
- Une documentation sera fournie par vos soins sur tous les éléments que vous jugerez
nécessaires à la compréhension de votre travail.