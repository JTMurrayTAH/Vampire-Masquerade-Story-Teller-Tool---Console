using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VTM_Generator
{
    public class IntChoice
    {
        string Name = "";
        int MinValue;
        int MaxValue;
        public int OutcomeChoice;

        public IntChoice(string name, int minValue, int maxValue)
        {
            Name = name;
            MinValue = minValue;
            MaxValue = maxValue;
            ChooseRandomOption();
        }

        void ChooseRandomOption()
        {
            OutcomeChoice = new Random().Next(MinValue, MaxValue + 1); // +1 to include MaxValue
            Console.WriteLine(Name + ": ");
            Console.WriteLine(OutcomeChoice);
        }
    }
}
