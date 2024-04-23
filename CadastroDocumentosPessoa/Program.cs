using System;

namespace CadastroDocumentosPessoa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe seu nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Informe sua data de Nascimento: ");
            DateTime dataNascimento = DateTime.Parse( Console.ReadLine());

            // Criação do objeto Pessoa
            // passando os parâmetros nome e data Nascimento
            // fornecidos pelo usuário

            Pessoa pessoa = new Pessoa(nome, dataNascimento);

            Console.WriteLine("Informe seu RG:");
            string numeroRG = Console.ReadLine();
            Console.WriteLine("Informe a data de emissão do RG (DD/MM/AAAA): ");
            DateTime dataEmissao;

            // faz a verificação se a dataEmissao do rg fornecida pelo usuário
            // é uma data válida no formato (DD/MM/AAAA)

            if (!DateTime.TryParse(Console.ReadLine(), out dataEmissao))
            {
                Console.WriteLine("Data de emissão do RG inválida. Informe uma data válida.");
                return;
            }

            // criado o objeto rg 
            // passando os parâmetros numeroRG e dataEmissao
            // fornecidos pelo usuário

            RG rg = new RG(numeroRG, dataEmissao);

            Console.WriteLine("Informe sua CNH:");
            string numeroCNH = Console.ReadLine();
            Console.WriteLine("Informe a data de emissão da CNH (DD/MM/AAAA): ");
            DateTime dataEmissaoCNH;

            // faz a verificação se a dataEmissao da cnh
            // fornecida pelo usuário  é uma data válida
            // no formato (DD/MM/AAAA)

            if (!DateTime.TryParse(Console.ReadLine(), out dataEmissaoCNH))
            {
                Console.WriteLine("Data de emissão da CNH inválida. Informe uma data válida.");
                return;
            }


            // criado o objeto cnh
            // passando os parâmetros numeroCNH e dataEmissaoCNH
            // fornecidos pelo usuário



            CNH cnh = new CNH(numeroCNH, dataEmissaoCNH);

            // Cria um objeto pessoa
            // chamamando to método  AdicionarDocumento
            // que adiciona rg e cnh ao objeto pessoa.

            pessoa.AdicionarDocumento(rg);
            pessoa.AdicionarDocumento(cnh);


            // imprime o nome da pessoa e a sua data de nascimento

            Console.WriteLine($"Nome: {pessoa.Nome}");
            Console.WriteLine($"Data de Nascimento: {pessoa.DataNascimento.ToShortDateString()}");
            Console.WriteLine("Documentos:");


            // Foreach que percorre todos os documentos
            // da pessoa onde cada documento é representado
            // pela var documento e
            // imprime na tela o tipo do documento e a data de emissão 


            foreach (var documento in pessoa.Documentos)
            {
                Console.WriteLine($"Tipo: {documento.Tipo}, Data de Emissão: {documento.DataEmissao.ToShortDateString()}");

                // Chamada do método ExibirDetalhes
                // que exibi todas as informações 
                // fornecidas pelo usuário

                documento.ExibirDetalhes();
            }

            Console.ReadKey();
        }
    }



}
    