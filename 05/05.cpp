// 05.cpp : Tento soubor obsahuje funkci main. Provádění programu se tam zahajuje a ukončuje.
//

#include <iostream>

using namespace std;

int main()
{
	char znak;
	cout << "Zadavejte znaky, konec je znakem \\ " << endl;

	int male = 0;
	int velke = 0;
	int cislice = 0;
	int znaky = 0;
	int sude;

	do {
		cin >> znak;

		if (znak >= 'a' && znak <= 'z') {
			male++;
		}
		else if (znak >= 'A' && znak <= 'Z') {
			velke++;
		}
		else if (znak >= '0' && znak <= '9') {
			cislice++;
			if (znak % 2 == 0) {
				sude = znak;
			}
		}
		else if(znak == '+' || znak == '-' || znak == '*' || znak == '/' || znak == '%') {
			znaky++;
		}

	} while (znak != '\\');

	cout << "Zadali jste " << male << " malych pismen, " << velke << " velkych pismen, " << cislice << " cislic, " << znaky << " znaku a " << sude - '0' << " - tuto sudou cislici" << endl;
}