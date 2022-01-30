namespace PROJETO_RPG.src.classes;
using static System.Console;
public class Character : Base
{
    public string Name;
    public Character(string Name)
    {
        this.Name = Name;
    }
    internal static void Creation(string Name)
    {
        Character character = new(Name);
        WriteLine(character.ToString());
    }
    public override string ToString()
    {
        return $"{Environment.NewLine}Name: {this.Name}";
    }

}