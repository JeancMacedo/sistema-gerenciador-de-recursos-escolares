using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    public class Alimento
    {
        private string nome;
        private int quantidade;
        private int categoria;
        private int validade;
        private int tipo;

        public Alimento(string nome, int quantidade, int categoria, int validade, int tipo)
        {
            this.nome = nome;
            this.quantidade = quantidade;
            this.categoria = categoria;
            this.validade = validade;
            this.tipo = tipo;
        }

        public string getNome()
        {
            return nome;
        }

        public string getQuantidade()
        {
            return quantidade.ToString();
        }

        public string getCategoria()
        {
            return categoria.ToString();
        }

        public string getValidade()
        {
            return validade.ToString();
        }

        public string getTipo()
        {
            return tipo.ToString();
        }

        public override string ToString()
        {
            return "Nome: " + getNome() + "\nQuantidade: " + getQuantidade() + "\nCategoria: " + getCategoria() + "\nTipo: " + getTipo() + "\nValidade: " + getValidade() + "\n";
        }
    }
}
