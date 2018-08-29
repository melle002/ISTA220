# Homework 07, ISTA-220
#### Chapter 07, C# Step by Step
#### July 28, 2018
#### Readings
Read chapter 7, pages 153 - 174 in the C# Step by Step book.
#### Discussion Questions
Answer the discussion questions in writing.
##### 1. What is a class? According to the book, what does a class "arrange?"
A Class is an entity and it arranges information and behavior. Blueprint or pattern

##### 2. What are the two purposes of encapsulatiohn?
1. to combine methods and data within a class: support classification
2. To control the accessibility of the methods and data: control the use of the Class

##### 3. How do you instantiate an instance of a class? How do you access that instance?
By using the keyword new and you access it by using the variable assigned to it

##### 4. What is the default access of the fields and methods of a class? How do you change the default?
The default access is private and you change it by declaring public.

##### 5. What is the syntax for writing a constructor?
public ClassName(parameters)

##### 6. What is the diference between class fields and methods, and instance fields and methods? How do you create class fields and methods?
instance fields and methods must be created, class fields and methods do not.

##### 7. How do you bring a static class in scope? Why would you want to bring a static class in scope?
By using static using statements. To save on typing but it is always good practice to fully qualify a class with it's namespace.

##### 8. Can you think of a good reason to create an anonymous class? What is it?
When using querry expressions. They are classes that do not have a name.

##### 9. What is polymorphism as this term is used in computer science? This is not in the book.
The simple explanation is: Same class different behavior

##### 10. What is message passing as this term is used in computer science? This is not in the book.
create an object to handle a process then call that object. ex. Math.SQRT()

##### 11. What was the first object-oriented programming language?
Simula


##### 12. Consider this quote by Alexander Stepanov:Who is Alexander Stephanov? What do you think about this quote?


###### "I find OOP technically unsound. It attempts to decompose the world in terms of interfaces that vary on a single type. To deal with the real problems you need multisorted algebras and families of interfaces that span multiple types. I find OOP philosophically unsound. It claims that everything is an object. Even if it is true it is not very interesting and saying that everything is an object is saying nothing at all.""

A Russian Computer Programmer who was the primary designer and implementer of the C++ standard template library. I don't think he was a fan of object oriented programming.
