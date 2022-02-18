namespace PROJETO_RPG.src.classes;
using PROJETO_RPG.src.classes.weapons;

public class Combat : Base
{

    public Combat()
    {
    }

    public virtual void TickRate(int tickrate)
    {
        Character.character.Tick += -tickrate;
    }
    public void Roll()
    {
        TickRate(1);
        if (Character.character.Tick == 0)
        {
            Console.WriteLine("Dodge executed succesfully");
        }
        else
        {
            Console.WriteLine("Rolled in the ground");
        }
    }
    public static void MonsterHealth(int monsterHealth)
    {
        Monsters.monsters.Health += -monsterHealth;
        return;
    }
    public void MoveSet(int tick, int DmgMin, int DmgMax)
    {
        TickRate(tick);
        Random random = new();
        if (Character.character.Tick > 0)
        {
            int damage = random.Next(DmgMin, DmgMax);
            Monsters.monsters.Health += -damage;
            Console.WriteLine($"Did {damage} damage to {Monsters.monsters.Name}");
            Console.WriteLine($"Monster health remaining: {Monsters.monsters.Health}");
        }
        else
        {
            Character.character.Health += -Monsters.monsters.Damage;
            Console.WriteLine($"{Character.character.Name} received {Monsters.monsters.Damage} damage by {Monsters.monsters.Name}");
            Console.WriteLine($"{Character.character.Name} health remaining: {Character.character.Health}");
        }
        return;
    }
    public static void Battle(string Weapon, string Monster)
    {
        Monsters.ChooseMonsterHealth(Monster);

        while (Monsters.monsters.Health > 0)
        {
            Monsters.ChooseMonster(Monster);
            while (Character.character.Tick > 0)
            {
                Console.WriteLine($"Ticks remaining: {Character.character.Tick}");
                Weapons.ChooseWeapon(Weapon);
            }
            if (Character.character.Health <= 0)
            {
                Console.WriteLine("The monster has defeated you");
                return;
            }
            if (Monsters.monsters.Health <= 0)
            {
                Console.WriteLine("You defeated the monster!");
                return;
            }
        }
    }
}

