
# Code Styling

### Curly brace style  
Curly braces are preferred to be on their own line, thus;
```cs
void exampleName()
{
  ...
}
```

### Console print text formatting
User input symbols (>) should proceed a new linecharacter, thus;
```cs
Console.WriteLine("Do you like cheese?");
Console.Write("\n> ");

// OR

Console.Write("Do you like cheese?\n\n> ");
```
Regular console text should be followed by a newline character, thus;
```cs
Console.WriteLine("Foo\n");
Console.WriteLine("Bar\n"); // the newline at the end of "Bar" is optional if "Bar" is the last console text
```

### Variable, class and method names  
Classes should follow Pascal Case (ie. all words' first letters are capatilized), thus;
```cs
class ExampleClass
{
  ...
}
```
Most variables should follow Camel Case (ie. all words' letters first letters are capatilized EXCEPT first), thus;
```cs
var exampleVariable;
```
Method constructor variables are recommended to use underscores in place of spaces for clarity (though optional), thus;
```cs
void exampleMethod(var this_is_a_constructor)
{
  ...
}
```
Most methods should follow Camel Case (ie. all words' letters first letters are capatilized EXCEPT first), thus;
```cs
void exampleMethod()
{
  ...
}
```

### String Interpolation
String interpolation with variables should use indexes, thus;
```cs
Console.WriteLine($"foo = {0}, bar = {1}", foo, bar);
Console.WriteLine($"foo = {foo}, bar = {bar}");
```
