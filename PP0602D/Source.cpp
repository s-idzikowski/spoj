#include <iostream>

using namespace std;

int main()
{
	int n, k;
	cin >> n >> k;

	int* tab = new int[n-k];
	int* t2 = new int[k];
	
	for (int i = 0; i < k; i++)
	{
		cin >> t2[i];
	}

	for (int i = 0; i < n-k; i++)
	{
		cin >> tab[i];
	}

	for (int i = 0; i < n-k; i++)
	{
		cout << tab[i] << " ";
	}

	for (int i = 0; i < k; i++)
	{
		cout << t2[i] << " ";
	}

	delete[] tab;
	delete[] t2;
}