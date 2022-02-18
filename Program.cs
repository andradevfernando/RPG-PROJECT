// See https://aka.ms/new-console-template for more information
namespace PROJETO_RPG;
using static System.Console;
using PROJETO_RPG.src.classes;
using PROJETO_RPG.src.classes.weapons;

class Program
{
    static void Main(string[] args)
    {
        Choose();
    }
    static void Choose()
    {
        Menu();
        string choose = ReadLine();

        while (choose != "X".ToUpper())
        {
            switch (choose)
            {
                case "1":
                    WriteLine($"{Environment.NewLine}Choose your name:");
                    Character.character = new(ReadLine());
                    WriteLine($"{Environment.NewLine}Your name is: {Environment.NewLine}{Character.character.Name}");
                    break;
                case "2":
                    WriteLine($"{Environment.NewLine}Choose your weapon:");
                    Weapons.weapons.Name = Weapons.ChooseWeapon(int.Parse(ReadLine()));
                    WriteLine(Monsters.monsters.Name);
                    break;
                case "3":
                    WriteLine($"{Environment.NewLine}Choose monster:");
                    Monsters.monsters.Name = Monsters.NameMonster(int.Parse(ReadLine()));
                    WriteLine(Monsters.monsters.Name);
                    break;
                case "4":
                    Monsters.List();

                    break;
                case "5":
                    Weapons.List();
                    break;
                case "6":
                    Console.Clear();
                    break;
                case "7":
                    Combat combat = new();
                    break;


                default:
                    throw new ArgumentOutOfRangeException();
            }
            Menu();
            choose = ReadLine().ToUpper();
        }

    }
    static void Menu()
    {
        WriteLine(@$"
Welcome, choose your option
1- Create your character
2- Choose your weapon
3- Choose monster to fight
4- List Monsters
5- List Weapons
6- Open game tutorial
7- Go to battle
X- Leave");
    }
}


