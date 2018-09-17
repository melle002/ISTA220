# Homework 12, ISTA-220
## Chapter 12, C# Step by Step

#### Readings:
Read chapter 12, pages 255 - 276 in the C# Step by Step book.
#### Discussion Questions
Answer the discussion questions in writing.

##### 1. How does inheritance promote the principle of don't repeat yourself (DRY)?
Instead of creating the same methods that are common to multiple classes those classes can inherit from a base class.

##### 2. What is the syntax of a derived class that inherits from a base class?
Derived Class : Base Class

##### 3. Do all user defined types (classes and structs) inherit from some base class? If so, what is it?
Yes  System.Object class

##### 4. What happens if you do not have a default constructor in a base class when creating a derived class?
a compile time error if the correct base-class constructor is not called

##### 5. Can you assign a variable of a derived class to another variable of its base class? Why or why not?
Yes

##### 6. Can you assign a variable of a derived class to another variable of of a derived class of its base class? Why or why not?
Generaly the answer is no

##### 7. Can you assign a variable of a base class to another variable of a derived class? Why or why not?
No because it may not be compatible with derived classes type (every mammal is not a horse)

##### 8. Under what circumstances would you want to use the new keyword when defning a method in a derived class?
If you are sure you want to use that method it silences the warning

##### 9. What is a virtual method? Why would you want to define a virtual method?
A method expected to be overidden

##### 10. What does override do? Why does it do it?
changes parameter of the orinal method

##### 11. How do you defne an extension type?
By using the this keyword in the method's parameter

##### 12. Why do you define an extension type?
To build on someone else's work
