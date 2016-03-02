from random import randint
import time
import timeit

start = timeit.default_timer()

def heapsort( aList ):
  # convert aList to heap
  length = len( aList ) - 1
  leastParent = length / 2
  for i in range ( int(leastParent), -1, -1 ):
    moveDown( aList, i, length )
 
  # flatten into sorted array
  for i in range ( length, 0, -1 ):
    if aList[0] > aList[i]:
      swap( aList, 0, i )
      moveDown( aList, 0, i - 1 )
 
 
def moveDown( aList, first, last ):
  largest = 2 * first + 1
  while largest <= last:
    # if right child exists and is larger than left child
    if ( largest < last ) and ( aList[largest] < aList[largest + 1] ):
      largest += 1
 
    # if right child is larger than parent
    if aList[largest] > aList[first]:
      swap( aList, largest, first )
      first = largest;
      largest = 2 * first + 1
    else:
      return 
 
def swap( A, x, y ):
  temp = A[x]
  A[x] = A[y]
  A[y] = temp

alist = []

for i in range(100):
  alist.append(randint(0,100000))

heapsort(alist)
stop = timeit.default_timer()

print("--- Heap sort took  %s seconds ---" % (stop))
print("--- Language: Python---")
print("--- Length: 33 lines of code---")
print("--- No of elements:100---")
with open("HeapSort.txt", "w") as text_file:
    print("--- Heap sort took  %s seconds ---"% (stop), file=text_file)
    print("--- Language: Python---", file=text_file)
    print("--- Length: 33 lines of code---", file=text_file)
    print("--- No of elements:100---", file=text_file)
