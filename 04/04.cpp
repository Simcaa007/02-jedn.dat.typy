// 04.cpp : Tento soubor obsahuje funkci main. Provádění programu se tam zahajuje a ukončuje.
//

#include <iostream>

using namespace std;


int main()
{
    char znak;
	bool licha = false;
	cout << "Zadavejte znaky a program se ukonci az zadate *" << endl;

    do {
		cin >> znak;
		if (znak >= '0' && znak <= '9' && znak % 2 != 0) {
			licha = true;
		}
		cout << "(" << (int)znak << ", " << (char)((int)znak -1) << ", " << (char)((int)znak + 1) << ")" << endl;

	} while (znak != '*' && !licha);
    
	if (licha) {
		cout << "Bylo zadano liche cislo" << endl;
	}
	else {
		cout << "Nebylo zadano zadne liche cislo" << endl;
	}

}