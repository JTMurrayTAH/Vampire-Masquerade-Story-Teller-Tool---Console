using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VTM_DMTool.Dice
{
    internal class DiceRoller
    {
        // Total dicepool has Regular dice and Hunger dice.

        int NumOfDice; //Total Dice
        int NumOfHunger; // Hunger Dice

        List<int>? Results; // Results for regular Dice
        List<int>? HResults; // Results for hunger Dice

        Random Roller = new Random();

        public void RollDice(int NumOfDie, int NumOfHungerDie)
        {
            NumOfDice = NumOfDie;
            NumOfHunger = NumOfHungerDie;
            Console.WriteLine($"You want to roll : {NumOfDice} ");
            Console.WriteLine($"You want to roll Hunger die : {NumOfHungerDie} ");
            Console.ReadLine();
            RollRegularDie();
            RollHunger();
            CheckSuccess();
        }

        void RollRegularDie()
        {
            Console.Clear();
            int die = NumOfDice;
            int outcome;
            Results = new List<int>();
            die -= NumOfHunger;
            Console.WriteLine();
            Console.WriteLine("Normal Die");
            Console.WriteLine($"You will roll {die} number of normal die due to the {NumOfHunger} number of Hunger Die taking some of the dice place.");
            

            

            for (int i = 0; i < die;)
            {
                outcome = Roller.Next(1, 11);
                Results.Add(outcome);
                i++;
            }
            foreach (int Re in Results)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(Re);
                Console.ForegroundColor = ConsoleColor.White;
            }
            Console.WriteLine();
            Console.WriteLine("Hunger Die");
        }

        void RollHunger()
        {
            int outcome;
            HResults = new List<int>();
            int die = NumOfHunger;

            for (int i = 0; i < die;)
            {
                outcome = Roller.Next(1, 11);
                HResults.Add(outcome);
                i++;
            }
            foreach (int Re in HResults)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(Re);
                Console.ForegroundColor = ConsoleColor.White;

               
            } 
            Console.WriteLine($"Check results: Press enter");
        }
            void CheckSuccess()
            {
            int success = 0;
            int failures = 0;
            int halfCrits = 0;
            int fullCrits = 0;
            int hungerCrits = 0;
            bool beastialFailure = false;

            // Check regular dice
            foreach (int re in Results)
            {
                if (re == 10)
                {
                    halfCrits++;
                }
                else if (re > 5)
                {
                    success++; // Count as a success
                }
                else
                {
                    failures++; // Failure
                }
            }

            // Check hunger dice for special effects
            foreach (int hr in HResults)
            {
                if (hr == 10)
                {
                    halfCrits++;
                    hungerCrits++;  // Track criticals from hunger dice
                }
                else if (hr > 5)
                {
                    success++; // Count as a success
                }
                else if (hr == 1)
                {
                    beastialFailure = true;  // Mark beastial failure
                }
                else
                {
                    failures++; // Failure
                }
            }

            // Handle full crits: two half crits (10s) make a full crit which equals 2 additional successes
            fullCrits = halfCrits / 2;
            success += fullCrits * 2;  // Add 2 successes for each full crit

            // Handle remaining half crits (if there's an odd number, add 1 success for the leftover)
            if (halfCrits % 2 != 0)
            {
                success++;  // Remaining half crit contributes 1 success
            }

            // Handle outcomes
            Console.WriteLine($"Number of successes: {success}");
            Console.WriteLine($"Number of failures: {failures}");
            Console.WriteLine($"Number of half crits: {halfCrits}");
            Console.WriteLine($"Number of full crits: {fullCrits}");

            if (hungerCrits > 0)
            {
                Console.WriteLine("You rolled a critical on a hunger die!");
            }

            if (beastialFailure)
            {
                Console.WriteLine("Beastial Failure! You rolled a 1 on a hunger die.");
            }

            Console.ReadLine();
        }
        }
    }

