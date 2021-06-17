using System;

namespace Ex07.Entities
{
        public class Gerente : Funcionario
        {
        public Gerente ()
        {
            
        }

        public Gerente (string nome, int idade, double salario) 
        : base (nome, idade, salario)
        {

        }

        public override void Bonificacao(double Bonificacao)
        {
            base.Bonificacao(Bonificacao);
            if (Salario < 10)
                throw new ArgumentException("Salário inválido");
            Salario += 10000;
        }
       
    }
}