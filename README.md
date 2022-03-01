# Evaluation en cours de formation

Une soci�t� sp�cialis�e dans les ressources humaines souhaite changer de syst�me de cvth�que. Elle
fait appel � vos services pour d�velopper la partie Back Office de l�application. La partie Front Office
Web est, quant � elle, d�velopp�e par un autre prestataire et le site est actuellement en cours de
d�veloppement. Vous recevez les donn�es saisies sur la partie web par les candidats sous la forme
d�un fichier csv de la part de cet autre prestataire. Le back office devra exploiter les donn�es du fichier
csv.

Sur la partie Web, un candidat renseigne plusieurs informations :

	- Nom
	- Pr�nom
	- Date de naissance
	- Age
	- 2 lignes d�adresse personnelle
	- Code postal de l�adresse personnelle
	- Ville de l�adresse personnelle
	- Num�ro de t�l�phone fixe
	- Num�ro de t�l�phone portable
	- Email personnel
	- Profil recherch�
	- Comp�tences (maximum 10)
	- Page professionnelle (s�il en a une)
	- Page Linkedin (s�il en a une)
	- Page Viadeo (s�il en a une)
	- Page Facebook professionnelle (s�il en a une)
	- CV au format PDF ou word (docx)

Selon vos informations, les champs qui doivent �tre obligatoires sur le site sont :

	- Nom
	- Pr�nom
	- Date de naissance
	- Num�ro de t�l�phone portable
	- Email personnel
	- Profil recherch�
	- Comp�tences (minimum 5)

L��ge doit �tre calcul� automatiquement par le site mais un bug est connu et en cours sur ce point.
Donc ce calcul automatique sur le site n�est pas op�rationnel. Aucun d�lai n�est pr�vu pour la
r�solution du bug.

Vous recevez �galement tous les fichiers d�pos�s par les candidats, le nom du fichier (sans l�extension)
correspond au num�ro de candidat sur le site.

Vous avez re�u un cahier des charges de la part de la soci�t� cliente dont voici les principaux extraits :

- L�application Back Office doit �tre graphique
- A l�ouverture de l�application, une fen�tre principale s�affiche contenant une liste des
candidats avec leurs informations essentielles (Nom, pr�nom, date de naissance, �ge, num�ro
de t�l�phone portable, email personnel, profil recherch�, ville, toutes les comp�tences
renseign�es par le candidat s�par�es par un retour � la ligne). Cette liste devra �tre tri�e par
d�faut par nom de candidat.
- L��ge de tous les candidats doit appara�tre
- Cette liste doit �tre triable par nom ou par profil recherch� ou par �ge ou par ville. Le tri doit
s�effectuer en cliquant sur l�ent�te de colonne. Deux tris par colonne sont possibles :
� Le nom, la ville, le profil recherch� de A � Z et de Z � A
� L��ge du plus petit au plus grand et du plus grand au plus petit
- Une zone de texte de recherche doit permettre de rechercher les candidats pour une ville
saisie, pour un �ge saisi ou pour une comp�tence saisie. Afin d�aider l�utilisateur, une liste de
suggestions (par rapport aux donn�es pr�sentes pour les candidats) doit appara�tre dans le cas
d�une recherche par comp�tence ou par ville
- Dans le cas d�une recherche, la liste de la fen�tre principale se rafra�chit pour faire appara�tre
le r�sultat de recherche
- Quand on vide la zone de texte de recherche, la totalit� des r�sultats s�affiche de nouveau. Le
crit�re de tri que nous avions utilis� avant la recherche doit s�appliquer de nouveau. Si aucun
tri particulier n��tait pr�sent avant de faire notre recherche, on applique le tri par d�faut.
- Une fonctionnalit� d�ajout de candidat devra �tre possible au cas o� celui-ci ne passe pas par
le d�p�t de candidature sur le site (suite � la r�ception d�un mail par exemple). Une fen�tre
d�ajout pr�sentera la totalit� des champs � remplir pour le candidat. On acc�dera � cette
fen�tre d�ajout par un bouton pr�sent sur la fen�tre principale.
- Une fonctionnalit� de modification des informations des candidats devra �tre possible. En
s�lectionnant un candidat et en appuyant sur un bouton modifier sur la fen�tre principale, on
acc�dera � la totalit� des informations d�un candidat qu�on peut ensuite modifier tant que l�on
veut.
- Une liste des comp�tences devra �tre aliment�e par les donn�es saisies par les candidats. Ce
qui suppose un traitement des doublons. On dispose donc dans l�ajout, la modification, la
recherche, d�une liste de comp�tences nettoy�e (sans doublons) et tri�e par nom.
- En double-cliquant sur un candidat dans la liste de notre fen�tre principale, son cv s�affichera.
Si celui-ci est au format pdf, c�est le navigateur edge qui g�rera l�affichage du CV. Si celui-ci est
au format word (docx), c�est l�application word qui ouvrira le fichier.
- La liste des candidats devra pouvoir �tre export�e sous format CSV. Un bouton d�export sur la
fen�tre principale devra �tre pr�sent. Si la liste est tri�e, le crit�re de tri devra �tre conserv�
dans le fichier d�export CSV. Si la liste contient un r�sultat de recherche, le fichier export� ne
doit contenir que ce r�sultat de recherche. Enfin, apr�s la g�n�ration du fichier CSV,
l�application Excel devra ouvrir directement le fichier export�.

# Travail � r�aliser

R�alisez l�application graphique en C#. Vous disposez de 35 heures pour r�aliser la totalit� des
fonctionnalit�s en suivant les consignes suivantes :

- A la fin du premier jour et toutes les 4 heures � partir du deuxi�me jour, vous devez r�aliser
des tests sur l'application d'un(e) camarade (diff�rent � chaque p�riode de tests). Toutes les
fonctionnalit�s non encore d�velopp�es devront faire appara�tre un message disant � Cette
fonctionnalit� n�a pas �t� d�velopp�e �.
- L'utilisation de GIT n'est pas recommand�e mais obligatoire ainsi que l'utilisation de branches
et un nombre correct de commit convenablement comment�s devra �tre effectu�.
- Tout besoin en ressources architecturales (serveur ou autre) devra faire l'objet d'une demande
aupr�s de l'�quipe Syst�me (votre formateur) qui vous fournira les ressources n�cessaires dans
un d�lai raisonnable (mais avant-hier n'en est pas un). Cette demande devra �tre r�alis�e
avant la fin de la premi�re journ�e de l'�valuation.
- Une documentation sera fournie par vos soins sur tous les �l�ments que vous jugerez
n�cessaires � la compr�hension de votre travail.