#include <iostream>

using namespace std;

int main()
{
    int liczba, ilosc = 0, poprzednia = 42;
    while (cin >> liczba)
    {
        if (ilosc < 3)
            cout << liczba <<endl;
        if (liczba == 42 && poprzednia != 42)ilosc++;
        poprzednia = liczba;
    }
    return 0;
}