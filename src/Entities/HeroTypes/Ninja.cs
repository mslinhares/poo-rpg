namespace poo.src.Entities.HeroTypes
{
    public class Ninja : Hero
    {
         public Ninja(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
        public override string Attack(){
            return  " > " +this.Name + ": lançou um shuriken";
        }
        public string Attack(int Bonus)
        {
            if(Bonus < 4)
            {
                 return  " > " +this.Name + ": soltou um golpe com bonus de " + Bonus;
            }else
            {
                 return  " > " +this.Name + ": Super ataque";
            }
            
            
        }

        
    }
}