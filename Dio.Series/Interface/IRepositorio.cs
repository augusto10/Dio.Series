using System;
using System.Collections.Generic;
using System.Text;

namespace Dio.Series.Interface
{
   public interface IRepositorio<T>
    {
        List<T> Lista();

        T retornaporId(int id);
        void insere(T entidade);

        void excluir(int id);

        void atualizar(int id, T entidade);

        int proximoId();
    }
}
