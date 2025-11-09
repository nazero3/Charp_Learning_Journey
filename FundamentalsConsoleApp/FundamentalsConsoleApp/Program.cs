using System;

namespace StartCSharpLearning
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("🎯 Starting My C# Learning Journey!");
            Console.WriteLine("From C++ and Node.js to C#!");

            // Demonstrate basic C# features
            DemonstrateVariables();
            DemonstrateOperations();
        }

        static void DemonstrateVariables()
        {
            // Different ways to declare variables
            string message = "Hello C#";
            var implicitMessage = "Hello with var"; // Type inference
            int number = 42;
            var implicitNumber = 24; // compiler knows this is int

            Console.WriteLine($"\n📝 Variable Demonstration:");
            Console.WriteLine($"String: {message}");
            Console.WriteLine($"Var string: {implicitMessage}");
            Console.WriteLine($"Number: {number}");
            Console.WriteLine($"Var number: {implicitNumber}");
        }

        static void DemonstrateOperations()
        {
            Console.WriteLine($"\n🔢 Operations Demonstration:");

            // Math operations (similar to C++)
            int a = 15, b = 4;
            Console.WriteLine($"{a} + {b} = {a + b}");
            Console.WriteLine($"{a} / {b} = {a / b} (integer division)");
            Console.WriteLine($"{a} / {b} = {(double)a / b} (floating point division)");

            // String interpolation (C# feature)
            string name = "Developer";
            int experience = 5;
            Console.WriteLine($"Hello {name}, with {experience} years of experience!");
        }
    }
}