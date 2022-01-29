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
