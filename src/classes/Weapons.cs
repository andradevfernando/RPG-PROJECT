namespace PROJETO_RPG.src.classes;
using PROJETO_RPG.src.classes;
using static System.Console;
public class Weapons : Base
{
    public EnumWeapons Weapon;
    public static string[] weapon = Enum.GetNames(typeof(EnumWeapons));
    public enum EnumWeapons
    {
        Great_Sword = 1, Long_Sword, Sword_and_Shield, Dual_Blades, Lance, Gunlance, Hammer, Hunting_Horn, Switch_Axe, Charge_Blade, Insect_Glaive, Light_Bowgun, Heavy_Bowgun, Bow
    }

    public Weapons(int Weapon)
    {
        this.Weapon = (EnumWeapons)Weapon;
    }


    internal static void ChooseWeapon(int Weapon)
    {
        Weapons character = new(Weapon);
        WriteLine(character.ToString());
    }
    public override string ToString()
    {
        return $"{Environment.NewLine}Weapon: {this.Weapon.ToString().Replace("_", " ")}";
    }
}