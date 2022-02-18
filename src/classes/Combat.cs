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
    public void MonsterHealth(int monsterHealth)
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
            Monsters.monsters.Health += -random.Next(DmgMin, DmgMax);
        }
        else
        {
            Character.character.Health += -Monsters.monsters.Damage;
        }
        return;
    }
    public void Battle(string Weapon, string Monster)
    {
        Monsters.ChooseMonster(Monster);
        while (Monsters.monsters.Health > 0)
        {
            while (Character.character.Tick > 0)
            {
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

