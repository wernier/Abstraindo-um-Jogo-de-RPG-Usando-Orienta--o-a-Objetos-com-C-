

namespace _10__Abstraindo_um_Jogo_de_RPG_Usando_Orientação_a_Objetos_com_C_Sharp.src.Entities
{
    
    public class Wizard : Hero
    {
        
        // Metodo Construtor Wizard
        public Wizard (string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;

        }

        public Wizard()
        {

        }

        // Sobreescrevendo o Ataque herdado da classe mãe
        public override string Attack()
        {
            return this.Name + " Lançou Magia.";
        }

        // Polimorfismo: ataque com bônus
        public string Attack(int Bonus)
        {

            if (Bonus > 6) {
                return this.Name + " Lançou Magia super efetiva com bônus de " + Bonus;
            } 
            else {
                return this.Name + " Lançou uma magia com força fraca com bõnus de " + Bonus;
            }
        }


    }
    
}