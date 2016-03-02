// ConsoleApplication2.cpp : Defines the entry point for the console application.
//
#include "stdafx.h"
#include <iostream>
#include <fstream>
#include <omp.h>
using namespace std;

int Data[1000];

int * quickSort(int array[], int left, int right) {
	int startPos = left, endPos = right;
	int tmp;
	int pivot = array[(left + right) / 2];

	while (startPos <= endPos) {
		while (array[startPos] < pivot)
			startPos++;
		while (array[endPos] > pivot)
			endPos--;
		if (startPos <= endPos) {
			tmp = array[startPos];
			array[startPos] = array[endPos];
			array[endPos] = tmp;
			startPos++;
			endPos--;
		}
	};

	/* recursion */
	if (left < endPos)
		quickSort(array, left, endPos);
	if (startPos < right)
		quickSort(array, startPos, right);
	return array;
}

int main(void) {

	// Starting the time measurement
	double start = omp_get_wtime();
	// Computations to be measured
	int * SortData;
	int i = 0;
	
	while (i < 1000)
	{
		Data[i] = rand() % 10000;
		i++;
	}
	SortData = quickSort(Data, 0, 999);

	//Some output
	//i = 0;
	//cout << "After: [";
	//while (i < 10){

		//cout << SortData[i] << ", ";
		//i++;
	//}
	//cout << "]" << endl;

	// Measuring the elapsed time
	double end = omp_get_wtime() - start;
	// Time calculation (in seconds)

	cout << "Quick Sort" << endl;
	cout << "30 lines of code" << endl;
	cout << end << "milliseconds" << endl;
	ofstream output("QuickSortoutput.txt");
	output << end << "milliseconds" << endl;
	output << "30 lines of code" << endl;
	output.close();
	system("pause");
}