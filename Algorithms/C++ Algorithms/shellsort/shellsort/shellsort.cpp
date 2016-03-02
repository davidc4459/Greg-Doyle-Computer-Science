#include<iostream>
#include <fstream>
#include <omp.h>
using namespace std;

int main(void)
{
	// Starting the time measurement
	double start = omp_get_wtime();
	// Computations to be measured

	int Data[100];		// An array of integers.
	int length = 100;		// Length of the array.
	int i=0;
	int d;
	int tmp;

	//Some input
	while (i < 100)
	{
		Data[i] = rand() % 100000;
		i++;
	}

	//Algorithm
	d = length;
	do {
		d = (d + 1) / 2;
		for (i = 0; i < (length - d); i++)
		{
			if (Data[i + d] > Data[i])
			{
				tmp = Data[i + d];
				Data[i + d] = Data[i];
				Data[i] = tmp;
			}
		}
	} while (d > 1);

	//Some output
	//cout << "Before: [";
	//for (i = length-1; i >= 0; i--)
	//{
	//	cout << Data[i] << ", ";
	//}

	//cout << "]" << endl;

	// Measuring the elapsed time
	double end = omp_get_wtime() - start;
	// Time calculation (in seconds)

	
	cout << "ShellSort" << endl;
	cout << "20 lines of code" << endl;
	cout << end << "milliseconds" << endl;
	ofstream output("ShellSortoutput.txt");
	output << end << "milliseconds" << endl;
	output << "20 lines of code" << endl;
	output.close();
	system("PAUSE");
}