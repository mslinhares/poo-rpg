namespace poo.src.Entities.HeroTypes
{
    public class Wizard : Hero
    {
        public string TypeOfMagic; 
        public Wizard(string Name, int Level, string HeroType, string TypeOfMagic)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.TypeOfMagic = TypeOfMagic;
        }
        public override string Attack(){
            return " > " +this.Name + " tem magia "+this.TypeOfMagic+" e lançou um feitiço";
        }
        public string Attack(int Nivel)
        {
            if(Nivel > 6)
            {
            return " > " +this.Name + " tem magia "+this.TypeOfMagic+" e lançou um feitiço nível " + Nivel;
            }else
            {
                return " > " +this.Name + " lançou seu super feitiço de magia "+this.TypeOfMagic;
            }
            
            
        }
    }
}