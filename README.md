# Uninitialized Property Access in C#

This example showcases a common error in C#: accessing a property before it has been assigned a value. This can lead to a `NullReferenceException` if the property is a reference type or unexpected behavior if it is a value type.

## Bug

The `bug.cs` file contains code that attempts to access the `MyProperty` before it has been given a value.  This results in unpredictable behaviour. 

## Solution

The `bugSolution.cs` file demonstrates how to avoid this problem by initializing the property before it is used or using null-conditional operators or pattern matching.
