from random import randint
import time
import timeit

start = timeit.default_timer()

def shellSort(array):

     gap = len(array) // 2
     # loop over the gaps
     while gap > 0:
         #insertion sort
         for i in range(gap, len(array)):
             val = array[i]
             j = i
             while j >= gap and array[j - gap] > val:
                 array[j] = array[j - gap]
                 j -= gap
             array[j] = val
         gap //= 2

alist = []

for i in range(100):
  alist.append(randint(0,100000))

shellSort(alist)
stop = timeit.default_timer()

print("--- Shell sort took  %s seconds ---" % (stop))
print("--- Length: 20 lines of code---")
print("--- No of elements: 100 ---")
with open("ShellSort.txt", "w") as text_file:
    print("--- Shell sort took  %s seconds ---"% (stop), file=text_file)
    print("--- Length: 20 lines of code---", file=text_file)
    print("--- No of Elements: 100 ---", file=text_file)