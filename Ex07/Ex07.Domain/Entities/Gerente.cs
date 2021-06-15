namespace Ex07.Entities
{
    class Gerente : Funcionario
    {
        public Gerente ()
        {
            
        }

        public Gerente (string nome, int idade, double salario) 
        : base (nome, idade, salario)
        {

        }

        public override void Bonificacao(double salario)
        {
            base.Bonificacao(salario);
            Salario += 10000;
        }
       
    }
}