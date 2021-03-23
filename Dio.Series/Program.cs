using Dio.Series.Classes;
using Dio.Series.Enum;
using System;

namespace Dio.Series
{
    class Program
    {
        static SerieRepositorio repositorio = new SerieRepositorio();

        static void Main(string[] args)
        {
            string opcaoUsuario = obterUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {

                    case "1":
                        ListarSerie();
                        break;

                    case "2":
                        InserirSeries();
                        break;
                    case "3":
                        AtualizarSerie();
                        break;
                    case "4":
                        ExcluirSerie();
                        break;
                    case "5":
                        VisualizarSerie();
                        break;
                    case "C":
                        Console.Clear();
                        break;




                }

                Console.WriteLine();
                Console.WriteLine(" obrigado por usar nossos servicos ");
                Console.WriteLine();

                Console.WriteLine("Volte Sempre");
                Console.WriteLine();

                opcaoUsuario = obterUsuario();
            }

        }

        private static void VisualizarSerie()
        {
            Console.WriteLine("Digite o id da series:  ");
            int indiceSerie = int.Parse(Console.ReadLine());

          var serie =  repositorio.retornaporId(indiceSerie);

            Console.WriteLine(serie);
        }

        private static void ExcluirSerie()
        {
            Console.WriteLine("Digite o id da series:  ");
            int indiceSerie = int.Parse(Console.ReadLine());

            repositorio.excluir(indiceSerie);
        }

        private static void AtualizarSerie()
        {
            {
                Console.WriteLine("Digite o id da series:  ");
                int indiceSerie = int.Parse(Console.ReadLine());

                foreach (int i in Genero.GetValues(typeof(Genero)))
                {
                    Console.WriteLine("{0} - {1}", i, Genero.GetName(typeof(Genero), i));


                }
                Console.WriteLine("digite o genero das opcoes acima");
                int entradaGenero = int.Parse(Console.ReadLine());

                Console.WriteLine("insira o titulo da serie");
                string entradaTitulo = Console.ReadLine();

                Console.WriteLine("insira o ano de inicio");
                int entradaAno = int.Parse(Console.ReadLine());

                Console.WriteLine("insira a descricao");
                string entradaDescricao = Console.ReadLine();

                Serie atualizarSerie = new Serie(id: indiceSerie,
                     genero: (Genero)entradaGenero,
                     titulo: entradaTitulo,
                     ano: entradaAno,
                     descricao: entradaDescricao);


                repositorio.atualizar(indiceSerie , atualizarSerie);
            }

        }

        private static void InserirSeries()
        {
            Console.WriteLine("Inserir series:  ");

            foreach (int i in Genero.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0} - {1}", i, Genero.GetName(typeof(Genero), i));
                    
                    
            }
            Console.WriteLine("digite o genero das opcoes acima");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.WriteLine("insira o titulo da serie");
            string entradaTitulo = Console.ReadLine();

            Console.WriteLine("insira o ano de inicio");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.WriteLine("insira a descricao");
            string entradaDescricao = Console.ReadLine();

            Serie novaSerie = new Serie(id: repositorio.proximoId(),
                 genero: (Genero)entradaGenero,
                 titulo: entradaTitulo,
                 ano: entradaAno,
                 descricao: entradaDescricao);


            repositorio.insere(novaSerie);
        }
        
           


        private static void ListarSerie()
        {
            Console.WriteLine(" listar series: ");

            var lista = repositorio.Lista();

            if (lista.Count == 0)
            {
                Console.WriteLine(" nenhuma serie cadastrada ");
                return;
            }
            foreach (var serie in lista)
            {
                var excluido = serie.retornaexcluido();

                Console.WriteLine("#ID serie: {0} - {1} - {2}", serie.retornaId(), serie.retornaTittulo(), excluido ? " **Excluido  " : " *Ativo");

                Console.WriteLine();
            }
        }







        private static string obterUsuario()

        {
            Console.WriteLine();
            Console.WriteLine("Bem vindo Dio Series");
            Console.WriteLine("Escolha a opcao desejada");

            Console.WriteLine("1- listar series");
            Console.WriteLine("2- inserir series");
            Console.WriteLine("3- atualizar series");
            Console.WriteLine("4- excluir serie");
            Console.WriteLine("5- visualizar serie");
            Console.WriteLine("C- limpar tela");
            Console.WriteLine("x- sair");

            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
        }



    }
}

