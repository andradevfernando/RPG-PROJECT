namespace PROJETO_RPG.src.classes;
using PROJETO_RPG.src.classes;
using static System.Console;
using PROJETO_RPG.src.classes.weapons;
public class Weapons : Base
{

    public static Weapons weapons = new();
    public EnumWeapons Weapon;
    public enum EnumWeapons
    {
        Great_Sword = 1, Long_Sword, Sword_and_Shield, Dual_Blades, Lance, Gunlance, Hammer, Hunting_Horn, Switch_Axe, Charge_Blade, Insect_Glaive, Light_Bowgun, Heavy_Bowgun, Bow
    }

    public Weapons()
    {

    }
    public Weapons(int weapon)
    {
        this.Name = " ";
        this.Weapon = (EnumWeapons)weapon;
    }

    internal static string ChooseWeapon(int weapon)
    {
        Weapons character = new(weapon);
        character.Weapon = (EnumWeapons)weapon;

        return character.ToString();
    }
    public override string ToString()
    {
        return $"{this.Weapon.ToString().Replace("_", " ")}";
    }

    public static void ChooseWeapon(string weapon)
    {
        switch (weapon)
        {
            case "Great Sword":
                Great_Sword.GS.Attack();
                break;
        }
    }
    public static void List()
    {
        foreach (EnumWeapons weapon in (EnumWeapons[])Enum.GetValues(typeof(EnumWeapons)))
        {
            Console.WriteLine(weapon.ToString().Replace("_", " "));
        }
    }
}