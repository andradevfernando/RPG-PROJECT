namespace PROJETO_RPG.src.classes;
public class Wizard : Hero
{
    public Wizard(string Name, int Level, string heroType)
    {
        this.Name = Name;
        this.Level = Level;
        this.heroType = heroType;
    }
    public override string Attack()
    {
        return this.Name + " Lançou magia";
    }
    public string Attack(int Bonus)
    {
        if (Bonus > 6)
        {
            return this.Name + " Lançou magia com bônus super efetivo de ataque de " + Bonus;
        }
        else
        {
            return this.Name + " Lançou magia com bônus de ataque fraco de " + Bonus;
        }
    }
}

