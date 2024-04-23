using System;
using System.Collections.Generic;
using System.Text;

namespace CadastroDocumentosPessoa
{
    // Criação da Interface Idocumentos
    public interface IDocumento
    {
        string Tipo { get; }  // declaração dos atributos
        DateTime DataEmissao { get; }

        // declarção do método ExibirDetalhes
        void ExibirDetalhes();
        
        

    }
}
