﻿1.
What type would you choose for the following “numbers”? 
A person’s telephone number
byte
A person’s height
float
A person’s age
int
A person’s gender (Male, Female, Prefer Not To Answer)
char
A person’s salary 
decimal
A book’s ISBN
char
A book’s price 
decimal
A book’s shipping weight 
float
A country’s population
uint
The number of stars in the universe 
ulong
The number of employees in each of the small or medium businesses in the  United Kingdom (up to about 50,000 employees per business) 
ushort
2.
What are the difference between value type and reference type variables? What is boxing and unboxing?
⦁	value type will directly hold the value, while reference type will hold the memory address or reference for this value
⦁	value types are stored in stack memory, while reference type will be stored in heap memory
⦁	value types are stored in stack memory, while reference type will be stored in heap memory
⦁	value types are stored in stack memory, while reference type will be stored in heap memory
⦁	value type will not be collected by garbage collector, while reference type will be collected by garbage collector
 
 
convert a value type to reference type -- boxing
convert a reference type to a value type -- unboxing
3.
What is meant by the terms managed resource and unmanaged resource in .NET
Managed resources are those that are pure . NET code and managed by the runtime and are under its direct control. Unmanaged resources are those that are not.
4.
What’s the purpose of Garbage Collector in .NET? 
The primary purpose of garbage collection is to reduce memory leaks.


Controlling Flow and Converting Types 
1.What happens when you divide an int variable by 0?
Undefined 
2.What happens when you divide a double variable by 0? 
Infinity
3.What happens when you overflow an int variable, that is, set it to a value beyond its range? 
Error	

4.	What is the difference between x = y++; and x = ++y;? 
y++ executes the statement and then increments the value.
++y increments the value and then executes the statement.
++y happens prior to assignment (pre-increment), but y++ happens after assignment (post-increment). 
5.What is the difference between break, continue, and return when used inside a loop statement? 
Break statement breaks the loop/switch whereas continue skip the execution of current iteration only and it does not break the lop/switch. i.e. it passes the control to the next iteration of the enclosing while loop, do while loop, for loop of for each statement in which it appears.
6.	What are the three parts of a for statement and which of them are required? 
Initialization, Condition, and the advancement to the next iteration.
None is required.
  
7.What is the difference between the = and == operators? 
== operator is the comparison operator. = operator is used to assign value.
8.Does the following statement compile? for ( ; true; ) ; 
Yes.
9.	What does the underscore _ represent in a switch expression? 
It replaces the default keyword to signify that it should match anything if reached.
10.	What interface must an object implement to be enumerated over by using the foreach statement? 
The IEnumerable interface