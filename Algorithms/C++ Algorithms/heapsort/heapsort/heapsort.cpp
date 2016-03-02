<<<<<<< HEAD
#include <iostream>
#include <fstream>
#include <omp.h>

using namespace std;

void shiftDown(int *data, int k, int size);

void swap(int *m, int *n)
{
	int tmp;
	tmp = *m;
	*m = *n;
	*n = tmp;
}

void heapsort(int data[], int Size){
	// heapify 
	for (int position = Size / 2; position >= 0; position--) {
		shiftDown(data, position, Size);
	}

	while (Size - 1 > 0) {
		// swap the maxvalue of the heap
		//with the last element 
		swap(data[Size - 1], data[0]);
		// put the heap back in max-heap order 
		shiftDown(data, 0, Size - 1);
		// N-- : decrease the size of the heap by one
		//so that the previous max value will
		//stay in its proper placement 
		Size--;
	}
}

void shiftDown(int *data, int position, int Size){
	while (position * 2 + 1 < Size) {
		/* For zero-based arrays, the children are 2*i+1 and 2*i+2 */
		int child = 2 * position + 1;

		/* get bigger child if there are two children */
		if ((child + 1 < Size) && (data[child] < data[child + 1])) child++;

		if (data[position] < data[child]) {   /* out of max-heap order */
			swap(data[child], data[position]);
			// repeat to continue shifting the child down
			position = child;
		}
		else
			return;
	}
}

int main()
{
	int i = 0;
	int data[100000];
	int size = 100000;
	// Starting the time measurement
	double start = omp_get_wtime();
	// Computations to be measured
		
	while (i < size)
	{
		data[i] = rand() % 100000;
		i++;
	}

	heapsort(data, size);
	//cout << "After: [";
	//for (i = 0; i < size; i++)
	//cout << data[i] << ", ";
	//cout << "]" << endl;
	// Measuring the elapsed time
	double end = omp_get_wtime() - start;
	// Time calculation (in seconds)
	cout << "HeapSort" << endl;
	cout << "34 lines of code" << endl;
	cout << end << "milliseconds" << endl;
	ofstream output("heapsortoutput.txt");
	output << end << "milliseconds"<< endl;
	output << "34 lines of code" << endl;
	output.close();
	system("PAUSE");
	return 0;
=======
#include <iostream>
#include <fstream>
#include <omp.h>

using namespace std;

void shiftDown(int *data, int k, int size);

void swap(int *m, int *n)
{
	int tmp;
	tmp = *m;
	*m = *n;
	*n = tmp;
}

void heapsort(int data[], int Size){
	// heapify 
	for (int position = Size / 2; position >= 0; position--) {
		shiftDown(data, position, Size);
	}

	while (Size - 1 > 0) {
		// swap the maxvalue of the heap
		//with the last element 
		swap(data[Size - 1], data[0]);
		// put the heap back in max-heap order 
		shiftDown(data, 0, Size - 1);
		// N-- : decrease the size of the heap by one
		//so that the previous max value will
		//stay in its proper placement 
		Size--;
	}
}

void shiftDown(int *data, int position, int Size){
	while (position * 2 + 1 < Size) {
		/* For zero-based arrays, the children are 2*i+1 and 2*i+2 */
		int child = 2 * position + 1;

		/* get bigger child if there are two children */
		if ((child + 1 < Size) && (data[child] < data[child + 1])) child++;

		if (data[position] < data[child]) {   /* out of max-heap order */
			swap(data[child], data[position]);
			// repeat to continue shifting the child down
			position = child;
		}
		else
			return;
	}
}

int main()
{
	int i = 0;
	int data[100000];
	int size = 100000;
	// Starting the time measurement
	double start = omp_get_wtime();
	// Computations to be measured
		
	while (i < size)
	{
		data[i] = rand() % 100000;
		i++;
	}

	heapsort(data, size);
	//cout << "After: [";
	//for (i = 0; i < size; i++)
	//cout << data[i] << ", ";
	//cout << "]" << endl;
	// Measuring the elapsed time
	double end = omp_get_wtime() - start;
	// Time calculation (in seconds)
	cout << "HeapSort" << endl;
	cout << "34 lines of code" << endl;
	cout << end << "milliseconds" << endl;
	ofstream output("heapsortoutput.txt");
	output << end << "milliseconds"<< endl;
	output << "34 lines of code" << endl;
	output.close();
	system("PAUSE");
	return 0;
>>>>>>> origin/master
}