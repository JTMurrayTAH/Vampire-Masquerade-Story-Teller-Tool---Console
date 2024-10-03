// See https://aka.ms/new-console-template for more information
using VTM_DMTool.Dice;

Console.WriteLine("Hello, World!");
int input;
DiceRoller diceRoller = new DiceRoller();
Console.WriteLine("How many dice do you want to roll?");

input = int.Parse(Console.ReadLine());
diceRoller.RollDice(input, 0);
Console.WriteLine("End of roll");
Console.ReadLine();