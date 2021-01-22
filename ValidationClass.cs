using System;
using System.Text;
using System.Text.RegularExpressions;

namespace MarsRovers
{
    class ValidationClass
    {
        readonly string[] instructions = new string[3];
        public ValidationClass()
        {
            instructions[0] = "L";
            instructions[1] = "R";
            instructions[2] = "M";
        }
        //To validate we only type cardinal points: North, East, South and West
        public string IsCardinal(string[] cardinalPoints)
        {
            string cardinal;
            StringBuilder sbCardinal = new StringBuilder();
            StringBuilder sbPattern = new StringBuilder("[");
            foreach (string s in cardinalPoints)
            {
                sbPattern.Append(s);
            }
            sbPattern.Append("]");
            bool resultIsMatch;
            do
            {
                Console.WriteLine("Type only only one of the four cardinal points (N,S,E,W) ");
                sbCardinal.Append(Console.ReadLine());
                sbCardinal.Remove(1, sbCardinal.Length - 1);
                //cardinal = cardinal.Length > 1 ? cardinal.Remove(1) : cardinal;
                cardinal = sbCardinal.ToString().ToUpper();
                resultIsMatch = Regex.IsMatch(cardinal, sbPattern.ToString());
            }
            while (!resultIsMatch);
            {
                return cardinal;
            }
        }

        //To validate we only type the instructions for rover: 90n degrees Left, 90 degrees Right and Move Forward.
        public string IsInstruction()
        {
            string instruction;
            StringBuilder sbInstruction = new StringBuilder();
            StringBuilder sbPattern = new StringBuilder("[^");
            foreach (string s in instructions)
            {
                sbPattern.Append(s);
            }
            sbPattern.Append("]");
            bool resultIsMatch;
            do
            {
                Console.WriteLine("\nwrite the instructions for rover: \n L:90 degrees left \n R:90 degrees right \n M:move froward");
                sbInstruction.Append(Console.ReadLine());
                instruction = sbInstruction.ToString().ToUpper();
                resultIsMatch = Regex.IsMatch(instruction, sbPattern.ToString());
            }
            while (resultIsMatch);
            {
                return instruction;
            }
        }

        //To validate we only type numbers as coordinates
        public int IsNumber()
        {
            bool isNumber;
            int value;
            string number;
            do
            {
                Console.WriteLine("Type an int value");
                number = Console.ReadLine();
                isNumber = int.TryParse(number, out value);
            }
            while (!isNumber);
            {
                return value;
            }
        }
    }
}
