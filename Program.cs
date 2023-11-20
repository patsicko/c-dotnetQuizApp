using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the C# Learning Adventure!");

           
          if (ArrayConcept.Quiz() &&
            ObjectConcept.Quiz() &&
            ClassConcept.Quiz() &&
            EncapsulationConcept.Quiz() &&
            PolymorphismConcept.Quiz() &&
            AbstractionConcept.Quiz()) 
        {
            InheritanceConcept.Quiz();
        }

       
        ColoredOutput("\nCongratulations! You've completed the C# Learning Adventure. Happy coding!", ConsoleColor.Green);
    }

  
    static void ColoredOutput(string text, ConsoleColor color)
    {
        Console.ForegroundColor = color;
        Console.WriteLine(text);
        Console.ResetColor();
    }

    // Array Concept - Programming Languages
    class ArrayConcept
    {
        public static bool Quiz()
        {
            ColoredOutput("\n--- Array Concept ---", ConsoleColor.Yellow);
            ColoredOutput("What is an array in programming?", ConsoleColor.Cyan);
            ColoredOutput("a) A single variable", ConsoleColor.White);
            ColoredOutput("b) A collection of variables of the same type", ConsoleColor.White);
            ColoredOutput("c) A loop structure", ConsoleColor.White);
            Console.Write("Your answer (a, b, or c): ");
            string? answer = Console.ReadLine()?.Trim().ToLower();

            if (answer == "b")
            {
                ColoredOutput("Correct! An array is a collection of variables of the same type.", ConsoleColor.Green);

                // Practical Implementation
                ColoredOutput("\nPractical Implementation:", ConsoleColor.Magenta);
                string[] programmingLanguages = { "C#", "Java", "Python", "JavaScript", "C++" };

                ColoredOutput($"Programming Language:", ConsoleColor.Yellow);
                foreach (string programmingLanguage in programmingLanguages)
                {
                    ColoredOutput( $"{programmingLanguage}", ConsoleColor.Yellow);
                }
                    
                

                return true;
            }                        
            else
            {
                ColoredOutput("Incorrect! An array is a collection of variables of the same type. Please try again.", ConsoleColor.Red);
                return Quiz(); 
            }
        }
    }

    // Object Concept - Programming Tools
    class ObjectConcept
    {
        public static bool Quiz()
        {
            ColoredOutput("\n--- Object Concept ---", ConsoleColor.Yellow);
            ColoredOutput("What is an object in programming?", ConsoleColor.Cyan);
            ColoredOutput("a) A programming language", ConsoleColor.White);
            ColoredOutput("b) A collection of variables of the same type", ConsoleColor.White);
            ColoredOutput("c) An instance of a class", ConsoleColor.White);
            Console.Write("Your answer (a, b, or c): ");
            string? answer = Console.ReadLine()?.Trim().ToLower();

            if (answer == "c")
            {
                ColoredOutput("Correct! An object is an instance of a class.", ConsoleColor.Green);

                // Practical Implementation
                ColoredOutput("\nPractical Implementation:", ConsoleColor.Magenta);
                ProgrammingTool tool = new ProgrammingTool("Visual Studio", "Integrated Development Environment");
                
                ColoredOutput($"{tool}", ConsoleColor.Yellow);

                return true;
            }
            else
            {
                ColoredOutput("Incorrect! An object is an instance of a class. Please try again.", ConsoleColor.Red);
                return Quiz(); 
            }
        }
    }

    // Class Concept - Coding Languages
    class ClassConcept
    {
        public static bool Quiz()
        {
            ColoredOutput("\n--- Class Concept ---", ConsoleColor.Yellow);
            ColoredOutput("What is a class in programming?", ConsoleColor.Cyan);
            ColoredOutput("a) A programming language", ConsoleColor.White);
            ColoredOutput("b) A blueprint for creating objects", ConsoleColor.White);
            ColoredOutput("c) An array", ConsoleColor.White);
            Console.Write("Your answer (a, b, or c): ");
            string? answer = Console.ReadLine()?.Trim().ToLower();

            if (answer == "b")
            {
                ColoredOutput("Correct! A class is a blueprint for creating objects.", ConsoleColor.Green);

                // Practical Implementation
                ColoredOutput("\nPractical Implementation:", ConsoleColor.Magenta);
                CodingLanguage language = new CodingLanguage("C#", "Object-Oriented");
                ColoredOutput($"{language}", ConsoleColor.Yellow);

                return true;
            }
            else
            {
                ColoredOutput("Incorrect! A class is a blueprint for creating objects. Please try again.", ConsoleColor.Red);
                return Quiz(); 
            }
        }
    }

    // Encapsulation Concept - Code Snippets
    class EncapsulationConcept
    {
        public static bool Quiz()
        {
            ColoredOutput("\n--- Encapsulation Concept ---", ConsoleColor.Yellow);
            ColoredOutput("What is encapsulation in programming?", ConsoleColor.Cyan);
            ColoredOutput("a) Hiding implementation details", ConsoleColor.White);
            ColoredOutput("b) Writing code without comments", ConsoleColor.White);
            ColoredOutput("c) Using loops", ConsoleColor.White);
            Console.Write("Your answer (a, b, or c): ");
            string? answer = Console.ReadLine()?.Trim().ToLower();

            if (answer == "a")
            {
                ColoredOutput("Correct! Encapsulation is the process of hiding implementation details.", ConsoleColor.Green);

                // Practical Implementation on Encapsulation
                ColoredOutput("\nPractical Implementation:", ConsoleColor.Magenta);
                CodeSnippetContainer container = new CodeSnippetContainer();
               
                ColoredOutput("AddSippet and  DisplaySnippets functions are encapsulated  ", ConsoleColor.Yellow);

                container.AddSnippet("C#", "Console.WriteLine(\"Hello, World!\");");
                container.AddSnippet("Python", "print(\"Hello, World!\")");

                ColoredOutput("Code Snippets:", ConsoleColor.Yellow);
                container.DisplaySnippets();

                return true;
            }
            else
            {
                ColoredOutput("Incorrect! Encapsulation is the process of hiding implementation details. Please try again.", ConsoleColor.Red);
                return Quiz(); // Retry the quiz
            }
        }
    }

    // Polymorphism Concept - Coding Tasks
    class PolymorphismConcept
    {
        public static bool Quiz()
        {
            ColoredOutput("\n--- Polymorphism Concept ---", ConsoleColor.Yellow);
            ColoredOutput("What is polymorphism in programming?", ConsoleColor.Cyan);
            ColoredOutput("a) Using multiple loops", ConsoleColor.White);
            ColoredOutput("b) The ability of a class to have multiple methods with the same name", ConsoleColor.White);
            ColoredOutput("c) Writing comments in code", ConsoleColor.White);
            Console.Write("Your answer (a, b, or c): ");
            string? answer = Console.ReadLine()?.Trim().ToLower();

            if (answer == "b")
            {
                ColoredOutput("Correct! Polymorphism is the ability of a class to have multiple methods with the same name.", ConsoleColor.Green);

                // Practical Implementation, only task.PerformTask() is printing these three different tasks
                ColoredOutput("\nPractical Implementation on polymorphism: \n only task.PerformTask() is printing these three different tasks", ConsoleColor.Magenta);
                CodingTask[] tasks = { new CodingTask(), new DebuggingTask(), new TestingTask() };
                foreach (var task in tasks)
                {
                    ColoredOutput($"Executing {task.GetType().Name} Task:", ConsoleColor.Yellow);
                    task.PerformTask();
                    Console.WriteLine();
                }

                return true;
            }
            else
            {
                ColoredOutput("Incorrect! Polymorphism is the ability of a class to have multiple methods with the same name. Please try again.", ConsoleColor.Red);
                return Quiz(); // Retry the quiz
            }
        }
    }

    // Abstraction Concept - Code Structures
    class AbstractionConcept
    {
        public static bool Quiz()
        {
            ColoredOutput("\n--- Abstraction Concept ---", ConsoleColor.Yellow);
            ColoredOutput("What is abstraction in programming?", ConsoleColor.Cyan);
            ColoredOutput("a) Showing unnecessary details", ConsoleColor.White);
            ColoredOutput("b) Hiding unnecessary details and showing only essential information", ConsoleColor.White);
            ColoredOutput("c) Using arrays", ConsoleColor.White);
            Console.Write("Your answer (a, b, or c): ");
            string? answer = Console.ReadLine()?.Trim().ToLower();

            if (answer == "b")
            {
                ColoredOutput("Correct! Abstraction is the process of hiding unnecessary details and showing only essential information.", ConsoleColor.Green);

                // Practical Implementation
                ColoredOutput("\nPractical Implementation:", ConsoleColor.Magenta);
                CodeStructure structure = new LoopStructure();
                ColoredOutput($"Code Structure: {structure.Display()}", ConsoleColor.Yellow);
                

                return true;
            }
            else
            {
                ColoredOutput("Incorrect! Abstraction is the process of hiding unnecessary details and showing only essential information. Please try again.", ConsoleColor.Red);
                return Quiz(); // Retry the quiz
            }
        }
    }

    // Inheritance Concept - Code Features
    class InheritanceConcept
    {
        public static void Quiz()
        {
            ColoredOutput("\n--- Inheritance Concept ---", ConsoleColor.Yellow);
            ColoredOutput("What is inheritance in programming?", ConsoleColor.Cyan);
            ColoredOutput("a) Using multiple loops", ConsoleColor.White);
            ColoredOutput("b) The ability of a class to have multiple methods with the same name", ConsoleColor.White);
            ColoredOutput("c) Mechanism by which one class can inherit properties and behavior from another class", ConsoleColor.White);
            Console.Write("Your answer (a, b, or c): ");
            string? answer = Console.ReadLine()?.Trim().ToLower();

            if (answer == "c")
            {
                ColoredOutput("Correct! Inheritance is the mechanism by which one class can inherit properties and behavior from another class.", ConsoleColor.Green);

                // Practical Implementation
                ColoredOutput("\nPractical Implementation:", ConsoleColor.Magenta);
                CodeFeature feature = new InheritedFeature();
                ColoredOutput($"Code Feature: {feature.FeatureDescription()}", ConsoleColor.Yellow);
            }
            else
            {
                ColoredOutput("Incorrect! Inheritance is the mechanism by which one class can inherit properties and behavior from another class. Please try again.", ConsoleColor.Red);
                Quiz(); // Retry the quiz
            }
        }
    }

    // objects
  class ProgrammingTool
    {
        public string Name { get; }
        public string Type { get; }

        public ProgrammingTool(string name, string type)
        {
            Name = name ?? string.Empty;
            Type = type ?? string.Empty;
        }

        public override string ToString()
        {
            return $" programmingTool is an object with properties Name: {Name},  type:{Type}";
        }
    }

    // Coding Language class for Class Concept
    class CodingLanguage
    {
        public string Name { get; }
        public string Paradigm { get; }

        public CodingLanguage(string name, string paradigm)
        {
            Name = name ?? string.Empty;
            Paradigm = paradigm ?? string.Empty;
        }

        public override string ToString()
        {
            return $"CodingLanguage is a class used to create codingLanguage object with properties \n Name: {Name} \n Paradigm: {Paradigm}";
        }
    }

    // Code Snippet Container class for Encapsulation Concept
    class CodeSnippetContainer
    {
        private Dictionary<string, string> codeSnippets = new Dictionary<string, string>();

        public void AddSnippet(string language, string code)
        {
            codeSnippets[language ?? string.Empty] = code ?? string.Empty;
        }

        public void DisplaySnippets()
        {
            foreach (var snippet in codeSnippets)
            {
                Console.WriteLine($"{snippet.Key}: {snippet.Value}");
            }
        }
    }

    // Coding Task and its derived classes for Polymorphism Concept
    class CodingTask
    {
        public virtual void PerformTask()
        {
            Console.WriteLine("Performing a generic coding task.");
        }
    }

    class DebuggingTask : CodingTask
    {
        public override void PerformTask()
        {
            Console.WriteLine("Debugging the code.");
        }
    }

    class TestingTask : CodingTask
    {
        public override void PerformTask()
        {
            Console.WriteLine("Running test cases.");
        }
    }

    // Code Structure and its derived class for Abstraction Concept
    abstract class CodeStructure
    {
        public abstract string Display();
    }

    class LoopStructure : CodeStructure
    {
        public override string Display()
        {
            return "for (int i = 0; i < 10; i++) { \n Console.writeLine(i) \n}";
        }

       
    }

    // Code Feature and its derived class for Inheritance Concept
    class CodeFeature
    {
        public virtual string FeatureDescription()
        {
            return "Generic code feature.";
        }
    }

    class InheritedFeature : CodeFeature
    {
        public override string FeatureDescription()
        {
            return "Code feature with additional functionality.";
        }

        public override string ToString()
        {
            return FeatureDescription();
        }
    }

}































