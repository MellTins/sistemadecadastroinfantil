using SCC.cadastro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCC.Entidades
{
    public class Crianca
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public DateTime DataNasc { get; set; }
        public string NomePai { get; set; }
        public string NomeMae { get; set; }
        public string RG { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public List<Crianca> Cadastros { get; set; } = new List<Crianca>();



        public void Adicionar(string nome, string sobrenome, DateTime datanasc, string nomepai, string nomemae, string rg, string cidade, string estado)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            DataNasc = datanasc;
            NomePai = nomepai;
            NomeMae = nomemae;
            RG = rg;
            Cidade = cidade;
            Estado = estado;

            Cadastros.Add(this);
        }

        public void ExibirCadastro()
        {
            foreach (var c in Cadastros)
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

