namespace PROJETO_RPG.src.classes;
using static System.Console;
using PROJETO_RPG.src.classes.weapons;
public abstract class Base
{
    public string Name;
    public int Health;
    public int Tick;
    public int Damage;

    public static void List(string[] list)
    {
        WriteLine(Environment.NewLine);
        for (int i = 0; i < list.Length; i++)
        {
            WriteLine((i + 1) + "-" + list[i].ToString().Replace("_", " "));
        }
        return;
    }
}

