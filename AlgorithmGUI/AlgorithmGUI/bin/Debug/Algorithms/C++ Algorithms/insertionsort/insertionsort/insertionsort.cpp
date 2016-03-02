#include<iostream>
#include <fstream>
#include <omp.h>
using namespace std;

int main(void)
{
	int Data[100];		// An array of integers.
	int length = 100;		// Lenght of the array.
	int i, j;
	int keyelement;
	// Starting the time measurement
	double start = omp_get_wtime();
	// Computations to be measured
	//Some input
	i = 0;

	while (i < 100)
	{
		Data[i] = rand() % 100000;
		i++;
	}

	//Algorithm
	for (j = 1; j < length; j++) 
	{
		keyelement = Data[j];
		for (i = j - 1; (i >= 0) && (Data[i] < keyelement); i--)
		{
			Data[i + 1] = Data[i];
		}
		Data[i + 1] = keyelement;
	}
	//Some output
	//cout << "After: [";
	//for (i = 0; i < 10; i++)
	//{
	//	cout << Data[i] << ", ";
	//}
	//cout << "]" << endl;
	double end = omp_get_wtime() - start;
	// Time calculation (in seconds)
	
	cout << "Insertion Sort" << endl;
	cout << "16 lines of code" << endl;
	cout << end << "milliseconds" << endl;
	ofstream output("InsertionSortoutput.txt");
	output << end << "milliseconds" << endl;
	output << "16 lines of code" << endl;
	output.close();

	system("PAUSE");
}