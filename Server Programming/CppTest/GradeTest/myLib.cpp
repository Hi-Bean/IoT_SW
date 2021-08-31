#include "MyGradeHeader.h"
#include <cString>

void swap(Student* a, Student* b)
{
	Student temp = *a;
	*a = *b;
	*b = temp;
}

void sortEX(Student* S, int n)
{
	for (int i = 0; i < n; i++)
	{
		for (int j = i + 1; j < n; j++)
		{
			//if (S[i].avg < S[j].avg)
			if ((S + i)->getAvg() < (S + j)->getAvg())
			{
				swap(S + i, S + j);
			}
		}
	}
}