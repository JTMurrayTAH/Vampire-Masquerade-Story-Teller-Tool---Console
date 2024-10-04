using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VTM_Generator;

namespace VTM_DMTool.Dice
{
    internal class Menu
    {   
        DiceRoller diceRoller = new DiceRoller();
        CharacterCreator QCharCrea = new CharacterCreator();
        public Menu()
        {
            Console.ReadLine();
            MenuStart();
        }
        void MenuStart()
        {
            Console.Clear();
            int input;
            Console.WriteLine("Welcome to Vampire the Masquerade DM Tools:");
            Console.WriteLine("1: Dice Roller");
            Console.WriteLine("2: Quick Character Creator");
            Console.WriteLine("3: Character creator and database");

            while (!int.TryParse(Console.ReadLine(), out input) || input < 0 || input > 4)
            {
                Console.WriteLine("Invalid input. Please enter a positive number for HUNGER dice:");
            }
            if (input == 1) { DiceRollerStart(); }
            if (input == 2) { QCharacterMaker(); }
            if (input == 3) { }
        }

        void QCharacterMaker()
        {
            int input;
            Console.Clear();
            Console.WriteLine("Hello, how many characters do you want to generate?");
            while (!int.TryParse(Console.ReadLine(), out input) || input < 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive number for Characters:");
            }
            QCharCrea.StartChar(input);
            QCharRestart();
        }

        void QCharRestart()
        {
            string input;
            Console.WriteLine("Would you like to generate again?");
            Console.WriteLine("Y = Yes, N = No");
            input = Console.ReadLine();

            // Default to "Y" if input is empty, or convert input to uppercase for comparison
            if (string.IsNullOrEmpty(input))
            {
                input = "Y"; // Default to "Y" if no input
            }
            else
            {
                input = input.ToUpper(); // Normalize input to uppercase for easier comparison
            }
            // Check the input
            if (input == "Y")
            {
                Console.WriteLine("You selected Yes.");
                QCharacterMaker();
            }
            else if (input == "N")
            {
                Console.WriteLine("You selected No.");
                MenuStart();
            }
            else
            {
                Console.WriteLine("Invalid input. Defaulting to Yes.");
                QCharacterMaker();
            }
        }

        void DiceCheckRestart()
        {
            string input;
            Console.WriteLine("Would you like to roll again?");
            Console.WriteLine("Y = Yes, N = No");
            input = Console.ReadLine();

            // Default to "Y" if input is empty, or convert input to uppercase for comparison
            if (string.IsNullOrEmpty(input))
            {
                input = "Y"; // Default to "Y" if no input
            }
            else
            {
                input = input.ToUpper(); // Normalize input to uppercase for easier comparison
            }

            // Check the input
            if (input == "Y")
            {
                Console.WriteLine("You selected Yes.");
                DiceRollerStart();
            }
            else if (input == "N")
            {
                Console.WriteLine("You selected No.");
                MenuStart();
            }
            else
            {
                Console.WriteLine("Invalid input. Defaulting to Yes.");
                DiceRollerStart();
            }
        }

        void DiceRollerStart()
            {
            Console.Clear();
            Console.WriteLine("Hello, You will be asked in order: How many dice you want to roll and how many hunger dice.");
            int input1 = 0, input2 = 0, input3 = 1;
            

            Console.WriteLine("How many NORMAL dice do you want to roll?");
            while (!int.TryParse(Console.ReadLine(), out input1) || input1 < 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive number for NORMAL dice:");
            }

            Console.WriteLine("How many HUNGER dice do you want to roll?");
            while (!int.TryParse(Console.ReadLine(), out input2) || input2 < 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive number for HUNGER dice:");
            }

            Console.WriteLine("How difficult is it (1 to 9)?");
            while (!int.TryParse(Console.ReadLine(), out input3) || input3 < 1 || input3 > 9)
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 9 for difficulty:");
            }

            diceRoller.RollDice(input1, input2, input3);
            Console.WriteLine("End of roll");
            Console.ReadLine();
            DiceCheckRestart();
            }



        }
    }

