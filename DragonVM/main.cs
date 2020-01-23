using System;
using Dragon;

class MainClass {
    static void Main(string[] args)
    {
        Console.WriteLine("Main Started!");
        Interpreter interpreter = new Interpreter();

        string inputStr;

        if (args.Length > 0)
        {
            inputStr = System.IO.File.ReadAllText(args[0]);
            interpreter.Interpret(inputStr);
            return;
        }

        while(true)
        {
            Console.Write("dragoncode> ");
            inputStr = Console.ReadLine();

            if(inputStr == "quit")
            {
                break;
            } else if (inputStr == "usage")
            {
                Usage();
                break;
            }

            interpreter.Interpret(inputStr);
        }

        Console.WriteLine("Press Enter to Exit.");
        Console.Read();
    }

    static void Usage()
    {
        Console.WriteLine("mono main.exe (filename)");
    }
}