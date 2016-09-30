// HWPeter.cpp : Defines the entry point for the console application.
//
#include "stdafx.h"
#include <iostream>
using namespace std;

int main()
{
	int a, min=99999, max=-99999;
	do
	{
		cin >> a;
		if (min > a) min = a;
		if (max < a) max = a;
	} while (a!=0);
	cout << "min = " << min;
	cout << "max = " << max;
    return 0;
}

