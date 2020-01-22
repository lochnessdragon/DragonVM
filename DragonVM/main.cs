using System;
using Dragon;

class MainClass {
    static void Main(string[] args)
    {
        Console.WriteLine("Main Started!");
        VM virtualMachine = new VM(new int[] { 0, 0, 99 });
        virtualMachine.start();

        Console.WriteLine("Press Enter to Exit.");
        Console.Read();
    }
}