Zadanie 1
-------------
Do projektu Zoo dodaj klasę SmokWawelski, klasa powinna implementować podobne metody do zaimplementowanych w klasie Wilk.
Zaadoptuj klasę SmokWawelski (podobnie jak zrobiono to w przypadku klasy Wilk) i dodaj do fabryki oraz menu programu głównego.

Zadanie 2
-------------
Napisz klasę Towar posiadającą publiczne pola: 
nazwa, cena oraz ilosc 
i wirtualną metodę Opis wyświetlającą na standardowym wyjściu wszystkie informacje przechowywane w obiekcie.
Zaimplementuj następujące klasy pochodne klasy Towar:
- Gwozdzie: posiadająca dodatkowe publiczne pola długosc, grubosc i rodzaj_lepka,
- PapierScierny: posiadająca dodatkowe publiczne pola ziarnistosc i szerokosc,
- Meble: posiadająca dodatkowe pole nazwaKolekcji.
Wszystkie klasy pochodne klasy Towar powinny mieć przeciążoną metodę Opis.

Zaimplementuj klasę Szafa pochodną klasy Meble. 
Klasa Szafa powinna posiadać publiczne pola wysokosc, szerokosc i glebokosc. 
Metoda Opis powinna zostać przeciążona w taki sposób, żeby wykorzystać kod metody Opis z klas bazowych.

Przetestuj swoje rozwiązanie.