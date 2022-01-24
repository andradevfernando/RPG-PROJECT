// See https://aka.ms/new-console-template for more information
namespace PROJETO_RPG;
using static System.Console;
using PROJETO_RPG.src.classes;

class Program
{
    static void Main(string[] args)
    {

        Knight arus = new("Arus", 23, "Knight");
        Wizard jennica = new("Jennica", 23, "White Wizard");

        WriteLine(arus.Attack());
        WriteLine(jennica.Attack(7));
    }
}

