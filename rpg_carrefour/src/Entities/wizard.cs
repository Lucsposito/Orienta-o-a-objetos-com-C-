namespace rpg_carrefour.src.Entities
{
    public class wizard:Hero
    {
        public wizard(string name, int level, string HeroType)
        {
            this.name=name;
            this.level=level;
            this.HeroType=HeroType;
        }
        public override string Attack()
        {
            return this.name + 'Lançou magia'

        }
        
        public string Attack(int Bonus){
           if (Bonus > 6){
               return this.name + 'Lançou magia super efetiva com bonus de ataque de '+ Bonus;
           }else
           {
               return this.name + 'Lançou magia com força fraca com bonus de ataque de '+ Bonus;
           }
           
 
        }

    }
}