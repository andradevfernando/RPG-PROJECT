namespace PROJETO_RPG.src.classes;
using static System.Console;
using PROJETO_RPG.src.classes.weapons;
public abstract class Base
{

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

