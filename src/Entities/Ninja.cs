namespace _10__Abstraindo_um_Jogo_de_RPG_Usando_Orientação_a_Objetos_com_C_Sharp.src.Entities
{
    public class Ninja : Hero
    {
        public Ninja (string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
    }
}