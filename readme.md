# C#

* Visual Studio for Mac, Visual Studio for Windows are the main IDEs



## Paradigms

1. Procedural
2. Event-driven
3. Object-oriented programming
4. Functional (less used... it's like Will Smith's other kid)

## OOP principles

1. Encapsulation
2. Polymorphism
3. Abstraction
4. Inheritance
5. Interfaces
6. Enums
7. Regex (personal dev, mostly)

## Encapsulation

* public
* private
* protected
* internal
* protected internal

```csharp
class Mathematics
    {        
        private int Addition(int numberOne, int numberTwo) 
        {
            return numberOne + numberTwo;
        }
        private int Subtraction(int numberOne, int numberTwo) 
        {
            return numberOne - numberTwo;
        }

        // subtraction, multiplication, division
        // console.writeline them inside of the Program class in Program.cs
       

        public void sayHello(int numberOne, int numberTwo)
        {
            // anything inside of a public method is accessible elsewhere
            // even if that value is set to private
            Console.WriteLine(Addtion(numberOne, numberTwo))
            Console.WriteLine(Subtraction(numberOne, numberTwo))
        }
    }
```

## Polymorphism

Polymorphism = many forms. One interface, with many methods / functions

```csharp

void DisplayMe(int data) 
{
    Console.WriteLine($"Your data: {data}");
}

void DisplayMe(double data) 
{
    Console.WriteLine($"Your data: {data}");
}

void DisplayMe(string data) 
{
    Console.WriteLine($"Your data: {data}");
}

```

## Yeah, but why use C#?

You can make almost anything with C# and its libraries, frameworks etc. C# **was** mainly used for Windows based applications! Desktop applications and games (unity). C# can now be used properly in creating web applications and mobile applications. 

* Conditions
* Loops
* Methods
* Classes
* Objects (look a little different but mostly the same)
* Arrays and strings (lists w/ arrays)
* Inheritance
* Generics

### Native applications

iPhone, Android, (Windows) - for tablets. Installed on the device. 

### Web applications

Used with JavaScript on the bootcamp. 

### Unity for Games

Unity is used for VR applications: Samsung, Oculus and others use Unity for their games / apps. 500m users use Unity games. C# is one of the tools (languages) that you can use to do this. 

### Easy? But very complex


### .NET vs .NET Core?

Used for every C# applications created in 2020. 

Newer applications will be more efficient with .NET Core over .NET

* .NET Core allows cross-platform applications / development. Using Xamarin to achieve this. WPF, UWP && Windows Forms. 

High-performance is at the core of what C# aims to achieve. 

### UWP

* APIs to run on Windows 10 - built for Windows 10
* Optimisation for all Windows 10 device (no scaling needed, it'll do it for you)
* Can be uploaded to Windows Store
* Easily uninstalled (Good and bad...)
* Tile integration, push notifications, cortana all built-in
* C#, C++, Visual Basic, JavaScript

### APIs

* Fetch data (some key needed)
* JSON format?
* Communication
* Have to use async? (always?) Not always but recommended!
* Free, freemium, premium
* GET, POST, PUT / PATCH, DELETE
* .env files are essential
* Anything that sends, receives, acknowledges data

## Types

* Type of data type
    * value type
    * reference type

### Value type

Stores the content of the type in memory (stacks). Single form / space in memory, that space holds the value of the type. 

```csharp
string firstName = "Jacob"; // 1 stack
string lastName = "Reilly-Cooper"; // 1 stack
string fullName = firstName + " " + lastName // 1 stack
```

* Data types
    * int
    * string
    * bool
    * double
    * float
    * etc etc etc

## Structures

Struct = record representation. Individual staff details would be a record

## The must do's

* Class names and file names start with a captial letter and follow Pascal casing principles PascalCasingPrinciples

* Classes are created with:
```csharp
class ClassName 
{
    // the brackets go on the line below the class name
}
```

* Main method in Program.cs is the entry to our program with console applications. All code will eventually, in some way, run through that. 

* Declaration of the data type that you are using is essential unless using the var keyword, which is new and some devs may not use it. 
```csharp
string name = "Jacob Reilly-Cooper";
var name = "Jacob Reilly-Cooper";
```

### Operators

* Arithmetic operators
    * +, -, *, /, %, ++, --

* Relational operators
    * ==, !=, >, <, >=, <=

* Logical operators
    * &&, ||, ! (AND, OR, NOT)

* Bitwise operator
    * &, |, ^ (AND, OR, XOR)
    * XOR = one but not the other

    0011 0101
    1011 0011
    ---------
    0011 0001   AND
    1011 0111   OR
    1000 0110   XOR

    0011 1100
    0000 1101
    ---------
    0000 1100   AND
    0011 1101   OR
    0011 0001   XOR

    0101 1111
    1101 1011
    ---------
    0101 1011   AND
    1101 1111   OR
    1000 0100   XOR

* Assignment operator
    * =, +=, -=, *=, /=
    * &=, ^=, |=

* Other operators
    * sizeof()
    * typeof()

```javascript
// assignment grouping
// right to left
let name = "Jacob";
let age  = 55;

// equality
// left to right
if (name == "Jacob") 
{
    console.log("Hello, World.")
}
```

* Method structure
```csharp
// Level of access we give a method. Default is private. - public
// return type: what value we are expecting the method to return - double
// name of the method: Addition
// list of parameters: double numberOne, double numberTwo
// body of the method: the code inside the {}
public double Addition(double numberOne, double numberTwo)
{
    return numberOne + numberTwo;
}

```