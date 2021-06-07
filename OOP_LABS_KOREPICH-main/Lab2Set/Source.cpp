#include <iostream>
#include <fstream>
#include <algorithm>
#include <bitset>
#include <string>
#include <iterator>
#include <set>
#include <random>
#include <locale>
#include <conio.h>

using namespace std;

class BitComp {
public:
	bool operator() (const int& firstN, const int& secondN) const
	{
		return firstN < secondN;
	}
};

void addByFirst(set<int, BitComp>& container);
void setPrinter(set<int, BitComp>& container);
void fillSet(set<int, BitComp>& container, int numbersCount);
void valueDeleter(set<int, BitComp>& container, int value);
void positionDeleter(set<int, BitComp>& container, int position);
void openConsoleMenu();
void processTheChoice(int choice, set<int, BitComp>& container);

int main() {
	setlocale(0, "russian");
	openConsoleMenu();
	return 0;
}

void setPrinter(set<int, BitComp>& container) {
	for (set<int>::iterator it = container.begin(); it != container.end(); it++)
	{
		cout << *it << "\n";
	}
	cout << "\n";
}

void fillSet(set<int, BitComp>& container, int numbersCount)
{
	random_device rd;
	mt19937 generator(rd());
	for (int i = 0; i < numbersCount; i++) {
		container.insert(generator());
	}
}

void valueDeleter(set<int, BitComp>& container, int value)
{
	container.erase(container.find(value));
}

void positionDeleter(set<int, BitComp>& container, int position) {
	if (position <= (container.size() - 1)) {
		set <int>::iterator deleter = container.begin();
		advance(deleter, position);
		container.erase(deleter);
	}
	else {
		cout << "������� ������� �������!\n��������� ������� ��������� ����� �������: " << container.size() - 1 << "\n";
	}
}

void addByFirst(set<int, BitComp>& container) {
	set<int, BitComp> tempSet;
	set <int>::iterator firstElement = container.begin();
	for (auto value : container) {
		tempSet.insert(value + *firstElement);
	}
	container.swap(tempSet);
}

void openConsoleMenu() {
	int actionChoice = 0;
	set<int, BitComp> numberContainer;
	fillSet(numberContainer, 10);
	while (actionChoice != 4) {
		system("CLS");
		cout << "   �������� �������� :\n";
		cout << "1) ������� ������� �� �������.\n";
		cout << "2) ������� ������� �� ��������.\n";
		cout << "3) ��������� ��� �������� �� �������� ������� ��������.\n";
		cout << "4) �����.\n";
		cin >> actionChoice;
		if (cin.good()) {
			processTheChoice(actionChoice, numberContainer);
		}
		else {
			cout << "������������ ����� ��������!\n������� ����� �������, ����� ����������...\n";
			cin.clear();
			cin.ignore();
			_getch();
		}
	}
	ofstream fileOut("output.txt");
	copy(numberContainer.begin(), numberContainer.end(), ostream_iterator<int>(fileOut, "\n"));
	cout << "������ �� ��������� numberContainer ���� �������� � ���� output.txt\n";
}

void processTheChoice(int choice, set<int, BitComp>& container) {
	system("CLS");
	switch (choice)
	{
	case 1: {
		int deletingValue;
		cout << "\n��������� ��������: " << container.size() << " ���������\n";
		cout << "\n��������� �� �������� ��������:\n";
		setPrinter(container);
		cout << "������� ������� ���������� ��������.\n";
		cin >> deletingValue;
		positionDeleter(container, deletingValue);
		cout << "\n��������� ����� �������� ��������:\n";
		setPrinter(container);
	}
		  break;
	case 2: {
		int deletingValue;
		cout << "\n��������� ��������: " << container.size() << " ���������\n";
		cout << "\n��������� �� �������� ��������:\n";
		setPrinter(container);
		cout << "������� �������� ���������� ��������.\n";
		cin >> deletingValue;
		valueDeleter(container, deletingValue);
		cout << "\n��������� ����� �������� ��������:\n";
		setPrinter(container);
	}
		  break;
	case 3: {
		cout << "\n��������� ��������: " << container.size() << " ���������\n";
		cout << "\n��������� �� ����������� ������� �������� �� ����:\n";
		setPrinter(container);
		addByFirst(container);
		cout << "\n��������� ����� ����������� ������� �������� �� ����:\n";
		setPrinter(container);
	}
		  break;
	default:
		cout << "�������� ��������!\n";
		break;
	}
	cout << "������� ����� �������, ����� ����������...\n";
	_getch();
}