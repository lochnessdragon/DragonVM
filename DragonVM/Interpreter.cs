using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dragon
{

    class Interpreter
    {
        
        public void Interpret(string code)
        {
            Console.WriteLine(code);
            string[] lines = code.Split('\n');
            foreach(string line in lines)
            {
                ProcessLine(line);
            }
        }

        public void ProcessLine(string line)
        {
            string[] parts = line.Split('+');
            int total = 0;
            foreach (string part in parts)
            {
                total += Int32.Parse(part);
            }
            Console.WriteLine(total);
        }

    }
}
