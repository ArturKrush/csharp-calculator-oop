## Overview
This project implements two types of calculators in C#:
- **Base Calculator** — provides basic arithmetic operations.
- **Scientific Calculator** — inherits from the Base Calculator and extends its functionality by Pow(), Sqrt(), Sin(), Cos() methods.
- 
The `ScientificCalculator` class overrides the `Subtract()` method from the base class to demonstrate inheritance.

## Structure
- **BaseCalculator.cs** — defines basic operations such as addition, subtraction, multiplication, and division.  
- **ScientificCalculator.cs** — extends the base class, overrides `Subtract()` method, and may include additional scientific functions.  
- **Program.cs** — contains an interactive console menu for user interaction. Most functions are called within the `Main()` method.
