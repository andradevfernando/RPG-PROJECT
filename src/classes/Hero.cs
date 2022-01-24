namespace PROJETO_RPG.src.classes;
public abstract class Hero
{

    public Hero(string Name, int Level, string heroType)
    {
        this.Name = Name;
        this.Level = Level;
        this.heroType = heroType;
    }
    public Hero() { }
    public string Name;
    public int Level;
    public string heroType;

    public override string ToString()
    {
        return $"{this.Name} {this.Level} {this.heroType}";
    }

    public virtual string Attack()
    {
        return this.Name + " Atacou com a sua espada";
    }
}