namespace PROJETO_RPG.src.classes;
using PROJETO_RPG.src.classes;
using static System.Console;
using PROJETO_RPG.src.classes.weapons;
public class Weapons : Base
{

    public EnumWeapons Weapon;
    public static string[] weapon = Enum.GetNames(typeof(EnumWeapons));
    public enum EnumWeapons
    {
        Great_Sword = 1, Long_Sword, Sword_and_Shield, Dual_Blades, Lance, Gunlance, Hammer, Hunting_Horn, Switch_Axe, Charge_Blade, Insect_Glaive, Light_Bowgun, Heavy_Bowgun, Bow
    }

    public Weapons()
    {

    }
    public Weapons(int Weapon)
    {
        this.Weapon = (EnumWeapons)Weapon;
    }

    internal static string NameWeapon(int Weapon)
    {
        Weapons character = new(Weapon);
        character.Weapon = (EnumWeapons)Weapon;

        var path = Path.Combine(Environment.CurrentDirectory, "texts");
        var di = new DirectoryInfo(path);
        if (!di.Exists)
        {
            di.Create();
        }
        path = Path.Combine(path, "weapon.csv");
        using var sw = new StreamWriter(path, false);
        var linha = $"{character.Weapon}";
        sw.WriteLine(linha);
        sw.Close();

        return character.ToString();
    }
    public override string ToString()
    {
        return $"{Environment.NewLine}Weapon: {this.Weapon.ToString().Replace("_", " ")}";
    }

    public void ChooseWeapon(string weapon)
    {
        switch (weapon)
        {
            case "Great Sword":
                Great_Sword GS = new();
                GS.Attack();
                break;
        }
    }
}