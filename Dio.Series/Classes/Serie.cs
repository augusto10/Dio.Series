using Dio.Series.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dio.Series.Classes
{
    class Serie : entidadeBase
    {
        public Genero Genero { get; set; }

        public string Titulo { get; set; }

        public string Descricao { get; set; }

        public int Ano { get; set; }

        private bool Excluido { get; set; }

        public Serie( int id, Genero genero, string titulo, string descricao, int ano)
        {
            this.id=id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
            this.Excluido= false;
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Genero:  " + this.Genero + Environment.NewLine;
            retorno += "Titulo:  " + this.Titulo + Environment.NewLine;
            retorno += "Descrição:  " + this.Descricao + Environment.NewLine;
            retorno += "Ano de inicio:  " + this.Ano + Environment.NewLine; 
            retorno += "excluido:  " + this.Excluido + Environment.NewLine;
            return retorno;
        }

        public string retornaTittulo()
        {
            return this.Titulo;
        }

        public int retornaId()
        {
            return this.id;
                
        }


        public bool retornaexcluido()
        {
            return this.Excluido;

        }

        public void exclui()
        {
            this.Excluido = true;

        }
    }
}
