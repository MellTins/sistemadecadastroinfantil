using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCC.cadastro
{
    public class Cadastro
    {
        public string Nome {  get; set; }
        public string Sobrenome { get; set; }
        public DateTime DataNasc {  get; set; }
        public string NomePai { get; set; }
        public string NomeMae { get; set; }
        public string RG {  get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public List<Cadastro> Cadastros { get; set; } = new List<Cadastro>();



         public void AddCadastro(string nome, string sobrenome,DateTime datanasc, string nomepai, string nomemae, string rg, string cidade, string estado)
        {
            var addCadastro = new Cadastro
            {
                Nome = nome,
                Sobrenome = sobrenome,
                DataNasc = datanasc,
                NomePai = nomepai,
                NomeMae = nomemae,
                RG = rg,
                Cidade = cidade,
                Estado = estado
            };
            Cadastros.Add(addCadastro);
        }

        public void ExibirCadastro()
        {
            foreach(var c in Cadastros)
            {
                Console.WriteLine($"Primeiro nome:{c.Nome} | Sobrenome: {c.Sobrenome} |Data de Nascimento: {c.DataNasc}|{c.Idade()} Nome do Pai:{c.NomePai} | Nome da Mãe:{c.NomeMae} | Rg da criança:{c.RG} | Cidade em que nasceu: {c.Cidade} | Estado em que nasceu:{c.Estado}");
            }
        }

        public string Idade()
        {
            var data = DateTime.Now;
            var idade = data.Year - DataNasc.Year;
            return $"Idade: {idade}";
        }
    }

   

}
/*
 nome/ sobrenome
data de nasc /idade
nome do pai e mae caso houver
rg
cidade onde nasceu/estado
 */