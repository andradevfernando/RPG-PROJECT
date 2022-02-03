namespace PROJETO_RPG.src.classes.monsters
{
    public class Aknosom : Combat
    {
        public void SetHealth()
        {
            if (monsterHealth == 0)
            {
                Random random = new();
                monsterHealth = random.Next(2000, 3000);
            }
            else
            {
                return;
            }
        }
        public void MoveSet1()
        {
            this.tick = 2;
            Random random = new();
            this.monsterDamage = random.Next(10, 20);
        }
        public void MoveSet2()
        {
            this.tick = 3;
            Random random = new();
            this.monsterDamage = random.Next(30, 40);
        }
        public void MoveSet3()
        {
            this.tick = 4;
            Random random = new();
            this.monsterDamage = random.Next(50, 60);
        }
        public void MoveSet4()
        {
            this.tick = 5;
            Random random = new();
            this.monsterDamage = random.Next(70, 80);
        }
        public void SpecialMoveSet()
        {
            this.tick = 6;
            this.monsterDamage = 100;
        }
        public void ChooseMoveSet()
        {
            Random random = new();
            int moveSet = random.Next(5);
            switch (moveSet)
            {
                case 1:
                    MoveSet1();
                    break;
                case 2:
                    MoveSet2();
                    break;
                case 3:
                    MoveSet3();
                    break;
                case 4:
                    MoveSet4();
                    break;
                case 5:
                    SpecialMoveSet();
                    break;
            }
        }

    }
}