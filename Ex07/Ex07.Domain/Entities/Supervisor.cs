namespace Ex07.Entities
{
    class Supervisor : Funcionario
    {
        public Supervisor ()
        {
            
        }

        public Supervisor (string nome, int idade, double salario) 
        : base (nome, idade, salario)
        {

        }

        public override void Bonificacao(double Bonificacao)
        {
            base.Bonificacao(Bonificacao);
            Salario += 5000;
        }
    }
}