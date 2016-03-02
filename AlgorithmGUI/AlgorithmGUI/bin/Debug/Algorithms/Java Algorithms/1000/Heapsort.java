import java.util.*;
import java.io.PrintWriter;
import java.io.IOException;
public class Heapsort 
{
    private static int[] array;
    private static int length;
    private static int left;
    private static int right;
    private static int largest;

  
    public static void buildheap(int []array){
        length=array.length-1;
        for(int i=length/2;i>=0;i--){
            maxheap(array,i);
        }
    }
    
    public static void maxheap(int[] array, int i){ 
        left=2*i;
        right=2*i+1;
        if(left <= length && array[left] > array[i]){
            largest=left;
        }
        else{
            largest=i;
        }
        
        if(right <= length && array[right] > array[largest]){
            largest=right;
        }
        if(largest!=i){
            exchange(i,largest);
            maxheap(array, largest);
        }
    }
    
    public static void exchange(int i, int j){
        int t=array[i];
        array[i]=array[j];
        array[j]=t; 
        }
    
    public static void sort(int []array0)
    {
        array=array0;
        buildheap(array);
        
        for(int i=length;i>0;i--)
        {
            exchange(0, i);
            length=length-1;
            maxheap(array, 0);
        }
    }
    
  public static void main(String[] args) 
  	{
	long startTime = System.currentTimeMillis();
    int[] array = {}; 
    array = new int[1000];

    int i=0;
    for (i=0; i<1000; i++)
   	{
 	 int rand = (int) Math.round(Math.random() * 1000);
 	 array[i] = rand;
	}
	
    try {
	PrintWriter out = new PrintWriter("Heapsort.txt");
	long endTime   = System.currentTimeMillis();
	long totalTime = endTime - startTime;
	System.out.println("Heapsort took " + totalTime + "miliseconds");
	out.println("" + "Heapsort took " + totalTime + "miliseconds");
	System.out.println("Length: 59 lines of code");
	out.println("Length: 59 lines of code");
	out.close();
	}
	catch(IOException e){}
 	
	 }
}