using ServicoCadastroSerie.Nucleo.Entidade;
using ServicoCadastroSerie.Nucleo.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicoCadastroSerie.Nucleo.Repositorio
{
    public class SerieRepositorio : IRepositorioGenerico<Serie>
    {
        private List<Serie> listaSerie = new List<Serie>();
        public void Atualiza(int id, Serie objeto)
        {
            listaSerie[id] = objeto;
        }

        public void Exclui(int id)
        {
            listaSerie[id].Excluir();
        }

        public void Insere(Serie objeto)
        {
            listaSerie.Add(objeto);
        }

        public List<Serie> Lista()
        {
            return listaSerie;
        }

        public int ProximoId()
        {
            return listaSerie.Count;
        }

        public Serie RetornaPorId(int id)
        {
            return listaSerie[id];
        }
    }
}
