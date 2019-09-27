using System;
using System.Drawing;
using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Fields;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Criação do documento

            Document Atividade_Obj = new Document();

            #endregion

            #region Criação da Seção no Documento
            
            Section SecaoCapa = AtividadeObj.AddSestion();

            #endregion

            #region Criação de um paragrafo 

            Paragraph titulo = SecaoCapa.AddParagraph();            )



        }
    }
}
