from random import randint
import time
import timeit

start = timeit.default_timer()


def insertionSort(alist):
   for index in range(1,len(alist)):

     currentvalue = alist[index]
     position = index

     while position>0 and alist[position-1]>currentvalue:
         alist[position]=alist[position-1]
         position = position-1

     alist[position]=currentvalue

alist = []

for i in range(10000):
  alist.append(randint(0,100000))

insertionSort(alist)
stop = timeit.default_timer()

print("--- insertion sort took %s seconds ---" % (stop))
print("--- Length: 17 lines of code---")
print("--- No of elements: 10000---")
with open("insertionSort.txt", "w") as text_file:
    print("--- insertion sort took  %s seconds ---"% (stop), file=text_file)
    print("--- Length: 17 lines of code---", file=text_file)    
    print("--- No of elements: 10000---", file=text_file)  