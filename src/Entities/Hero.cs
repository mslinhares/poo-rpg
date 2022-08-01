namespace poo.src.Entities
{
    public class Hero
    {
        public Hero(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
        public Hero()
        {

        }

        public string Name;
        public int Level;
        public string HeroType;

        public override string ToString()
        {
            return " > " +this.Name + ", Nivel: " + this.Level + ", Classe: " + this.HeroType;
        }
        virtual public string Attack()
        {
            return " > " +this.Name + ": Ataque";
        }

    }
}