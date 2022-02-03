namespace PROJETO_RPG.src.classes;
using static System.Console;
using System.IO;
using PROJETO_RPG.src.classes.weapons;
using System.Collections.Generic;
using System.Linq;
using System.Text;
public class Character : Base
{
    public string Name;
    public Character(string Name)
    {
        this.Name = Name;
    }
    public static string Creation(string Name)
    {
        Character character = new(Name);
        character.Name = Name;

        var path = Path.Combine(Environment.CurrentDirectory, "texts");
        var di = new DirectoryInfo(path);
        if (!di.Exists)
        {
            di.Create();
        }
        path = Path.Combine(path, "character.csv");
        using var sw = new StreamWriter(path, false);
        var linha = $"{character.Name}";
        sw.WriteLine(linha);
        sw.Close();

        return character.ToString();
    }
    public override string ToString()
    {
        return $"{Environment.NewLine}Name: {this.Name}";
    }

}