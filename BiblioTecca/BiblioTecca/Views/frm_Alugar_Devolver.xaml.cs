using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using BiblioTecca.DAL;
using BiblioTecca.Model;

namespace BiblioTecca.Views
{
    /// <summary>
    /// Interaction logic for frm_Alugar_Devolver.xaml
    /// </summary>
    public partial class frm_Alugar_Devolver : Window
    {
        private Livro livro = new Livro();
        private Locacao locacao = new Locacao();
        private Pessoa pessoa = new Pessoa();

        public frm_Alugar_Devolver()
        {
            InitializeComponent();
        }

         private void btn_frmEmprestimo_Buscar_Click(object sender, RoutedEventArgs e)
        {
            locacao = new Locacao();

            
            if (!string.IsNullOrEmpty(txt_IdLocacao_Buscar.Text))
            {
                locacao.IdLocacao = Convert.ToInt16(txt_IdLocacao_Buscar.Text);

                locacao = LocacaoDAO.VerificarLocacaoPorIdLocacao(locacao);

                if (locacao != null)
                {
                    txt_NomeLivro_Devolucao.Text = locacao.LocacaoLivro.LivroNome;
                    txt_CodLivro_Devolucao.Text = Convert.ToString(locacao.LocacaoLivro.IdLivro);

                    txt_NomePessoa_Devolucao.Text = locacao.LocacaoPessoa.PessoaNome;
                    txt_CpfPessoa_Devolucao.Text = locacao.LocacaoPessoa.PessoaCpf;

                    txt_Data_Devolucao.Text = Convert.ToString(locacao.LocacaoData);

                    if (locacao.LocacaoStatus == true)
                    {
                        txt_Situacao.Text = "Alugado";
                    }
                    else
                    {
                        txt_Situacao.Text = "Devolvido";
                    }
                }
                else
                {
                    MessageBox.Show("Livro não encontrado!", "Cadastro de Livro",
                    MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            else
            {
                MessageBox.Show("Favor preencher o campo da busca", "Cadastro de Livro",
                MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void ComboBoxItem_Selected(object sender, RoutedEventArgs e)
        {

        }
    }
}
