using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BiblioTecca.Model;

namespace BiblioTecca.DAL
{
    class LocacaoDAO
    {
        private static Context ctx = Singleton.Instance.Context;

        public static bool AdicionarLocacao(Locacao l)
        {
            ctx.Locacoes.Add(l);
            ctx.SaveChanges();
            return true;
        }

        public static Locacao VerificarLocacaoPorNomePessoa(Locacao l)
        {
            return ctx.Locacoes.FirstOrDefault(
                x => x.LocacaoPessoa.PessoaNome.Equals(l.LocacaoPessoa.PessoaNome));
        }

        public static Locacao VerificarLocacaoPorNomeLivro(Locacao l)
        {
            return ctx.Locacoes.FirstOrDefault(
                x => x.LocacaoLivro.LivroNome.Equals(l.LocacaoLivro.LivroNome));
        }

        public static List<Locacao> RetornarListaDeLocacoes(Locacao l)
        {
            return ctx.Locacoes.ToList();
        }

    }
}
