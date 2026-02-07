// jednoduche_datove_typy.cpp : Tento soubor obsahuje funkci main. Provádění programu se tam zahajuje a ukončuje.
//

#include <iostream>

using namespace std;

int main()
{
	int n;
	cout << "Zadejte cele cislo n:";
	cin >> n;
	int soucetAscii = 0;
	int soucetCifer = 0;
	bool vetsiSoucet = false;

	for (int i = 0; i < n && !vetsiSoucet; i++) {
		cout << "Zadejte " << i + 1 << ". znak: " << endl;
		char ch;
		cin >> ch;

		soucetAscii += ch;

		if (ch > '0' && ch <= '9') {
			soucetCifer += ch - '0';
		}

		if (soucetAscii > 1000) {
			vetsiSoucet = true;
		}
	}

	cout << "Soucet cifer je: " << soucetCifer << endl;

	if (vetsiSoucet) {
		cout << "Soucet ASCII kodu je vetsi jak 1000" << endl;
	}
	else {
		cout << "Soucet ASCII kodu neni vetsi jak 1000" << endl;
	}
}
