namespace Ex07.Entities
{
    class Funcionario
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public double Salario { get; set; }

        public Funcionario()
        {

        }

        public Funcionario (string nome, int idade, double salario)
        {
            Nome = nome;
            Idade = idade;
            Salario = salario; 
        }

        public virtual void Bonificacao(double Bonificacao)
        {
            Salario += Bonificacao;
        }
    }
}