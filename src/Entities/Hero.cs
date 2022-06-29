namespace _10__Abstraindo_um_Jogo_de_RPG_Usando_Orientação_a_Objetos_com_C_Sharp.src.Entities
{
    public abstract class Hero
    {
        // Atributos
        public string Name;
        public int Level;
        public string HeroType;

        // Metodo construtor
        public Hero(string Name, int Level, string Herotype)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = Herotype; 
        }

        public Hero()
        {

        }

        // Override e usado para sobrescrita de um método; Ele ignora o comportamento que foi herdado da outra classe e sobrepõe com o método q eu colocar abaixo
        public override string ToString()
        {
            return this.Name + " " + this.Level + " " + this.HeroType;
        }

        public virtual string Attack() // virtual = Eu permito que qualquer filho meu que herdar, altere esse comportamento meu
        {
            return this.Name + " Atacou com a sua espada";
        }

    }
}