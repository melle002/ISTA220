# Homework 09, ISTA-220
## Chapter 09, C# Step by Step


#### Readings
Read chapter 9, pages 201 - 219 in the C# Step by Step book.
#### Discussion Questions
Answer the discussion questions in writing.

##### 1. Declare an enum for military ranks, either officer or enlisted. Name it Ranks. What are the symbols, like Private, PFD, Corporal, or 1stLt, 2ndLt, Capt?
enum  Ranks {PVT, PFC, SPC, SGT, SFC, MSG, SGM}

##### 2. Using the Ranks enum, assign a rank to yourself or a friend.
 Ranks Eller = Ranks.SFC
 Console.Writline(Eller): // writes out SFC

##### 3. Determine the numeric index of particular ranks, using the Ranks enum.
Ranks SFC = Ranks.SFC
Console.WritleLine((int) SFC): // writes out 4

##### 4. How do you select the type of an enum?
You must Cast it to it's underlying type

##### 5. Are structs stored on the stack or on the heap? What about enums?
Stack

##### 6. Declare a struct named DOD with four branches.
struct DOD
{
private string Army, string Navy, string AirForce, string Marines;
}

##### 7. Why can't you create a default constructor for a struct?
because the compiler always generates one

##### 8. What is CIL? What does the CLR do to the CIL?
Common intermediate Language. The CLR converts CIL instructions to real machine language.
