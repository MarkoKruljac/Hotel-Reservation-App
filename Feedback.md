## UVID U PROJEKT

## Korisnička dokumentacija
* Vidim plan za korisničku dokumentaciju. Mežutim, korisničku dokumentaciju ne morate stavljati u wiki. Dovoljno je napraviti kontekstualno osjetljivu pomoć u aplikaciji. Moj prijedlog je CHM dokument koji se vrlo lako pomoću postojećih klasa za pomoć u C# može koristiti i kontekstualno otvarati.

## Projektna dokumentacija
* Metodika razvoja: Vodopadni model, nema reference na izvor. 
* Projektni plan: Usklađen s predloženim modelom. Pojedinačna opterećenja članova tima nisu prikazana.
* Izračun troškova -> Ok
* Ponuda naručitelju -> Nije priložena. Predlažem pogledati: https://www.pandadoc.com/sales-proposal-template/. Vaša ponuda može biti i jedna A4 stranica, ali mora sadržavati sve bitne komponente.
* Praćenje provedbe -> Nije uključeno.

## Tehnička dokumentacija
* Tehnička dokumentacija nema jasno podijeljena poglavlja koja se odnose na specifikaciju korisničkih zahtjeva i detaljnu specifikaciju programskog proizvoda. Dakle, potrebno je dodati SRS i SDS poglavlja. Za svako poglavlje potražite primjere dobre prakse i odlučite što je važno za vaš projekt. Jedan primjer je ovo: https://www.perforce.com/blog/alm/how-write-software-requirements-specification-srs-document
* Poglavlje 1.1. ne sadrži dijagram slučajeva korištenja.
* Sadržaj ste grupirali po tipu informacija a ne po funkcionalnostima ili drugim aspektima važnim za projekt ili za tim. Stoga, moj prijedlog je da se taj dio restrukturira te da sav sdržaj bude smješten u ono poglavlje na koje se odnosi to jest ovisno o funkcionalnim ili nefunkcionalnim zahtjevima. Ta poglavlja bi u sebi sadržavala sve što je važno za taj zahtjev (od opisa slučaja korištenja, dijela modela podataka, skice sučelja, integracije i interakcije s drugim funkcionalnostima opisane dijagramima aktivnosti, slijeda i slično). Ovu promjenu nije teško napraviti jer većinu tih artefakata već imate.
* Poglavlja nemojte imenovati po dijagramima. Zapamtite da poglavlja nisu tu zbog dijagrama, već su dijagrami tu da vam pomognu da iskomunicirate neku drugu temu, bilo da se radi i strukturi dokumenta, tijeku podataka ili aktivnosti, stanjima ili bilo kojoj drugoj specifikaciji. Stoga, osim izmjene naziva poglavlja, koristite i ostale UML dijagrame gdje je prikladno i potrebno.
* UC: Sintaksički ispravni uz izuzetak prvog dijagrmaa koji ima malu sintaksičku pogrešku. 
* AD: Sintaksički ispravni.
* CD: Dijagram nije pregledan. Podijeliti ga na više specifičnih dijagrama kako je navedeno u komentaru o restrukturiranju.
* Semantiku i usklađenost svih dijagama s kodom ćemo provjeravati na obrani.
* U dokumentaciju dodati poglavlje s uputama za podešavanje razvojne i produkcijske okoline te s podacima o testiranju programa (npr. korisnička imena i lozinke).

## Implementacija
* Pogledana trenutna verzija aplikacije.
* Objektno orijentirano programiranje -> Ok.
* Struktura projekta -> Ok. Nastavite klase grupirati u područja imena.
* Razmislite o korištenju cijelog zaslona u dizajnu vaših formi. Pomoću sidra (anchor) možete podesiti da aplikacija iskorištava cijeli dostupni prostor. Isto tako, razmislite o korištenju MDI pristupa. Jednu formu proglasite MDI formom, a ostale proglasite MDI djecom. To vam u mnogočemu olakšava.
* Implementirane funkcionalnosti - Početna razina. Implementacija kasni za planom.
* Verzioniranje - predlažem da sve što se radi s dokumentacijom radite u posebnoj grani koja bi se mogla zvati "Dokumentacija". Također, koristite Development granu u koju ćete spajati svaku funkcionalnost kada je gotova. Nakon što se integracija (na development grani) istestira i nakon što je sve u redu, tek onda se kod spaja na master (produkcijsku granu). Vezano za workflow razvoja (ne vezano za dokumentaciju) pokušajte primijeniti feature-branch workflow koji je opisan ovdje: https://www.atlassian.com/git/tutorials/comparing-workflows/feature-branch-workflow. Više pozornosti usmjerite na pripremu dokumenata za verziju (staging) i na kvalitetne komentare kod verzija.
* .gitignore: nije dobar. Molim vas da osigurate da se odmah nakon povlačenja repozitorija programski kod može kompajlirati i pokrenuti, a da se pri tome ne zaprlja repozitorij. To znači da morate verzionirati sve fajlove koje Visual Studio ne kreira sam, a one koje kreira sam morate ignorirati pomoću odgovarajuće .gitignore datoteke.

## Ostalo
* Home stranica vaše dokumentacije može sadržavati podatke iz prijave projekta ili sami možete odlučiti što staviti na tu stranicu koja je osobna iskaznica projekta, tima i dokumentacije.
* U dokumentaciji bi bilo dobro složiti da se klikom na sliku ista slika otvori u full screen prikazu.  
  Markup je: ```[ ![](image.jpg) ](image.jpg)```
* Pazite na minimalne zahtjeve za programske proizvode prije nego što pristupite obrani (npr. izdvajanje jednog dijela projekta u dll, kontekstualna pomoć).

## Bodovi
P1: 9 bodova

---
---

## Opća povratna informacija
Projektna prijava se prihvaća uz elemente dopune koje navodim u nastavku. Projektna ideja je u skladu sa zahtjevima kolegija. Implementacijom konačnog seta funkcionalnosti (nadopunjeno) studenti će moći postići sve ishode učenja na kolegiju. Molim da temeljem ovih informacija sami dopunite vašu projektnu prijavu.

## Arhitektura u odnosu na bazu podataka
Također molim da arhitektura sustava bude temeljena na centraliziranoj bazi podataka na koju će se spajati jedna ili više aplikacija istovremeno. Ovaj zahtjev treba uzeti u obzir kao aspekt kroz dizajn i implementaciju ostalih funkcionalnosti (npr. da se ista soba ne rezervira dva puta za jedna termin ako različiti korisnici vrše rezervaciju u isto vrijeme).

## Zahtijevane dopune
1. Omogućiti prodaju ove aplikacije različitim iznajmljivačima. Svakom iznajmljivaču se pri prodaju kreira jedan račun upravitelja koji onda dalje upravlja svojim hotelima i ostalim podacima kako je sada prijavljeno.
2. Automatski podsjetnik za rezervacije. Svako jutro se pošalje mail svim korisnicima koji imaju rezervaciju sljedeći dan. 
3. Kod izrade računa omogućiti slanje računa na e-mail gosta.
4. Kod izrade izvješća uključiti tablične i grafičke prikaze te pohranu u PDF ili ispis.
5. Omogućiti izradu dnevnog plana s popisom svih zaprimanja i izavanja soba koji su planirani za taj dan te pripremom dnevnog rasporeda kako bi se svi gosti primili i ispratili na vrijeme, a sobe pospremile.

Nove funkcionalnosti podijelite na način da ukupno opterećenje svih članova tima bude približno jednako.
