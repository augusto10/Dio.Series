using Dio.Series.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dio.Series.Classes
{
    class SerieRepositorio : IRepositorio<Serie>
    {
        private List<Serie> listaSerie = new List<Serie>();
        public void atualizar(int id, Serie entidade)
        {
            listaSerie[id] = entidade;
        }

        public void excluir(int id)
        {
            listaSerie[id].exclui();
        }

        public void insere(Serie entidade)
        {
            listaSerie.Add(entidade);

        }

        public List<Serie> Lista()
        {
            return listaSerie;
        }

        public int proximoId()
        {
          return  listaSerie.Count;
        }

        public Serie retornaporId(int id)
        {
            return listaSerie[id];
        }
    }
}
