// See https://aka.ms/new-console-template for more information
using VTM_DMTool.Dice;

Console.WriteLine("Hello, You will be asked in order: How many dice you want to roll and how many hunger dice.");
int input1, input2;
DiceRoller diceRoller = new DiceRoller();
Console.WriteLine("How many NORMAL dice do you want to roll?");
input1 = int.Parse(Console.ReadLine());
Console.WriteLine("How many HUNGER dice do you want to roll?");
input2 = int.Parse(Console.ReadLine());
diceRoller.RollDice(input1, input2);
Console.WriteLine("End of roll");
Console.ReadLine();