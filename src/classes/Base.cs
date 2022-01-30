namespace PROJETO_RPG.src.classes;
using static System.Console;
public class Base
{

    public static void List(string[] Weapon)
    {
        WriteLine(Environment.NewLine);
        for (int i = 0; i < Weapon.Length; i++)
        {
            WriteLine((i + 1) + "-" + Weapon[i].ToString().Replace("_", " "));
        }
        return;
    }
}

