#include <iostream>

using namespace std;


int main() {
    int iloscPartii;
    cin >> iloscPartii;


    for (int i = 0; i < iloscPartii; i++)
    {
        int r1, r2;
        cin >> r1 >> r2;

        while (r2 != 0)
        {
            int c = r1 % r2;
            r1 = r2;
            r2 = c;
        }
        cout << 2 * r1 << endl;
    }
}