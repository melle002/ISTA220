# Homework 10, ISTA-220
## Chapter 10, C# Step by Step
#### Readings
Read chapter 10, pages 221 - 242 in the C# Step by Step book.
#### Discussion Questions
Answer the discussion questions in writing.

##### 1. What does an array look like in memory?
A contiguous block of memory

##### 2. Where is memory allocated to hold an array, on the stack or on the heap?
in the heap

##### 3. Where is memory allocated to hold an array reference, on the stack or on the heap?
on the stack

##### 4. Can an array hold values of diferent types? This is a trick question, the answer is, It depends.
yes if you have an array of reference types then you can have different data types in the array.

##### 5. Describe the syntax of the condition of a foreach loop.
foreach(Datatype, name, Keyword[in] name of array)

##### 6. How do you make a deep copy of a array?
Makke a new array and copy the elements of the old array one by one

##### 7. What is the diference between a multi-dimensional array and an array of arrays?
the way it looks in memory. one contiguous block of memory vs many contiguous blocks of memory

##### 8. How do you "flatten" a multidimensional array? In other words, take something that looks like a matrix? and turn it into an array
```
| 1 2 3 |  [1,2,3,4,5,6,7,8,9]?
| 4 5 6 |
| 7 8 9 |
```
