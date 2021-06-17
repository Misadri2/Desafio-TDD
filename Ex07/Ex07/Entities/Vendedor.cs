using System;

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
            if (Salario < 10)
                throw new ArgumentException("Salário inválido");
            
            Salario += 3000.00;
        }
        
    }
}