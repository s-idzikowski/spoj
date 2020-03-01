#include <iostream>
#include <iomanip>

using namespace std;

int main()
{
	double a, b, c;
	cin >> a >> b >> c;

	if (c - b == a)
	{
		cout << "NWR";
		return 0;
	}
	if (a == 0) {
		cout << "BR";
		return 0;
	}

	cout << fixed << setprecision(2) << (c - b) / a;
}