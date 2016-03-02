import java.util.*;
import java.io.PrintWriter;
import java.io.IOException;
public class shellsort{
 
  public static void sort(int[] array) {
    int inner, outer;
    int temp;
    int h = 1;
    while (h <= array.length / 3) {
      h = h * 3 + 1;
    }
    while (h > 0) {
      for (outer = h; outer < array.length; outer++) {
        temp = array[outer];
        inner = outer;
 
        while (inner > h - 1 && array[inner - h] >= temp) {
          array[inner] = array[inner - h];
          inner -= h;
        }
        array[inner] = temp;
      }
      h = (h - 1) / 3;
    }
  }
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
  public static void main(String[] args) {
 
	long startTime = System.currentTimeMillis();
    int[] Data = {}; 
    Data = new int[10000];

    	int i=0;
    	for (i=0; i<10000; i++)
   	{
 	 int rand = (int) Math.round(Math.random() * 10000);
 	 Data[i] = rand;
	}
 
	try {
	PrintWriter out = new PrintWriter("shellsort.txt");
	long endTime   = System.currentTimeMillis();
	long totalTime = endTime - startTime;
	System.out.println("shellsort took " + totalTime + "miliseconds");
	out.println("" + "shellsort took " + totalTime + "miliseconds");
	System.out.println("Length: 34 lines of code");
	out.println("Length: 34 lines of code");
	System.out.println("Language: Java");
	out.println("Language: Java");
	out.close();
	}
	catch(IOException e){}
 	
	 }
}