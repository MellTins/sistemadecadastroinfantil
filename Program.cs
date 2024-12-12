/*
 Sistema de cadastro de pessoas
nome/ sobrenome
data de nasc /idade
nome do pai e mae caso houver
rg
cidade onde nasceu/estado

cadastrar uma criança
selecionar criancas cadastradas
exibir as crianças de forma paginada 10/10
editar cadastro das criancas
gerar relatório em excel

considerar as responsabilidades das classes
*/
using SCC.cadastro;
using SCC.Entidades;
var crianca = new Crianca();
var editarcad = new EditarCad();
var sair = false;
Console.WriteLine("Olá, bem vindo ao sistema de Cadastro");
Console.WriteLine("a seguir, suas opções: ");
Console.WriteLine("\ta - Cadastrar ");
Console.WriteLine("\tb - Editar um cadastro");
Console.WriteLine("\tc - Exibir crianças cadastradas");
Console.WriteLine("\td - Gerar relatorio em excel");
Console.WriteLine("\te - Sair");
do
{

    var opcoes = Console.ReadLine();

    switch (opcoes)
    {
        case "a":
            Cadastramento();
            Voltar();
            break;
        case "b":
            Console.WriteLine("Edição de Cadastro da Criança");
            Console.WriteLine("Digite o rg da Criança Cadastrada");
            var RG = Console.ReadLine();
            var editarcri = editarcad.LogarCad(RG);
            Console.WriteLine(editarcri);
            EditarCadastro(RG);
            var criancaEditado = editarcad.LogarCad(RG);
            Console.WriteLine(criancaEditado);
            break;
        case "c":
            crianca.ExibirCadastro();
            Voltar();
            break;
        case "d":

            break;
        case "e":
            sair = true;
            break;
        default:
            Console.WriteLine("Opção inválida, tente novamente");
            break;
    }

} while (!sair);



void Cadastramento()
{

    Console.WriteLine("Digite o 1º nome da criança: ");
    var nome = Console.ReadLine();
    Console.WriteLine("Digite o sobrenome: ");
    var sobrenome = Console.ReadLine();
    Console.WriteLine("Data de nascimento");
    var dataNasc = Convert.ToDateTime(Console.ReadLine());

    
    Console.WriteLine("Nome completo do pai (caso houver):");
    var nomePai = Console.ReadLine();
    Console.WriteLine("nome completo da mãe (caso houver):");
    var nomeMae = Console.ReadLine();
    if (nomePai == string.Empty || nomeMae == string.Empty)
    {
        Console.WriteLine("Sem pai ou mãe no registro");
    }

    Console.WriteLine("Digite o rg da criança:");
    var RG = Console.ReadLine();
    do
    {
        if (RG.Length > 10 || RG.Length < 10)
        {
            Console.WriteLine("Documento inválido, tente novamente:");
            RG = Console.ReadLine();
        }
    } while (RG.Length > 10|| RG.Length < 10);
    
    Console.WriteLine("Cidade onde nasceu");
    var cidade = Console.ReadLine();
    Console.WriteLine("Estado onde nasceu");
    var estado = Console.ReadLine();
    crianca.Adicionar(nome,sobrenome,dataNasc, nomePai, nomeMae, RG, cidade, estado);
    Console.WriteLine("Cadastro concluído!");
}

void EditarCadastro(string RG)
{
    
    do
    {
        if (RG.Length > 10 || RG.Length < 10)
        {
            Console.WriteLine("Documento inválido, tente novamente:");
            RG = Console.ReadLine();
        }
    } while (RG.Length > 10|| RG.Length < 10);
 
    Console.WriteLine("Digite o 1º nome da criança: ");
    var nome = Console.ReadLine();
    Console.WriteLine("Digite o sobrenome: ");
    var sobrenome = Console.ReadLine();
    Console.WriteLine("Data de nascimento");
    var dataNasc = Convert.ToDateTime(Console.ReadLine());


    Console.WriteLine("Nome completo do pai (caso houver):");
    var nomePai = Console.ReadLine();
    Console.WriteLine("nome completo da mãe (caso houver):");
    var nomeMae = Console.ReadLine();
    if (nomePai == string.Empty || nomeMae == string.Empty)
    {
        Console.WriteLine("Sem pai ou mãe no registro");
    }

  
    Console.WriteLine("Cidade onde nasceu");
    var cidade = Console.ReadLine();
    Console.WriteLine("Estado onde nasceu");
    var estado = Console.ReadLine();
    crianca.Adicionar(nome, sobrenome, dataNasc, nomePai, nomeMae, RG, cidade, estado);
    Console.WriteLine("Cadastro concluído!");
}
    void Voltar()
{
    Console.WriteLine("\ta - Cadastrar ");
    Console.WriteLine("\tb - Editar um cadastro");
    Console.WriteLine("\tc - Exibir crianças cadastradas");
    Console.WriteLine("\td - Gerar relatorio em excel");
    Console.WriteLine("\te - Sair");
};