// See https://aka.ms/new-console-template for more information
namespace PROJETO_RPG;
using static System.Console;
using PROJETO_RPG.src.classes;
using PROJETO_RPG.src.classes.weapons;

class Program
{

    public string character;
    public string weapon;
    public string monster;
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
                    string character = Character.Creation(ReadLine());
                    WriteLine(character);
                    break;
                case "2":
                    WriteLine($"{Environment.NewLine}Choose your weapon:");
                    string weapon = Weapons.NameWeapon(int.Parse(ReadLine()));
                    WriteLine(weapon);
                    break;
                case "3":
                    WriteLine($"{Environment.NewLine}Choose monster:");
                    string monster = Monsters.NameMonster(int.Parse(ReadLine()));
                    WriteLine(monster);
                    break;
                case "4":
                    Monsters.List(Monsters.monster);
                    break;
                case "5":
                    Weapons.List(Weapons.weapon);
                    break;
                case "6":
                    Console.Clear();
                    break;
                case "7":
                    Combat combat = new();
                    weapon = "1";
                    monster = "Aknosom";
                    combat.Battle(weapon, monster);
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


