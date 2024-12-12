using SCC.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCC.cadastro
{
    public class EditarCad
    {
        public List<Crianca> Cadastros { get; set; } = new List<Crianca>();

        public string LogarCad(string rg)
        {
            var cadastrocri = Cadastros.Where(item => item.RG == rg).FirstOrDefault();

            return $"Primeiro nome:{cadastrocri.Nome} | Sobrenome: {cadastrocri.Sobrenome} |Data de Nascimento: {cadastrocri.DataNasc}| Nome do Pai:{cadastrocri.NomePai} | Nome da Mãe:{cadastrocri.NomeMae} | Rg da criança:{cadastrocri.RG} | Cidade em que nasceu: {cadastrocri.Cidade} | Estado em que nasceu:{cadastrocri.Estado}";
        }

        public void EditarCadastro(string nome, string sobrenome, DateTime datanasc, string nomepai, string nomemae, string rg, string cidade, string estado)
        {
            var cadastrocri = Cadastros.Where(item => item.RG == rg).FirstOrDefault();
            Cadastros.Remove(cadastrocri);
            cadastrocri.Nome = nome;
            cadastrocri.Sobrenome = sobrenome;
            cadastrocri.DataNasc = datanasc;
            cadastrocri.NomePai = nomepai;
            cadastrocri.NomeMae = nomemae;
            cadastrocri.Cidade = cidade;
            cadastrocri.Estado = estado;
            Cadastros.Add(cadastrocri);
        }
    }
    }

