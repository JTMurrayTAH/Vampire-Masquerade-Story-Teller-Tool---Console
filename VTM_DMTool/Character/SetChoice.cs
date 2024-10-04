// See https://aka.ms/new-console-template for more information
public class StringChoice()
{
    string Name = "";
    string[] Options = { "" };
    int selectedOption;
    public string OutcomeChoice = "";

    public StringChoice(string name, string[] options) : this()
    {
        Name = name;
        Options = options;
        ChooseRandomOption();
    }

    void ChooseRandomOption()
    {
        int MaxOption = Options.Length;
        selectedOption = new Random().Next(MaxOption);
        OutcomeChoice = Options[selectedOption];
        Console.WriteLine(Name + ":");
        Console.WriteLine(OutcomeChoice);
    }
}