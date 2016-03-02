from random import randint
import time
import timeit

start = timeit.default_timer()


def quickSort(alist):
   quickSortHelper(alist,0,len(alist)-1)

def quickSortHelper(alist,first,last):
   if first<last:

       splitpoint = partition(alist,first,last)
       quickSortHelper(alist,first,splitpoint-1)
       quickSortHelper(alist,splitpoint+1,last)


def partition(alist,first,last):
   pivotvalue = alist[first]

   left = first+1
   right = last

   done = False
   while not done:

       while left <= right and alist[left] <= pivotvalue:
           left = left + 1

       while alist[right] >= pivotvalue and right >= left:
           right = right -1

       if right < left:
           done = True
       else:
           temp = alist[left]
           alist[left] = alist[right]
           alist[right] = temp

   temp = alist[first]
   alist[first] = alist[right]
   alist[right] = temp

   return right

alist = []

for i in range(100):
  alist.append(randint(0,100000))

quickSort(alist)
stop = timeit.default_timer()

print("--- quick sort took  %s seconds ---" % (stop))
print("--- Length: 36 lines of code---")
print("--- No of Elements: 100 ---")
with open("QuickSort.txt", "w") as text_file:
    print("--- quick sort took  %s seconds ---"% (stop), file=text_file)
    print("--- Length: 36 lines of code---", file=text_file)
    print("--- No of Elements: 100 ---", file=text_file)
