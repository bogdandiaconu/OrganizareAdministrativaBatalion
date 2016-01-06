				       -------------------------------------------
				       -Organizarea Administrativa a Batalionului-
				       -------------------------------------------


	Aplicatia noastra are in vedere accesul la o baza de date care contine informatii legate de costul suportat de Academie pentru fiecare student. Baza de date tine evidenta studentilor, a companiilor, a administratorilor de companie, a elementelor de tinuta, a drepturilor si a numarului de zile de alocare la hrana, pentru fiecare student.
	Scopul principal al aplicatiei este de a facilita calculul datoriilor pe care fiecare student le are fata de academie si o mai buna organizare administrativa.
					


					=========================================
				       ==================Tabele===================
					=========================================

	1. Student - Aceasta tabela contine cate o intrare pentru fiecare student in parte. Fiecare intrare contine informatii, precum: Nume, Prenume, ID_Grad, CNP, Adresa si ID_Companie.
	2. Grade - Aceasta tabela contine cate o intrare pentru fiecare grad. Motivul existentei acestei tabele este de a facilita si optimiza actualiarea gradelor studentilor. Legatura dintre tabela Student si Grade se face prin ID_Grad, prezenta in ambele.
	3. Companie - Aceasta tabela contine cate o intrare pentru fiecare Companie din cadrul batalionului. Asemeni tabelei Grade, motivul acestei tabele este de a facilita si optimiza actualizarea apartenetei unui student la o Companie, cat si un punct de legatura cu Comandantul Companiei si Administratorul acesteia.
	4. CDT_Comp - O tabela simpla ce contine numele, prenumele, id-ul si id-ul gradului fiecarui comandant de companie.
	5. Administratori - O tabela simpla ce contine numele, prenumele, id-ul si id-ul gradului administratorului.
	6. ArticoleVest - Aceasta tabela contine cate o coloana pentru ID-ul studentului, ID-ul administratorului, Data si toate articolele vestimentare la care studentul are dreptul. Pentru fiecare alocare a unuia sau mai multor elemente vestimentare, in tabel va fi introdusa o intrare unde, in dreptul fiecarui produs este introdusa cantitatea primita, inclusiv 0.
	7. ArticoleDrepturi - Aceasta tabela are o structura asemanatoare cu tabela ArticoleVest, diferenta constand in categoria din care produsele apartin.
	8. AlocareHrana - In aceasta tabela se tine evidenta numarului de zile in care fiecare studet a fost alocat la masa. De fiecare data cand se doreste adaugarea unei noi intrari, se cauta in tabela combinatia (ID_Student, ID_Pret); daca aceasta este gasita, atunci se incrementeaza campul Count cu numarul de zile pentru care studentul a mai fost alocat la masa. In caz contrar, se creaza o noua intrare.
	9.
	10. Preturi - Aceasta tabela contine informatii legate de pretul fiecarui produs, cat si data de la care acest pret este valabil. O modificare a unui pret consta in adaugarea unei noi intrari, si nu modificarea valorii vechi.



					=========================================
			               =================Task-uri==================
					=========================================

	
	-Insert/Update/Delete pentru fiecare tabel
	-Calculul si Afisarea cheltuielilor pentru un student specificat
	-Afisarea produselor pe care un student le-a primit
	-Procedura care va face avansarea in grad a unui student/ofiter/subofiter
	-
	-
	-



	Vom completa pe parcurs toate facilitatile de care programul dispune.














