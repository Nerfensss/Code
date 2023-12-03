#include <iostream>
#include <algorithm>

using namespace std;

int main()
{
    int n, m, a, b, k, c;

    cout << "Введіть кількість людей (n): ";
    cin >> n;

    cout << "Введіть кількість поїздок на кожну людину (m): ";
    cin >> m;

    cout << "Введіть вартість квитка на одну поїздку (a): ";
    cin >> a;

    cout << "Введіть вартість безлімітного квитка на одну людину (b): ";
    cin >> b;

    cout << "Введіть кількість людей для групового квитка (k): ";
    cin >> k;

    cout << "Введіть вартість групового безлімітного квитка (c): ";
    cin >> c;

    // Розрахунок мінімальної сумарної вартості квитків
    int totalCost = 0;
    int groupCount = n / k; // Кількість повних груп
    int remainingPeople = n % k; // Кількість залишившихся людей

    // Розрахунок для повних груп
    totalCost += groupCount * min(c, k * b);

    // Розрахунок для залишившихся людей
    totalCost += remainingPeople * min(b, a * m);

    cout << "Мінімальна сумарна вартість квитків: " << totalCost << " гривень" << endl;

    return 0;
}

