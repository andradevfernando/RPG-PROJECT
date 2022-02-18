namespace PROJETO_RPG.src.classes.weapons;
using static System.Console;
public class Great_Sword : Combat
{

    public static Great_Sword GS = new();
    public void Attack()
    {
        Menu();
        string attack = ReadLine().ToUpper();
        switch (attack)
        {
            case "1":
                MoveSet(1, 30, 40);
                break;
            case "2":
                MoveSet(2, 40, 50);
                break;
            case "3":
                MoveSet(3, 60, 70);
                break;
            case "4":
                MoveSet(4, 80, 100);
                break;
            case "S":
                MoveSet(5, 100, 150);
                break;
            case "R":
                Roll();
                break;
            case "X":
                Character.character.Tick = 0;
                Character.character.Health = 0;
                break;
        }
    }
    static void Menu()
    {
        WriteLine(@$"
Choose your move
1- Basic attack
2- Overhead Slash
3- Wide Sweep
4- Rising Slash
S- Charged Slash
R- Roll
X- Forfeit");
    }
}
