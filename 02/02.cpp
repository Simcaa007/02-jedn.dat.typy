// 02.cpp : Tento soubor obsahuje funkci main. Provádění programu se tam zahajuje a ukončuje.
//

#include <iostream>

using namespace std;

int main()
{
	char znak;
	cout << "Zadejte znaky za sebou dokud nezadate *" << endl;
	bool alfa = false;
	int soucetalfa = 0;


	do {
		cin >> znak;

		if (znak >= 'a' && znak <= 'z') {
			cout << "(" << (char)(znak - 32) << ")" << endl;
		}
		else if (znak >= 'A' && znak <= 'Z') {
			cout << "(" << (char)(znak + 32) << ")" << endl;
		}

		if (znak >= 'a' && znak <= 'z' || znak >= 'A' && znak <= 'Z' || znak >= '0' && znak <= '9') {
			soucetalfa++;
		}

		if (soucetalfa >= 5) {
			alfa = true;
		}

	} while (znak != '*' && !alfa);

	if (alfa) {
		cout << "Zadali jste 5 alfanumerickych znaku" << endl;
	}
}
