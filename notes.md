# Notes on Project

## C# Data Types

- Statically typed language which means data type is explicitly labaled when a variable is declared.
- Data types are:
  - int
  - float
  - double
  - string
  - bool
  - char
  - byte
  - short
  - long
  - decimal
  - object
  - void
- Compilers are more likely to catch errors in statically typed languages.
- EX. int x = "Hello"; string y = "World"; float z = x + y;
- String interpolation can be done in a few ways
  - Console.WriteLine($"greeting {greeting}");
  - Console.WriteLine("greeting: {0}", greeting);
- First example uses the $ and { } to define the string.
- Numbers: int for whole numbers, float for decimals, double for double precision.
- Data types are identified with GetType()
- C# has a seperate Boolean data type. "bool" can be assigned value true or false.
- C# has a seperate character data type. "char" can be assigned a single character
- Data type conversion is done with the Convert class.
- Ex: string stringNum = "2";
            int intNum = Convert.ToInt16(stringNum);
            Console.WriteLine(intNum);
            Console.WriteLine(intNum.GetType());
- Data Structures are:
  - Arrays
  - Lists
  - Queues
  - Stacks
  - Hashtables
  - Dictionary
  - SortedList
  - SortedDictionary
- Similar to object literals, dictionaries are key value pairs.
- You must explicity define the key and value data types.
- To use dictionary you must import System.Collections.Generic.
using System.Collections.Generic;
- Data types for a dictionary's key-value pair types are declared in angled brackets, as shown in the following examples:
  - Dictionary<string, int>
  - Dictionary<string, string>
  - Dictionary<int, string>
  - Dictionary<int, int>
- We could initialize the dictionary by listing the key-value pairs in a function call. Using this method, we pass a comma-separated list of key-value pairs in braces, {}, for each entry we wish to create.
- Ex: Dictionary<string, int> dict = new Dictionary<string, int>() { { "one", 1 }, { "two", 2 }, { "three", 3 } };
- Lists are more similar to javascript arrays.
- Lists are located in System.Collections.Generic

## For Loops

- For loops are used to iterate over a collection of items.
- Syntax:
  - for (initializer; condition; iterator)
    {
      // code to be executed
    }
- Initializer section is used to initialize a variable that will be local to a for loop and cannot be accessed outside of the for loop.
- Condition is a Boolean expression that will return true or false, if true the loop will execute again, otherwise the loop will exit.
- Iterator defines the incremental or decremental of the loop variable.
- Ex.
  - for(int i = 0 *initializer*; i < 10 *condition*; i++ *iterator*)
    {
        // Execute statement here
        Console.WriteLine("Value of i: {0}", i);
    }
- An Initializer, condition, and iterator sections are optional. You can initialize a variable before for loop, and condition and iterator can be defined inside a code block, as shown below.
- Ex:
  - int i = 0;
    for(;;)
    {
        if (i < 10)
        {
            Console.WriteLine("Value of i: {0}", i);
            i++;
     }
        else
        break;
    }
- The break statement can be used to exit a for loop.
- Be careful in defining a condition and iterator or else you will get an infinite loop.
- Ex:
  - for(;;)
    {
        Console.WriteLine("Infinite Loop");
    }
- The control variable for the for loop can be of any numeric data type, such as double, decimal, etc.
- Ex:
    for(double d = 1.01D; d < 1.10; d+= 0.01D)
    {
        Console.WriteLine("Value of d: {0}", d);
    }
- The steps part in a for loop can either increase or decrease the value of a variable.
- Exit the for loop using break
- multiple expressions in a for loop can be separated by commas.
- Ex:
    for(int i = 0, j = 0; i < 10; i++, j++)
    {
        Console.WriteLine("Value of i: {0}", i);
        Console.WriteLine("Value of j: {0}", j);
    }
- A for loop can also contain statements as an initializer, and iterator.
- Ex:
    int i = 0, j = 5;
    for(Console.WriteLine($"Initializer: i={i}, j={j}"); i++ < j--; Console.WriteLine($"Iterator: i={i}, j={j}"))
    {
    }
- Nested for loop in C# is allowed
- for (int i = 0; i < 2; i++)
{
    for(int j =i; j < 4; j++)
        Console.WriteLine("Value of i: {0}, J: {1} ", i,j);
}
- In C#, a method declaration (or signature) looks like the following example:
- `[access_modifier] ["static"] return_type name([parameters])`
- The parts in brackets are optional.
- Remember that if a static method wants to call another method inside the same class directly, that method must also be static. Because Main() is static, any other method it needs to call within Program must also be static.
- Any method that does not return a value must be defined to return void.