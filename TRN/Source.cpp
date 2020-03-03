#include <iostream>

using namespace std;

int main()
{
	int m, n;
	cin >> m >> n;

	int** macierz = new int*[m];
	for (int i = 0; i < m; i++)
	{
		macierz[i] = new int[n];
	}

	for (int i = 0; i < m; i++)
	{
		for (int j = 0; j < n; j++)
		{
			cin >> macierz[i][j];
		}
	}

	for (int i = 0; i < n; i++)
	{
		for (int j = 0; j < m; j++)
		{
			cout << macierz[j][i] << " ";
		}
		cout << endl;
	}

	for (int i = 0; i < m; i++)
		delete[] macierz[i];

	delete[] macierz;
}