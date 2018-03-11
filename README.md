# programming-fundamentals
Programming Fundamentals Repository

# Exercises: C# Intro and Basic Syntax
Problems for exercises and homework for the [Programming Fundamentals Extended� course @ SoftUni](https://softuni.bg/courses/programming-fundamentals)

## Problem 1. Debit Card Number
Write a program, which receives **4 integers** on the console and **prints them** in **4-digit debit card format.** See the examples below for the appropriate formatting.
### Examples
|Input	| Output  |
|--------|---------|
|12<br>433<br>1<br>5331|0012 0433 0001 5331<br><br><br>|

## Problem 2. Rectangle Area
Write a program, which calculates a **rectangle�s area**, based on its **width** and **height**. The **width** and **height** come as floating point numbers on the console, **formatted to the 2nd character after the decimal point**.
### Examples
|Input	| Output  |
|--------|---------|
|2<br>7|14.00<br>|
|7<br>8|56.00<br>|
|12.33<br>5|61.65<br>|

## Problem 5.* Character Stats
Write a program, which **displays information** about a video game character. You will receive their **name**, **current health**, **maximum health**, **current energy** and **maximum energy** on separate lines. The **current** values will **always** be valid (**equal or lower** than their respective **max** values). Print them in the format as per the examples.
### Examples

|Input	| Output  ||Input	| Output  |
|--------|---------|--|--------|---------|
|Mayro<br>5<br>10<br>9<br>10|Name: Mayro<br>Health: \|\|\|\|\|\|.....\|<br>Energy: \|\|\|\|\|\|\|\|\|\|.\|<br><br><br>|  |Bauser<br>10<br>10<br>10<br>10|Name: Bauser<br>Health: \|\|\|\|\|\|\|\|\|\|\|\|<br>Energy: \|\|\|\|\|\|\|\|\|\|\|\|<br><br><br>

|Input	| Output  | |Input	| Output  |
|--------|---------|--|--------|---------|
|Loogi<br>8<br>20<br>2<br>14|Name: Loogi<br>Health: \|\|\|\|\|\|\|\|\|............\|<br>Energy: \|\|\|............\|<br><br><br>|  |Toad<br>0<br>5<br>0<br>10|Name: Toad<br>Health: \|.....\|<br>Energy: \|..........\|<br><br><br>

### Hints
*	You can print a character **multiple** times, using **new string(character, count)**.


## Problem 4.
Beverage Labels

###

Write a program, which reads a food product **name**, **volume**, **energy content****per 100ml** and **sugar content per 100ml**. Calculate the **energy** and **sugar content**
for the **given volume** and print them
on the console in the following format:

�
Name � as per the input

�
Volume � **integer**,
**suffixed** by �**ml**� (e.g. �**220ml**�)

�
Energy content � **integer**, **suffixed** by �**kcal**� (e.g. �**500kcal**�)

�
Sugar content � **integer**, **suffixed** by �**g**� (e.g. �**30g**�)

#### Examples

###



**Input**



**Output**



[Nuka-Cola]()

220

300

70



220ml Nuka-Cola:

660kcal, 154g
  sugars





**Input**



**Output**



Ice Cold Nuka-Cola

250

350

65



250ml Ice Cold Nuka-Cola:

875kcal, 162.5g sugars





**Input**



**Output**



Nuka-Cola Quantum

350

600

140



350ml Nuka-Cola Quantum:

2100kcal, 490g sugars