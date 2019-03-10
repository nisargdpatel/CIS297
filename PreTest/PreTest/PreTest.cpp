// PreTest.cpp : Defines the entry point for the console application.
//

#include <iostream>
#include <string>

#include "stdafx.h"

using namespace std;


template <class T>
int main()
{
	T newArray[6] = { 1, 5, 2, 7, 6, 5 };
	cout << thisFunction(newArray, 6);
    return 0;
}

template <class T>
T thisFunction(T thisArray[], T length) {
	
	for (T i = 0; i < length; i++)
	{
		for (T j = i + 1; j < length; j++)
		{
			T x = thisArray[i];
			thisArray[i] = thisArray[j];
			thisArray[j] = x;
		}
	}

	if (length % 2 == 0)
	{
		return ((thisArray[(length / 2) - 1] + thisArray[(length / 2)]) / 2);
	}
	else {
		return (thisArray[length / 2]);
	}


}
