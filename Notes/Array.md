## Array
Array is basically a fundamental data structure and is a list of data elements.
An array is a fundamental data structure that stores elements of the same type in contiguous memory locations, allowing efficient access using indexes.

Array happens to be of defined length. Though there could be Dynamic Array which can increase/decrease in size.

We can do different operations on the Arrays

- Read
  - We can directly access the Array element as Array contains elements in contiguous memory and while reading any element, it knows the memory address by adding the index to the array (first element) address.
  - O(1) 
- Search
  - To search any element in the Array, we have to traverse the Array as it does not know which element contains which value. So, we have to check every element to search the given value.
  - O(n)
- Insert
  - To add any element at the end, it is very easy and fast as we can get the last index using the Array length and add the element
  - O(1)
  - But in case we have to add any element at location other than last position, some elements would have to shifted to the right in order to insert the new value.
  - O(n) - as worst case could be inserting the value at 0 index.
- Delete
  - Similar to insertion, deletion could also take some operations as after deleting any element, we can't leave any space in the Array and to fix that, we would again have to shift the elements to the left.
  - O(n)

Arrays (Data structure) is used at many places and serve as foundation to many other data structures.

## Static Array vs Dynamic Array

### Static Array

- Fixed size.
- Memory is allocated upfront.
- Fast index access O(1).
- Cannot automatically grow.

Example:
int[] nums = new int[10];


### Dynamic Array

- Built on top of a normal array.
- Maintains size and capacity.
- Automatically creates a larger array when capacity is full.
- Copies existing elements into the new array.

Example:
List<int> nums = new List<int>();


Add operation:
- Usually O(1)
- Resize operation O(n)
- Overall amortized O(1)

  
