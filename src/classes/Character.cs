namespace PROJETO_RPG.src.classes;
using static System.Console;
using System.IO;
using PROJETO_RPG.src.classes.weapons;
using System.Collections.Generic;
using System.Linq;
using System.Text;
public class Character : Base
{
    public static Character character = new();
    public Character()
    {

    }
    public Character(string name)
    {
        this.Name = name;
        this.Health = 100;
        this.Tick = 0;
    }

}