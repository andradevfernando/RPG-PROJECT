namespace PROJETO_RPG.src.classes;
using static System.Console;
public class Monsters : Base
{
    public EnumMonsters Monster;
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

    internal static void ChooseMonster(int Monster)
    {
        Monsters character = new(Monster);
        WriteLine(character.ToString());

    }
    public override string ToString()
    {
        return $"{Environment.NewLine}Monster: {this.Monster.ToString().Replace("_", " ")}";
    }
}
