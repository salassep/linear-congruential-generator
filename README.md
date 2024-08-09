# Linear Congruential Generator

A C# library for randomizing lists using the Linear Congruential Method (LCM). This library is designed to work with lists containing any type of data, from simple strings to complex objects.

## Features

- Randomizes any list of items (at least 3 elements), whether they are primitive types or complex objects.
- Defaults the seed to the system tick count if not provided.
- Automatically generates `a` and `c` as random prime numbers within the range of the list size.

## Installation

### Prerequisites

Make sure you have the following:

- .NET SDK installed on your machine.

### Installing via terminal

Use the dotnet add package command to add the package to your project:

```csharp
dotnet add package linear-congruential-generator --source "https://nuget.pkg.github.com/salassep/index.json"
```

## Usage

### 1. Import the Library

Once the package is installed, you can use it in your project by adding the following using statements:

```csharp
using linear_congruential_generator;
```

### 2. Instantiate the Randomizer

You can create an instance of the `LinearCongruentialGenerator` class by providing a seed and the size of the list to be randomized. If you don't provide a seed, it will default to the system's current tick count.

```csharp
LinearCongruentialGenerator randomizer = new LinearCongruentialGenerator();
```

### 3. Randomize a List

You can randomize a list of any type using the `Randomize` method.

```csharp
List<string> stringList = new List<string> { "a", "b", "c", "d", "e" };
List<string> randomizedList = randomizer.Randomize(stringList);

foreach (var item in randomizedList)
{
    Console.WriteLine(item);
}
```

Example with Complex Objects

```csharp
var objectList = new List<object>
{
    new { question = "What is 2+2?", answer = "4" },
    new { question = "What is the capital of France?", answer = "Paris" },
    new { question = "What is the color of the sky?", answer = "Blue" }
};

var randomizedObjectList = randomizer.Randomize(objectList);

foreach (var item in randomizedObjectList)
{
    Console.WriteLine($"Question: {item.question}, Answer: {item.answer}");
}
```

## Contributing

Contributions are welcome! Feel free to submit issues or pull requests to improve the library.
