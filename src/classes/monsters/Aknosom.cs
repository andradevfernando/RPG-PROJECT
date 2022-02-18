namespace PROJETO_RPG.src.classes.monsters;

public class Aknosom : Combat
{

    public static Aknosom aknosom = new();
    public Aknosom()
    {
        Random random = new();
        Health = random.Next(2000, 3000);
        this.Damage = 0;
    }

    public void MoveSet1()
    {
        Console.WriteLine("Aknosom readies Crest Slam");
        Character.character.Tick = 2;
        Random random = new();
        Monsters.monsters.Damage = random.Next(10, 20);
    }
    public void MoveSet2()
    {
        Console.WriteLine("Aknosom readies Wing Slash");
        Character.character.Tick = 3;
        Random random = new();
        Monsters.monsters.Damage = random.Next(30, 40);
    }
    public void MoveSet3()
    {
        Console.WriteLine("Aknosom readies Charge");
        Character.character.Tick = 4;
        Random random = new();
        Monsters.monsters.Damage = random.Next(50, 60);
    }
    public void MoveSet4()
    {
        Console.WriteLine("Aknosom readies Fireball");
        Character.character.Tick = 5;
        Random random = new();
        Monsters.monsters.Damage = random.Next(70, 80);
    }
    public void SpecialMoveSet()
    {
        Console.WriteLine("Aknosom readies FIREBALL BARRAGE");
        Character.character.Tick = 6;
        Monsters.monsters.Damage = 100;
    }
    public void ChooseMoveSet()
    {
        Random random = new();
        int moveSet = random.Next(5);
        switch (moveSet)
        {
            case 1:
                MoveSet1();
                break;
            case 2:
                MoveSet2();
                break;
            case 3:
                MoveSet3();
                break;
            case 4:
                MoveSet4();
                break;
            case 5:
                SpecialMoveSet();
                break;
        }
    }

}
