// 03.cpp : Tento soubor obsahuje funkci main. Provádění programu se tam zahajuje a ukončuje.
//

#include <iostream>

using namespace std;

int main()
{
    int n;
    cout << "Zadejte cislo n pro pocet prvku znaku:";
	cin >> n;
    int pocetznaku = 0;
    char znak;
    int pocetintreval = 0;
	bool interval = false;
    do {
        cin >> znak;
		pocetznaku++;
        if (znak >= '8' && znak <= 'P') {
            pocetintreval++;
        }
		if (pocetintreval >= 3) {
			interval = true;
		}

        if (znak >= 'A' && znak <= 'Z') {
            cout << "(" << (int)znak  << "), " <<  (char)((int)znak - 1) << endl;

        }
        else {
            cout << "(" << (int)znak  << ")" << endl;
        }

    } while (pocetznaku < n && !interval);

	if (interval) {
		cout << "Zadali jste 3 znaky z intervalu 8-P" << endl;
	}
    else {
		cout << "Nebyly zadany zadne cislice z intervalu 8-P" << endl;
    }
}