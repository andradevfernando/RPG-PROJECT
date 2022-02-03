namespace PROJETO_RPG.src.classes;
using PROJETO_RPG.src.classes.weapons;

public class Combat : Weapons
{
    public int monsterHealth;
    public int tick;
    public int playerHealth = 100;
    public int monsterDamage;

    public virtual void TickRate(int tickrate)
    {
        tick += -tickrate;
        return;
    }
    public void Roll()
    {
        tick += -1;
        if (tick == 0)
        {
            Console.WriteLine("Dodge executed succesfully");
        }
        else
        {
            Console.WriteLine("Rolled in the ground");
        }
    }
    public virtual void MonsterHealth(int monsterHealth)
    {
        this.monsterHealth += -monsterHealth;
        return;
    }
    public virtual void MoveSet1(int tick, int DmgMin, int DmgMax)
    {
        TickRate(tick);
        Random random = new();
        if (this.tick > 0)
        {
            monsterHealth += -random.Next(DmgMin, DmgMax);
        }
        else
        {
            playerHealth += -monsterDamage;
        }
        return;
    }
    public virtual void MoveSet2(int tick, int DmgMin, int DmgMax)
    {
        TickRate(tick);
        Random random = new();
        if (this.tick > 0)
        {
            monsterHealth += -random.Next(DmgMin, DmgMax);
        }
        else
        {
            playerHealth += -monsterDamage;
        }
        return;
    }
    public virtual void MoveSet3(int tick, int DmgMin, int DmgMax)
    {
        TickRate(tick);
        Random random = new();
        if (this.tick > 0)
        {
            monsterHealth += -random.Next(DmgMin, DmgMax);
        }
        else
        {
            playerHealth += -monsterDamage;
        }
        return;
    }
    public virtual void MoveSet4(int tick, int DmgMin, int DmgMax)
    {
        TickRate(tick);
        Random random = new();
        if (this.tick > 0)
        {
            monsterHealth += -random.Next(DmgMin, DmgMax);
        }
        else
        {
            playerHealth += -monsterDamage;
        }
        return;
    }
    public virtual void SpecialMoveSet(int tick, int DmgMin, int DmgMax)
    {
        TickRate(tick);
        Random random = new();
        if (this.tick > 0)
        {
            monsterHealth += -random.Next(DmgMin, DmgMax);
        }
        else
        {
            playerHealth += -monsterDamage;
        }
        return;
    }

    public virtual void Battle(string Weapon, string Monster)
    {
        Weapons weapon = new();
        Monsters monster = new();

        monster.ChooseMonster(Monster);

        while (monsterHealth > 0)
        {
            while (this.tick > 0)
            {
                weapon.ChooseWeapon(Weapon);
            }
            if (playerHealth <= 0)
            {
                Console.WriteLine("The monster has defeated you");
                return;
            }
            if (monsterHealth <= 0)
            {
                Console.WriteLine("You defeated the monster!");
                return;
            }
        }
    }
}

