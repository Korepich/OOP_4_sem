/* 
	������������ ������ �2. ������� � ������� ��� ����������.
	������� 22. � ���������� ������� �������� ����� ��������.
*/
#include <iostream>
#include <fstream>
#include <algorithm>
#include <string>
#include <iterator>
#include <map>
#include <random>
#include <functional>

using namespace std;

void mapPrinter(map<int, int>& container); // ������� ��� ������ �� ����� � ������ � ����
void fillMap(map<int, int>& container, int numbersCount); // ������� ���������� ����������

class BitComp {
public:
	bool operator() (const pair<int, int>& firstN, const pair<int, int>& secondN) const
	{
		return firstN.second > secondN.second;
	}
};

int main() {
	map<int, int> numbersContainer;
	fillMap(numbersContainer, 10);
	map<int, int>::iterator result = max_element(numbersContainer.begin(), numbersContainer.end(), BitComp()); // ����� ������������ ��������
	mapPrinter(numbersContainer);
	cout << "Min element: " << result->second << "\n\n";
	numbersContainer.erase(++numbersContainer.find(result->first), numbersContainer.end()); // �������� ���� ��������� ����� ������������ ��������
	mapPrinter(numbersContainer);
	return 0;
}

void mapPrinter(map<int, int>& container) {
	ofstream fileOut("output.txt");
	for (map<int, int>::iterator it = container.begin(); it != container.end(); it++)
	{
		cout << it->first << " => " << it->second << "\n";
	}
	for (auto element : container) {
		fileOut << element.first << ": " << element.second << endl;
	}
	cout << "\n";
}

void fillMap(map<int, int>& container, int numbersCount)
{
	random_device rd;
	mt19937 generator(rd());
	for (int i = 0; i < numbersCount; i++) {
		container.insert(make_pair(i, generator()));
	}
}
