namespace PROJETO_RPG.src.classes;
using static System.Console;
using PROJETO_RPG.src.classes.weapons;
using PROJETO_RPG.src.classes.monsters;
public class Monsters : Base
{
    public EnumMonsters Monster;
    public static Monsters monsters = new();
    public Monsters()
    {
        this.Name = " ";
        this.Health = 0;
        this.Damage = 0;
    }
    public Monsters(int Monster)
    {
        this.Monster = (EnumMonsters)Monster;
    }
    public enum EnumMonsters
    {
        Aknosom = 1, Almudron, Anjanath, Apex_Arzuros, Apex_Diablos, Apex_Mizutsune, Apex_Rathalos, Apex_Rathian, Apex_Zinogre, Arzuros, Barioth, Barroth, Basarios, Bazelgeuse, Bishaten
        , Chameleos, Crimson_Glow_Valstrax, Diablos, Goss_Harag, Great_Baggi, Great_Izuchi, Great_Wroggi, Jyuratodus, Khezu, Kulu_Ya_Ku, Kushala_Daora, Lagombi, Magnamalo, Mizutsune, Nargacuga,
        Pukei_Pukei, Rajang, Rakna_Kadaki, Rathalos, Rathian, Royal_Ludroth, Somnacanth, Teostra, Tetranadon, Thunder_Serpent_Narwa, Tigrex, Tobi_Kadachi, Volvidon, Wind_Serpent_Ibushi, Zinogre

    }
    public static string[] monster = Enum.GetNames(typeof(EnumMonsters));

    internal static string NameMonster(int Monster)
    {
        Monsters character = new(Monster);
        character.Monster = (EnumMonsters)Monster;

        return character.ToString();
    }
    public static void ChooseMonster(string monster)
    {
        Character.character.Tick = 0;
        switch (monster)
        {
            case "Aknosom":
                Aknosom.aknosom.ChooseMoveSet();
                break;
        }
    }
    public static void ChooseMonsterHealth(string monster)
    {
        switch (monster)
        {
            case "Aknosom":
                monsters.Health = Aknosom.aknosom.Health;
                break;
        }
    }
    public static void List()
    {
        foreach (EnumMonsters monster in (EnumMonsters[])Enum.GetValues(typeof(EnumMonsters)))
        {
            Console.WriteLine(monster.ToString().Replace("_", " "));
        }
    }
    public override string ToString()
    {
        return $"{this.Monster.ToString().Replace("_", " ")}";
    }
}
