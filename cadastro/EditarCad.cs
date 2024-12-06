using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCC.cadastro
{
    public class EditarCad
    {
        public List<Cadastro> Cadastros { get; set; } = new List<Cadastro>();

        public string LogarCad(string rg)
        {
            var crianca = Cadastros.Where(item => item.RG == rg).FirstOrDefault();

            return $"Primeiro nome:{crianca.Nome} | Sobrenome: {crianca.Sobrenome} |Data de Nascimento: {crianca.DataNasc}| Nome do Pai:{crianca.NomePai} | Nome da Mãe:{crianca.NomeMae} | Rg da criança:{crianca.RG} | Cidade em que nasceu: {crianca.Cidade} | Estado em que nasceu:{crianca.Estado}";
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

