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
        private Livro l = new Livro();

        public frm_Alugar_Devolver()
        {
            InitializeComponent();
        }

         private void btn_frmEmprestimo_Buscar_Click(object sender, RoutedEventArgs e)
        {
            l = new Livro();
            if (!string.IsNullOrEmpty(txt_Titulo_buscar.Text))
            {
                l.LivroNome = txt_Titulo_buscar.Text;
                l = LivroDAO.VerificarLivroPorNome(l);
                if (l != null)
                {
                    txt_Titulo.Text = l.LivroNome;
                    txt_Coletanea.Text = l.LivroColetanea;
                    txt_Classificacao.Text = l.LivroClassificacao;
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
    }
}
