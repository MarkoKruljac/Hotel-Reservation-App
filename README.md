## PI20-021 Hotel 
(mentor: Zlatko Stapić)

## Projektni tim

Ime i prezime | E-mail adresa (FOI) | JMBAG | Github korisničko ime
------------  | ------------------- | ----- | ---------------------
Marko Kruljac | mkruljac@foi.hr     | 0016129698 | mkruljac98
Dominik Lunko | dlunko@foi.hr       | 0016129271 | DominikLunko
Petar Kozina  | pkozina@foi.hr      | 0016129864 | pkozina

## Opis domene
Izrada aplikacije hotela kojoj su glavne funkcionalnosti CRUD operacije vezane za posjetioce , CRUD operacije vezane za sobe te njezina prodaja različitim iznajmljivačima tako da se svakom iznajmljivaču pri prodaji kreira jedan račun upravitelja koji onda dalje upravlja svojim hotelima i ostalim podacima. Isto tako, aplikacija bi sadržavala izvještaje oko statistike količine posjetioca na dnevnoj, tjednoj, mjesečnoj i godišnjoj razini te duljina njihovog najma soba, a izvješća bi se mogla pohraniti u PDF ili biti ispisana te bi imala mogućnost prikaza u tabličnom ili grafičkom obliku. Nadalje, aplikacija je namijenjena i ispisu računa koji se izdaju samom posjetiocu sukladno njegovim troškovima koji su ostvareni u hotelu te bi podržavala slanje računa na e-mail gosta. Također, jedna od funkcija aplikacije je to da služi zaposlenima kako bi rezervirali sobe te pregledavali one koje su rezervirane od vanjskih korisnika. Osim toga, aplikacija bi imala automatski podsjetnik za rezervacije gdje bi se svako jutro slao mail svim korisnicima koji imaju rezervaciju sljedeći dan. Završeno, aplikacija bi omogućavala izradu dnevnog plana s popisom svih zaprimanja i izdavanja soba koji su planirani za taj dan te pripremom dnevnog rasporeda kako bi se svi gosti primili i ispratili na vrijeme, a sobe pospremile. 
## Specifikacija projekta
Oznaka | Naziv | Kratki opis | Odgovorni član tima
------ | ----- | ----------- | -------------------
F01 | Prijava u aplikaciju | Za pristup hotelu potrebnba je autentikacija korisnika pomoću login funkcionalnosti. Korisnik se logira s podacima koji su mu dodijeljeni prilikom zaposlenja. | Marko Kruljac
F02 | Upravljanje zaposlenicima | Mogućnost pregleda svih zaposlenika, dodavanje, uređivanje i brisanje istih. Ovom funkcijom aplikacije upravlja isključivo administrator. | Petar Kozina
F03 | Upravaljanje rezervacijma | Mogućnost dodavanja, brisanja, pregleda i pretraživanja rezervacija koje su obavljene od strane korisnika. | Dominik Lunko
F04 | Upravljanje dobavljačima | Mogućnost dodavanja, brisanja, pregleda i pretraživanja dobavljača koji su povezani s hotelom. | Dominik Lunko
F05 | Izdavanje računa | Isporuka računa posjetiocima hotela koji se odnose na troškove njihovog boravka. Mogućnost slanja računa na e-mail. | Petar Kozina
F06 | Generiranje izvještaja | Mogućnost generiranja raznih izvještaja te njihov izvoz u PDF format ili ispis na temelju informacija dostupnih u bazi podataka. Mogućnost prikaza izvješća u tabličnom i/ili grafičkom obliku. | Marko Kruljac
F07 | Automatski podsjetnik za rezervacije | Mogućnost slanja svakog jutra e-maila svim gostima koji imaju rezervaciju sljedeći dan. | Dominik Lunko
F08 | Izrada dnevnog plana | Mogućnost izrade dnevnog plana s popisom svih zaprimanja i izdavanja soba koji su planirani za taj dan te tako omogućiti to da se gosti prime i isprate na vrijeme, a sobe pospreme. | Marko Kruljac
F09 | Upravaljanje sobama | Mogućnost pregleda i pretraživanja soba koje određen hotel sadrži. | Petar Kozina


## Tehnologije i oprema
Microsoft Visual Studio 2019, Microsoft SQL server, GitHub, C# (.net), Microsoft Office, Differ 
