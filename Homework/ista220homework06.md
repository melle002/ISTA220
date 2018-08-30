# C# Programming Homework 06
## Chapter 06, C# Step by Step

#### Readings
Read chapter 6, pages 127 � 150 in the C# Step by Step book.
#### Discussion Questions
Answer the discussion questions for chapter 6 in writing.
###### 1. What is an exception?
 An exception separates error-handling from the code that implements the primary logic of a program.

###### 2. What happens in a try block if the program executes without errors?
All Statements in the try block run consecutively, to completio

###### 3. How does the catch mechanism work for unhandled exceptions?
the runtime attempts to find a matching catch handler, if none exists, the calling method exits and execution is repeated.

###### 4. What happens in a program if an exception block fails to handle an particular error?
 If a catch handler is not located, the second time,then the program is terminated with an unhandled exception.

###### 5. What is the parent class for all exceptions? How does this work?
Exception, the handle traps every possible exception that can occur

###### 6. How do you determine the type of an error?
By Debugging

###### 7. What is the purpose of integer checking?
to throw an OverflowException if an integer calculation in the block overflows.

###### 8. What does the finally block do?
It ensures that a statement written within it will always run weather an exception has been thrown or not.
