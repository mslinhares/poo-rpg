namespace poo.src.Entities.HeroTypes
{
    public class Knight: Hero
    {
        public Knight(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
        public override string Attack(){
        return " > " + this.Name + ": ataque com a espada.";
        }
        
        public string Attack(int Vezes)
        {
            if(Vezes <= 3)
            {
                 return " > " + this.Name + ": ataque " + Vezes + " vezes com a espada. " ;
            }else
            {
                 return " > " + this.Name + ": Super ataque";
            }
            
            
        }
      
    }
}