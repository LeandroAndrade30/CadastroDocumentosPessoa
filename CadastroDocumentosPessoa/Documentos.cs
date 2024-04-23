using System;
using System.Collections.Generic;
using System.Text;

namespace CadastroDocumentosPessoa
{
    // Criação da classe abstrata Documento
    // que herda ou implementa a interface IDocumento
    public abstract class Documento : IDocumento
    {
        // Atributos herdados da interface Idocumentos
        // utlizando acessores get e set 
        // onde protected indica que o atributo set
        // pode ser acessado ou modificado apenas 
        // dentro da classe que foi criado no caso Documento 
        // ou em classes derivadas no caso claase abstract class Documento
        // utilizando encapsulamento
        public abstract string Tipo { get; protected set; }
        public DateTime DataEmissao { get; set; }

        // Criação do Construtor documento que recebe como parâmetro
        // DataEmissão e inicializa esse atributo

        public Documento(DateTime dataEmissao)
        {
            DataEmissao = dataEmissao;         //inicializado o atributo
                                               //  dataEmissão
        }

        // declarção do método abstrato ExibirDetalhes

        public abstract void ExibirDetalhes();




    }

    // Criação da classe RG que  herda da classe Documento
    // os seus atributos e métodos

    public class RG : Documento
    {
        // atributo Tipo que é herdado da classe Documento 
        // está sendo sobescrito na classe RG através 
        // do método override e o acessor set está sendo setado
        // como RG para que possa ter seu tipo modificado para RG
        public override string Tipo { get; protected set; } = "RG";

        // declarado o atributo Numero da classe RG

        public string Numero { get; set; }


        // Criado o construtor da classe RG e realizada a sobreCarga do construtor RG
        // que utiliza o atributo dataEmissão da classe base Documento


        public RG(string numero, DateTime dataEmissao) : base(dataEmissao)
        {
            Numero = numero; // inicializado a atributo Número
        }

        // Implementado o método  ExibirDetalhes
        // subescrevendo o método ExibirDetalhes
        // através do método override
        // O que altera o comportamento do método
        // caracterizando Poliformismo

        public override void ExibirDetalhes()
        {
            Console.WriteLine($"Número: {Numero}");
            Console.WriteLine($"Data de Emissão: {DataEmissao.ToShortDateString()}");
        }



    }



    // Criada a Classe CNH que herda da classe Documento
    // os atributos Tipo e Numero onde o Tipo é setado como "CNH"
    // tendo assim seu valor modificado para "CNH"



    public class CNH : Documento
    {
        public override string Tipo { get; protected set; } = "CNH";
        public string Numero { get; set; }



        //Criado o construtor CNH da classe CNH
        //e realizada a sobreCarga do construtor CNH
        // que utiliza o atributo dataEmissao da classe base Documento


        public CNH(string numero, DateTime dataEmissao) : base(dataEmissao)
        {
            Numero = numero;
        }


        // Implementado o método  ExibirDetalhes
        // subescrevendo o método ExibirDetalhes
        // através do método override
        // O que altera o comportamento do método
        // caracterizando Poliformismo




        public override void ExibirDetalhes()
        {
            Console.WriteLine($"Número: {Numero}");
            Console.WriteLine($"Data de Emissão: {DataEmissao.ToShortDateString()}");
        }


        // Criada a Classe CTPS que herda da classe documento
        // os atributos Tipo e Numero onde o Tipo é setado como "CTPS"
        // tendo assim seu valor modificado para "CTPS"

        public class CTPS : Documento
        {
            public override string Tipo { get; protected set; } = "CTPS";
            public string Numero { get; set; }


            //Criado o construtor CTPS da classe CTPS
            //e realizada a sobreCarga do construtor CTPS
            // que utiliza o atributo dataEmissão da classe base Documento
            public CTPS(string numero, DateTime dataEmissao) : base(dataEmissao)
            {
                Numero = numero; // inicializando o atributo Numero
            }


            // Implementado o método  ExibirDetalhes
            // subescrevendo o método ExibirDetalhes
            // através do método override
            // O que altera o comportamento do método
            // caracterizando Poliformismo
            public override void ExibirDetalhes()
            {
                Console.WriteLine($"Número: {Numero}");
                Console.WriteLine($"Data de Emissão: {DataEmissao.ToShortDateString()}");
            }
        }


        // Criada a Classe INSS que herda da classe documento
        // os atributos Tipo e Numero onde o Tipo é setado como "INSS"
        // tendo assim seu valor modificado para "INSS"

        public class INSS : Documento
        {
            public override string Tipo { get; protected set; } = "INSS";
            public string Numero { get; set; }



            //Criado o construtor INSS da classe INSS
            //e realizada a sobreCarga do construtor INSS
            // que utiliza o atributo dataEmissão da classe base Documento
            public INSS(string numero, DateTime dataEmissao) : base(dataEmissao)
            {
                Numero = numero;   // inicializado o atributo Numero
            }




            // Implementado o método  ExibirDetalhes
            // subescrevendo o método ExibirDetalhes
            // através do método override
            // O que altera o comportamento do método
            // caracterizando Poliformismo
            public override void ExibirDetalhes()
            {
                Console.WriteLine($"Número: {Numero}");
                Console.WriteLine($"Data de Emissão: {DataEmissao.ToShortDateString()}");
            }
        }



        // Criada a Classe Escola que herda da classe documento
        // os atributos Tipo e Numero onde o Tipo é setado como "Escola"
        // tendo assim seu valor modificado para "Escola"
        public class Escola : Documento
        {
            public override string Tipo { get; protected set; } = "Escola";
            public string NomeDaEscola { get; set; }



            //Criado o construtor EScola da classe EScola
            //e realizada a sobreCarga do construtor Escola
            // que utiliza o atributo dataEmissão da classe base Documento

            public Escola(string nomeDaEscola, DateTime dataEmissao) : base(dataEmissao)
            {
                NomeDaEscola = nomeDaEscola;  // inicializado o atributo
                                              // NomeDaEscola 
            }




            // Implementado o método  ExibirDetalhes
            // subescrevendo o método ExibirDetalhes
            // através do método override
            // O que altera o comportamento do método
            // caracterizando Poliformismo
            public override void ExibirDetalhes()
            {
                Console.WriteLine($"Nome da Escola: {NomeDaEscola}");
                Console.WriteLine($"Data de Conclusão: {DataEmissao.ToShortDateString()}");
            }
        }



        // Criada a Classe Obito que herda da classe documento
        // os atributos Tipo e Numero onde o Tipo é setado como "Obito"
        // tendo assim seu valor modificado para "Obito"

        public class Obito : Documento
        {
            public override string Tipo { get; protected set; } = "Óbito";
            public DateTime DataObito { get; set; }


            //Criado o construtor Obito da classe OBito
            //e realizada a sobreCarga do construtor Obito
            // que utiliza o atributo dataEmissão da classe base Documento


            public Obito(DateTime dataObito) : base(dataObito)
            {
                DataObito = dataObito;
            }


            // Implementado o método  ExibirDetalhes
            // subescrevendo o método ExibirDetalhes
            // através do método override
            // O que altera o comportamento do método
            // caracterizando Poliformismo
            public override void ExibirDetalhes()
            {
                Console.WriteLine($"Data de Óbito: {DataObito.ToShortDateString()}");
            }


        }
    }
}


