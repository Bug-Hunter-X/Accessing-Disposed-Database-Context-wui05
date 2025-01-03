# Accessing Disposed Database Context in C#

This repository demonstrates a common error in C#: attempting to access a database context or other disposable object after it has been disposed. The example uses Entity Framework Core, but the principle applies to any disposable resource.

## Bug

The `bug.cs` file contains code that accesses a database context after it has been disposed. This will result in an `ObjectDisposedException`.  The problem lies in trying to access the `context` variable after the `using` block, which automatically disposes of the context.

## Solution

The `bugSolution.cs` file demonstrates the correct approach. Instead of trying to access the context outside of the `using` block, all operations that require the context are performed inside the block.

## How to Reproduce

1.  Clone this repository.
2.  Ensure you have the necessary NuGet packages installed (e.g., Entity Framework Core).
3.  Run the `bug.cs` code (you will need to adapt the database connection string). You will receive an `ObjectDisposedException`. 
4.  Run the `bugSolution.cs` code. This should run without error.