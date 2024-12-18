using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    public class Estoque
    {
        private List<Alimento> alimentos;
        private List<string> nomeAlimentos;

        public Estoque()
        {
            alimentos = new List<Alimento>();
            nomeAlimentos = new List<string>();
        }

        public void retornaAlimentos()
        {
            foreach(Alimento a in alimentos)
            {
                Console.WriteLine(a.ToString());
            }
        }

/*        public string consultaNome()
        {
            for(int i = 0; i < alimentos.Count(); i++)
            {
                nomeAlimentos.Add(alimentos[i].getNome());
            }

            foreach(string s in nomeAlimentos)
            {
                return s;
            }
            return "";
        }
*/
        public void adicionarAlimento(Alimento alimento)
        {
            alimentos.Add(alimento);
        }
    }
}
