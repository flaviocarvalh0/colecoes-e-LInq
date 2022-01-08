using System;
using System.Collections.Generic;
using Colecoes.Helper;

namespace Colecoes
{
    class Program
    {
        static void Main(string[] args)
        {

            Stack<string> pilha = new Stack<string>();

            pilha.Push(".NET");
            pilha.Push("DDD");
            pilha.Push("Código Limpo");

            System.Console.WriteLine($"Livros para a leitura: {pilha.Count}");
            while (pilha.Count > 0)
            {
                System.Console.WriteLine($"Próximo livro para a leitura: {pilha.Peek()}");
                System.Console.WriteLine($"{pilha.Pop()}, livro terminado, tirando da lista. ");
            }
            System.Console.WriteLine($"Livros para a leitura: {pilha.Count}");


            //Fila
            // Queue<string> fila = new Queue<string>();

            // fila.Enqueue("Flávio");
            // fila.Enqueue("Ray");
            // fila.Enqueue("Noah");

            // System.Console.WriteLine($"Pessoas na fila: {fila.Count}");

            // while (fila.Count > 0)
            // {
            //     System.Console.WriteLine($"Vez de: {fila.Peek()}");
            //     System.Console.WriteLine($"{fila.Dequeue()} atendido");
            // }

            // System.Console.WriteLine($"Pessoas na fila: {fila.Count}");










































            //Tipos genericos
            // OperacoesLista op = new OperacoesLista();
            // List<string> lista = new List<string>();
            // string[] listaArray = new string[2] { "SC", "BH" };
            // lista.Add("SP");
            // lista.Add("PE");
            // lista.Add("BA");

            // System.Console.WriteLine($"Lista de elementos: {lista.Count}");
            // op.ImprimirListaString(lista);

            // System.Console.Write("Informe qual elemento deseja remover: ");
            // string valor = Console.ReadLine();
            // lista.Remove(valor);
            // System.Console.WriteLine($"{valor} removido!");

            // op.ImprimirListaString(lista);

            // System.Console.WriteLine("Lista atual: ");

            // lista.AddRange(listaArray);
            // System.Console.WriteLine("Lista depois do merge:");
            // op.ImprimirListaString(lista);

            // System.Console.WriteLine("LIsta depois de adicionar: ");
            // lista.Insert(1,"Rj");
            // op.ImprimirListaString(lista);





























            //Arrays
            // OperacoesArray op = new OperacoesArray();
            // int[] array = new int[5] { 6, 3, 8, 1, 9 };
            // int[] arrayCopia = new int[10];
            // string[] arrayString = op.ConverterArrayString(array);



            // System.Console.WriteLine($"Capacidade atual do array: {array.Length}");

            // System.Console.Write("informe um novo tamnho para o array: ");
            // int valor = int.Parse(Console.ReadLine());
            // op.RedimensionarArray(ref array, valor);

            // System.Console.Write($"Array redimensionado: {array.Length}");






            // System.Console.Write("Informe o valor que deseja buscar: ");
            // int valor = int.Parse(Console.ReadLine());

            // int index = op.ObterIndex(array, valor); 

            // if(index > -1)
            // {
            //     System.Console.WriteLine($"O indice do elemento {valor} é: {index}");
            // }
            // else
            // {
            //     System.Console.WriteLine("Valor não existe no array!");
            // }


            // System.Console.Write("Informe o valor que deseja encontrar: ");
            // int valor = int.Parse(Console.ReadLine());

            // int valorAchado = op.ObterValor(array, valor);
            // if(valorAchado > 0)
            // {
            //     System.Console.WriteLine($"Encontrei o valor {valor}");
            // }
            // else
            // {
            //     System.Console.WriteLine("Não Encontrei o valor");
            // }

            // System.Console.Write("Informe um valor a ser comparado: ");
            // int valor = int.Parse(Console.ReadLine());

            // bool maior = op.Maior(array, valor);

            // if (maior)
            // {
            //     System.Console.WriteLine($"Todos os valores são maior que {valor}");
            // }
            // else
            // {
            //     System.Console.WriteLine($"Existem elementos que não são maiores que {valor}");
            // }




            // System.Console.Write("Informe o valor q deseja buscar: ");
            // int valor = int.Parse(Console.ReadLine());
            // bool existe = op.Existe(array, valor);

            // if(existe)
            // {
            //     System.Console.WriteLine($"Encontrei o valor {valor}");
            // }
            // else{
            //     System.Console.WriteLine($"{valor} Não encontrado!");
            // }

            // System.Console.WriteLine("Array sem ordenar:");
            // op.ImprimirArray(array);
            // System.Console.WriteLine("Array ordenado:");

            //op.OrdenarBubbleSort(ref array);
            //op.Ordenar(ref array);

            // System.Console.WriteLine("array antes da copia: ");
            // op.ImprimirArray(arrayCopia);

            // op.Copiar(ref array,ref arrayCopia);

            // System.Console.WriteLine("Array apos a copia: ");
            // op.ImprimirArray(arrayCopia);


            //op.ImprimirArray(array);







            // int[,] matriz = new int[4,2]
            // {
            //     {8,8},
            //     {2,1},
            //     {5,4},
            //     {8,1},
            // };

            // for(int i = 0; i < matriz.GetLength(0); i++)
            // {
            //     for (int z = 0; z < matriz.GetLength(1); z++)
            //     {
            //         System.Console.WriteLine(matriz[i,z]);
            //     }
            // }

            // int[] arrayInterios = new int[3];

            // System.Console.WriteLine("Informe os valores: ");
            // int n1 = int.Parse(Console.ReadLine());
            // System.Console.WriteLine("Informe os valores: ");
            // int n2 = int.Parse(Console.ReadLine());
            // System.Console.WriteLine("Informe os valores: ");
            // int n3 = int.Parse(Console.ReadLine());
            // arrayInterios[0]= n1;
            // arrayInterios[1]= n2;
            // arrayInterios[2]= n3;

            // System.Console.WriteLine("Array percorrido com for");
            // for( int i  = 0; i < arrayInterios.Length; i++)
            // {
            //     System.Console.WriteLine(arrayInterios[i]);

            // }

            // System.Console.WriteLine("Array Percorrido com foreach");
            // foreach(int item in arrayInterios)
            // {
            //     System.Console.WriteLine(item);
            // }

        }
    }
}
