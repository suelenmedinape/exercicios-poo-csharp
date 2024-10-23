using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaiorIdade
{
    internal class Pessoa
    {
        private string _nome;
        private int _idade;

        public Pessoa()
        {
        }

        public Pessoa(string _nome, int _idade)
        {
            this._nome = _nome;
            this._idade = _idade;
        }

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public int Idade
        {
            get { return _idade; }
            set { _idade = value; }
        }

        public void ExibirDados(string nome, int idade)
        {
            //Console.WriteLine("A pessoa com a maior idade é: " + nome + " com idade de " + idade);
            Console.WriteLine($"Nome: {Nome}, Idade: {Idade}");
        }
    }
}
