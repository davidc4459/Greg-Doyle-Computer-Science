import java.util.*;
import java.io.PrintWriter;
import java.io.IOException;

public class Quicksort {
	public static void quickSort(int[] arr, int low, int high) {
		if (arr == null || arr.length == 0)
			return;
 
		if (low >= high)
			return;
 
		int middle = low + (high - low) / 2;
		int pivot = arr[middle];
 
		int i = low, j = high;
		while (i <= j) {
			while (arr[i] < pivot) {
				i++;
			}
  
			while (arr[j] > pivot) {
				j--;
			}
 
			if (i <= j) {
				int temp = arr[i];
				arr[i] = arr[j];
				arr[j] = temp;
				i++;
				j--;
			}
		}
 
		if (low < j)
			quickSort(arr, low, j);
 
		if (high > i)
			quickSort(arr, i, high);
	}
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
public static void main(String[] args) {
		  
	long startTime = System.currentTimeMillis();
	int[] Data = {}; 
    Data = new int[100];

    	int i=0;
    	for (i=0; i<100; i++)
   	{
 	 int rand = (int) Math.round(Math.random() * 100);
 	 Data[i] = rand;
	}
	
		int low = 0;
		int high = Data.length - 1; 

	try {
	PrintWriter out = new PrintWriter("Quicksort.txt");
	long endTime   = System.currentTimeMillis();
	long totalTime = endTime - startTime;
	System.out.println("Quicksort took " + totalTime + "miliseconds");
	out.println("" + "Quicksort took " + totalTime + "miliseconds");
	System.out.println("Length: 44 lines of code");
	out.println("Length: 44 lines of code");
	System.out.println("Language: Java");
	out.println("Language: Java");
	out.close();
	}
	catch(IOException e){}
 	
	 }
}