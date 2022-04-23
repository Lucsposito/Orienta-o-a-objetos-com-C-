namespace rpg_carrefour.src.Entities
{
    public abstract class Hero
    {
        public Hero(string name, int level, string HeroType)
        {
            this.name=name;
            this.level=level;
            this.HeroType=HeroType;
        }
        
        public string name;

        public int level;

        public string HeroType;

        public override string ToString(){
            return this.nome + " "+ this.level+" "+ this.HeroType;
        }

        public override string Attack()
        {
            return this.name + 'Atacou com sua espada'

        }

    }
}