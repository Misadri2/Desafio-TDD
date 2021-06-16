namespace Ex07.Entities
{
        public class Vendedor : Funcionario
        {
        public Vendedor ()
        {
            
        }

        public Vendedor (string nome, int idade, double salario) 
        : base (nome, idade, salario)
        {

        }

        public override void Bonificacao(double Bonificacao)
        {
            base.Bonificacao(Bonificacao);
            Salario += 3000;
        }
    }
}