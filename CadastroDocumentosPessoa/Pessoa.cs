using System;
using System.Collections.Generic;
using System.Text;

namespace CadastroDocumentosPessoa
{

    //Criação da classe Pessoa com seus atributos Nome e DataNascimento
    // e acessores get e set
    // e  propriedade  lista de Documentos " List<IDocumento>"
    public class Pessoa
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }

        public List<IDocumento> Documentos { get; set; }


        // Criação do Construtor Pessoa 
        // E  Inicialização dos atributos da classe Pessoa

        public Pessoa(string nome, DateTime dataNascimento )
        {
            Nome = nome;
            DataNascimento = dataNascimento;

            // Criação da LIsta(vazia) Documentos
            Documentos = new List<IDocumento>();

        }

        // Criação e implementação do método AdicionarDocumento
        // que adiciona documento a lista Documentos

        public void AdicionarDocumento(IDocumento documento)
        {
            Documentos.Add(documento);

        }



    }



}
