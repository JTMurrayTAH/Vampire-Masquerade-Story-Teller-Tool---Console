using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VTM_DMTool.Dice
{
    internal class DiceRoller
    {
        int NumOfDice; //Total Dice
        int NumOfHunger; // Hunger Dice
        List<int>? Results;
        List<int>? HResults;
        Random Roller = new Random();

        public void RollDice(int NumOfDie, int NumOfHungerDie)
        {
            NumOfDice = NumOfDie;
            NumOfHunger = NumOfHungerDie;
            Console.WriteLine($"You want to roll : {NumOfDice} ");
            Console.WriteLine($"You want to roll Hunger die : {NumOfHungerDie} ");
            Console.ReadLine();
            RollRegularDie();
        }

        void RollRegularDie()
        {
            Console.Clear();
            int die = NumOfDice;
            int outcome;
            
            Results = new List<int>();
            die -= NumOfHunger;

            for (int i = 0; i < die;)
            {
                outcome = Roller.Next(1, 10);
                Results.Add(outcome);
                i++;
            }
            foreach (int Re in Results) 
            {
                Console.WriteLine(Re);
            }
            Console.WriteLine();
            Console.WriteLine("Hunger Die");
            RollHunger();
        }

        void RollHunger()
        {
            int outcome;
            HResults = new List<int>();
            int die = NumOfHunger;
        }

        void CheckSuccess()
        {   int success = 0;
            int Failures = 0;
            int HalfCrits = 0;
            int FullCrits = 0;
            

        }
    }
}
