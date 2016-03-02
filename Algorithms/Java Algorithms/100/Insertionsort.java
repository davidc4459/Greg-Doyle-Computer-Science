import java.util.*;
import java.io.PrintWriter;
import java.io.IOException;

public class Insertionsort{

public static void insertionSort(int array[])

{
	int temp;		
	int pos;		
	
	for (int i = 1; i < array.length; i++)		// loop through the unsorted array
	{							
		temp = array[i];			// grab the first element of the unsorted array
		pos = i - 1;				// get the index of the last sorted element
		
		while ((pos >= 0) && (temp < array [pos]))	// while the current sorted element is greater than temp
		{
			array[pos + 1] = array[pos];		
			pos--;				
		}
		array[pos + 1] = temp;				// insert temp such that array[pos] <= temp < array[pos + 2]
	}
}	
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
 public static void main(String[] args) {
 
	long startTime = System.currentTimeMillis();
    int[] Data = {}; 
    Data = new int[100];

    	int i=0;
    	for (i=0; i<100; i++)
   	{
 	 int rand = (int) Math.round(Math.random() * 1000);
 	 Data[i] = rand;
	}
 
	try {
	PrintWriter out = new PrintWriter("Insertionsort.txt");
	long endTime   = System.currentTimeMillis();
	long totalTime = endTime - startTime;
	System.out.println("Insertionsort took " + totalTime + "miliseconds");
	out.println("" + "Insertionsort took " + totalTime + "miliseconds");
	System.out.println("Length: 29 lines of code");
	out.println("Length: 29 lines of code");
	System.out.println("Language: Java");
	out.println("Language: Java");
	out.close();
	}
	catch(IOException e){}
 	
	 }
}