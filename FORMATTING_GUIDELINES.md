**Curly brace style**  
---
Curly braces are preferred to be on their own line, thus;
```
void exampleName()
{
  ...
}
```

**Console print text formatting**  
---
User input symbols (>) should proceed a new linecharacter, thus;
```
Console.WriteLine("Do you like cheese?");
Console.Write("\n> ");

// OR

Console.Write("Do you like cheese?\n\n> ");
```
Regular console text should be followed by a newline character, thus;
```
Console.WriteLine("Foo\n");
Console.WriteLine("Bar\n"); // the newline at the end of "Bar" is optional if "Bar" is the last console text
```

**Variable, class and method names**  
---
Classes should follow Pascal Case (ie. all words' first letters are capatilized), thus;
```
class ExampleClass
{
  ...
}
```
Most variables should follow Camel Case (ie. all words' letters first letters are capatilized EXCEPT first), thus;
```
var exampleVariable;
```
Method constructor variables are recommended to use underscores in place of spaces for clarity (though optional), thus;
```
void exampleMethod(var this_is_a_constructor)
{
  ...
}
```
Most methods should follow Camel Case (ie. all words' letters first letters are capatilized EXCEPT first), thus;
```
void exampleMethod()
{
  ...
}
```
