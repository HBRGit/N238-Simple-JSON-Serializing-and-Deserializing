# N238-Simple-JSON-Serializing-and-Deserializing
Opgave fra Bogen om C#

Du skal oprette en konsolapplikation i C#, der arbejder med JSON serialisering og deserialisering. Applikationen skal have en klasse Person med egenskaberne Navn (string) og Alder (int). Applikationen skal tillade brugeren at indtaste en persons data og gemme den i en JSON-fil. Der skal ogs� v�re en mulighed for at l�se og vise personens data fra denne fil. Der skal kun bruges �n fast fil (f.eks. persondata.json) til at gemme og hente persondata.

Applikationen skal have en simpel konsolmenu med f�lgende muligheder:

Tilf�j ny person
Vis person
Afslut
Brugeren skal kunne v�lge en handling ved at indtaste et tal, og applikationen skal reagere i overensstemmelse hermed.

Eksempel p� Brug
N�r applikationen k�rer, pr�senteres brugeren for f�lgende menu:


V�lg en handling:
1. Tilf�j ny person
2. Vis person
3. Afslut
Brugeren indtaster 1 for at tilf�je en ny person, og applikationen beder om navn og alder. Efter at have indtastet disse oplysninger, gemmes personens data i persondata.json. Hvis brugeren derefter v�lger 2, vises den gemte persons data i konsollen.