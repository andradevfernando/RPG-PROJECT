namespace PROJETO_RPG.src.classes;
using static System.Console;
using PROJETO_RPG.src.classes.weapons;
using PROJETO_RPG.src.classes.monsters;
public class Monsters : Base
{
    public EnumMonsters Monster;
    public Monsters()
    {

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

        var path = Path.Combine(Environment.CurrentDirectory, "texts");
        var di = new DirectoryInfo(path);
        if (!di.Exists)
        {
            di.Create();
        }
        path = Path.Combine(path, "monster.csv");
        using var sw = new StreamWriter(path, false);
        var linha = $"{character.Monster}";
        sw.WriteLine(linha);
        sw.Close();

        return character.ToString();
    }
    public void ChooseMonster(string monster)
    {
        switch (monster)
        {
            case "Aknosom":
                Aknosom aknosom = new();
                aknosom.SetHealth();
                aknosom.ChooseMoveSet();
                break;
        }
    }
    public override string ToString()
    {
        return $"{Environment.NewLine}Monster: {this.Monster.ToString().Replace("_", " ")}";
    }
}
