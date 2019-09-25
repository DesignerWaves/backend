using System;
using System.Drawing;
using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Fields;

namespace Exemplo {
    class Program {
        static void Main (string[] args) {
            #region Criacao do documento

            //Cria um documento doc com o nome exemploDoc
            Document exemploDOc = new Document ();

            #endregion 

            #region  Criacao da secao no documento
            //Adiciona uma secao com o nome secao capa ao documento
            // Cada secao pode ser entendida como uma pagina do documento
            Section secaoCapa = exemploDOc.AddSection ();
            #endregion 

            #region Criar um paragrafo
            //Cria um paragrafo com o nome titulo e adiciona a secao secaoCapa
            //Os paragrafos sao necessarios para a insercao de textos, imagens, tabelas e etc
            Paragraph titulo = secaoCapa.AddParagraph ();
            #endregion

            #region adiciona texto ao paragrafo 

            //adiciona o texto exemplo de titulo ao paragrafo titulo
            titulo.AppendText ("Exemplo de Titulo\n\n");

            #endregion 

            #region Formatar paragrafo 

            // Atraves da proprieda Horizontal e é possivel alinhas o paragrafo 
            titulo.Format.HorizontalAlignment = HorizontalAlignment.Center;

            ParagraphStyle estilo01 = new ParagraphStyle (exemploDOc);

            // adiciona um nome ao estilo 01
            estilo01.Name = "Cor do titulo";

            //definir a cor do texto
            estilo01.CharacterFormat.TextColor = Color.DarkCyan;

            //define que o texto será em negrito
            estilo01.CharacterFormat.Bold = true;
            //adiciona estilo01 ao docuemnto exempodoc
            exemploDOc.Styles.Add (estilo01);
            //aplica o estilo01 ao paragrafo titulo
            titulo.ApplyStyle (estilo01.Name);

            #endregion

            #region trabalhar com tabulação
            //adiciona um paragrafo  textoCapa a secao SecaoCapa
            Paragraph textoCapa = secaoCapa.AddParagraph ();
            // adiciona um texto ao paragrafo com tabulação
            textoCapa.AppendText ("\tEste é um exemplo de txto com tabulação\n");

            Paragraph textoCapa2 = secaoCapa.AddParagraph ();

            textoCapa2.AppendText ("\t Basicamente, então, uma seção representa uma pagina do documento e os paragrafos de uma seção," + "obviamente, aparecem na mesma pagina\n");

            #endregion

            #region Inserir imagens
            //adiciona um paragrafo a secao secaoCapa
            Paragraph imagemCapa = secaoCapa.AddParagraph ();
            //adiciona o texto
            imagemCapa.AppendText ("\n\n\tAgora vamos inserir uma imagem no documento\n\n");

            imagemCapa.Format.HorizontalAlignment = HorizontalAlignment.Center;
            //adiciona uma imagem ao paragrafo do do
            DocPicture imagemExemplo = imagemCapa.AppendPicture (Image.FromFile (@"saida\logo_csharp.png"));

            //Ddefine uma largura e uma altura para a imagem
            imagemExemplo.Width = 300;
            imagemExemplo.Height = 300;

            #endregion

            #region Adicionar nova secao
            // adiciona uma nova secao 
            Section secaoCorpo = exemploDOc.AddSection ();

            Paragraph paragrafoCorpo = secaoCorpo.AddParagraph ();

            paragrafoCorpo.AppendText ("\nEste é um exemplo de paragrafo criado em uma nova seção." + "\tComo foi criado uma nova secao perceba que este texto aparece em uma nova pagina.");

            #endregion 

            #region Adicionar Tabela 

            //Adiciona uma tabela a secao secaoCorpo   
            Table tabela = secaoCorpo.AddTable (true);

            //Cria o cabeçalho da tabela
            String[] cabecalho = { "item", "Descricao", "Qtd", "Preco", "Unit", "Preco" };
            string[][] dados = {
                new string[] { "Cenoura", "Vegetal muito nutritivo", "1", "R$ 4,00", "R$ 4,00" },
                new string[] { "Batata", "Vegetal muito nutritivo", "1", "R$ 5,00", "R$ 10,00" },
                new string[] { "Alface", "Vegetal muito nutritivo", "1", "R$ 1,50", "R$ 1,50" },
                new string[] { "Tomate", "Tomate é uma fruta", "1", "R$ 6,00", "R$12,00" }
            };

            //Adiona  as celulas na tabela 
            tabela.ResetCells (dados.Length + 1, cabecalho.Length);

            //Adiciona uma linha na posicao [0] do vetor de linhas
            //E define que esta linnha e o cabecalho
            TableRow Linha1 = tabela.Rows[0];
            Linha1.IsHeader = true;

            //Define a altura da linnha
            Linha1.Height = 23;

            //Formataçaõ do cabecalho
            Linha1.RowFormat.BackColor = Color.MediumPurple;

            //percorre as colunas do cabecalho
            for (int i = 0; i < cabecalho.Length; i++) {
                Paragraph p = Linha1.Cells[i].AddParagraph ();
                Linha1.Cells[i].CellFormat.VerticalAlignment = VerticalAlignment.Middle;
                p.Format.HorizontalAlignment = HorizontalAlignment.Center;

                //Formatação dos dados do cabeçalho
                TextRange TR = p.AppendText (cabecalho[i]);
                TR.CharacterFormat.FontName = "Calibri";
                TR.CharacterFormat.FontSize = 14;
                TR.CharacterFormat.TextColor = Color.Teal;
                TR.CharacterFormat.Bold = true;
            }

            //Adiciona as linhas do corpo da tabela 
            for (int r = 0; r < dados.Length; r++) {
                TableRow LinhaDados = tabela.Rows[r + 1];

                //Define a altura da linha
                LinhaDados.Height = 20;

                for (int c = 0; c < dados[r].Length; c++)
                {
                    //alinha as celulas 
                    LinhaDados.Cells[c].CellFormat.VerticalAlignment = VerticalAlignment.Middle;

                    //Preencher os dados nas linhas
                    Paragraph p2 = LinhaDados.Cells[c].AddParagraph();

                    TextRange TR2 = p2.AppendText(dados[r][c]);

                    // formatar celulas
                    p2.Format.HorizontalAlignment = HorizontalAlignment.Center;
                    TR2.CharacterFormat.FontName = "Calibri";
                    TR2.CharacterFormat.FontSize = 12; 
                    TR2.CharacterFormat.TextColor = Color.Brown;
                }
            }
            #endregion

            #region salvar arquivo

            //Salva o arquivo em .Docx
            //Utiliza o metodo SaveToFile para salvar  oarquivo no formato desejado
            //Assim como no word, caso ja exista um arquivo com este nome, é substituido
            exemploDOc.SaveToFile(@"saida\exemplo_arquivo_word.docx", FileFormat.Docx);

            #endregion


        }
    }
}