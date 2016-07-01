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

namespace BiblioTecca.Views
{
    /// <summary>
    /// Interaction logic for frmManterPessoa.xaml
    /// </summary>
    public partial class frm_ManterPessoa : Window
    {
        public frm_ManterPessoa()
        {
            InitializeComponent();
        }

        private void btn_Buscar_Cpf_Click(object sender, RoutedEventArgs e)
        {
            if (txt_Cpf.Text == null)
            {

            }
        }
    }
}
