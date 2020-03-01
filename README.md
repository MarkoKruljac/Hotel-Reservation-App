# Inicijalne upute za prijavu projekta iz Programskog inženjerstva

Poštovane kolegice i kolege, 

čestitamo vam jer ste uspješno prijavili svoj projektni tim na kolegiju Programsko inženjerstvo, te je za vas automatski kreiran repozitorij koji ćete koristiti za verzioniranje vašega koda, ali i za pisanje dokumentacije.

Ovaj dokument (README.md) predstavlja **osobnu iskaznicu vašeg projekta**. Vaš prvi zadatak, ukoliko niste odabrali da želite raditi na projektu sa gospodarstvom je **prijaviti vlastiti projektni prijedlog** na način da ćete prijavu vašeg projekta, sukladno uputama danim u ovom tekstu, napisati upravo u ovaj dokument, umjesto ovoga teksta.

Za upute o sintaksi koju možete koristiti u ovom dokumentu i kod pisanje vaše projektne dokumentacije pogledajte [ovaj link](https://guides.github.com/features/mastering-markdown/).

Nakon vaše prijave bit će vam dodijeljen mentor s kojim ćete tijekom semestra raditi na ovom projektu. A sada, vrijeme je da prijavite vaš projekt. Za prijavu vašeg projektnog prijedloga molimo vas koristite **predložak** koji je naveden u nastavku, a započnite tako da kliknete na *olovku* u desnom gornjem kutu ovoga dokumenta :) 

## Hotel

## Projektni tim

Ime i prezime | E-mail adresa (FOI) | JMBAG | Github korisničko ime
------------  | ------------------- | ----- | ---------------------
Marko Kruljac | mkruljac@foi.hr     | 0016129698 | mkruljac98
Dominik Lunko | dlunko@foi.hr       | 0016129271 | DominikLunko
Petar Kozina  | pkozina@foi.hr      | 0016129864 | pkozina

## Opis domene
Izrada aplikacije hotela kojoj su glavne funkcionalnosti CRUD operacije vezane za posjetioce , CRUD operacije vezane za sobe. Isto tako, aplikacija bi sadržavala izvješta oko statistike količine posjetioca na dnevnoj, tjednoj, mjesečnoj i godišnjoj razini te duljina njihovog najma soba. Također, aplikacija je namijenja i ispisu računa koja se izdaje samom posjetiocu sukladno s njihovim troškovima koji su ostvrareni u hotelu, a služi i zaposlenima kako rezervirali sobe te pregledavali one koje su rezervirane od vanjskih korisnika.

## Specifikacija projekta
Oznaka | Naziv | Kratki opis | Odgovorni član tima
------ | ----- | ----------- | -------------------
F01 | Prijava u aplikaciju | Za pristup hotelu potrebnba je autentikacija korisnika pomoću login funkcionalnosti. Korisnik se logira s podacima koji su mu dodijeljeni prilikom zaposlenja. | Marko Kruljac
F02 | Upravljanje zaposlenicima | Mogućnost pregleda svih zaposlenika, dodavanje, uređivanje i brisanje istih. Ovom funkcijom aplikacije upravlja isključivo administrator. | Dominik Lunko
F03 | Upravljanje sobama | Mogućnost dodavanja, brisanja, pregleda i pretraživanje soba u hotelu. | Petar Kozina 
F04 | Upravljanje posjetiocima | Mogućnost dodavanja, brisanja, pregleda i pretraživanja posjetioca u hotelu. | Dominik Lunko
F05 | Rezervacija soba | Mogućnost rezervacije soba od strane korisnika. Rezervacija se može obaviti na fizički način ili putem dostupnog linka za rezervaciju. | Marko Kruljac 
F06 | Upravaljanje rezervacijma | Mogućnost dodavanja, brisanja, pregleda i pretraživanja rezervacija koje su obavljene od strane korisnika. | Petar Kozina
F07 | Upravljanje dobavljačima | Mogućnost dodavanja, brisanja, pregleda i pretraživanja dobavljača koji su povezani s hotelom. | Marko Kruljac
F08 | Izdavanje računa | Isporuka računa posjetiocima hotela koji se odnose na troškove njihovog boravka. | Dominik Lunko
F09 | Generiranje izvještaja | Mogućnost generiranja raznih izvještaja te njihov izvoz u PDF format na temelju informacija dostupnih u bazi podataka. | Petar Kozina

## Tehnologije i oprema
Microsoft Visual Studio 2019, Microsoft SQL server, GitHub, C# (.net), Microsoft Office, Differ 
