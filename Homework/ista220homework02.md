# C# Programming Homework 02
## Chapter 02, C# Step by Step
####  Homework
#### Readings
Read chapter 2, pages 33 � 58 in the C# Step by Step book.
1.2 Discussion Questions
#### Answer the discussion questions in writing for chapter 2.
###### 1. What is a local variable?
A local variable is a variable that exists only in a method or other small section of code.

###### 2. What is a statement?
A statement is a command that performs an action.

###### 3. What is an identi?er?
An Identifier is the name you use to identify the elements in a program.

###### 4. What is a variable?
A variable is a storage location that holds a value.

###### 5. What is a method?
A method is named sequence of statements.

###### 6. Are primitive types and value types the same thing? See page 177.
Yes. Primitive types and value types are the same thing with the exception of string.

###### 7. How are arithmetic operators and variable types related?
The operators that can be used depends on the value types

###### 8. How do you turn an integer into a string?
There is no provision for converting an integer to a string

###### 9. How do you turn a string into an integer?
.NET Framework provides a method called Int32.Parse to convert string values to an integer.

###### 10. What is the di?erence between precedence and associativity? Give an example where this makes a di?erence.
Precedence governs the order in which an expression's operators are evaluated and Associativity is the direction (left or right) in which the operands of an operator is evaluated.
````
Precedence ex: 2+3*4 //3*4 is evaluated first which results in 12 then 2+12 yields final result of 14

Associativity ex: 4/2*6 //4 is divided by 2 which results in 2 then 2 is multiplied by 6 which yields final result of 12
````

###### 11. What is the definite assignment rule?
The definite assignment rule states you must assign a value to a variable before you can use it.

###### 12. How are the prefix and postfix increment and decrement operators evaluated di?erently?
In expressions using prefix operators the expression is evaluated before written and

###### 13. What is string interpolation?
String interpolation is used for concentrating stings. It also allows you to generate string values that include variable values

###### 14. What does the var keyword do
The var keyword causes the compiler to deduce the type of variables from the types of expressions used to initialize them.
