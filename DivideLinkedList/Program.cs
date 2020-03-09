using System;
using Ejercicio2;

namespace DivideLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            ListaCircular lc = new ListaCircular();
            Console.Write("Digite la cantidad de elementos de la lista: ");
            int cantidad = int.Parse(Console.ReadLine());
            int item;
            for (int i = 0; i < cantidad; i++)
            {
                Console.Write($"ITEM #{i + 1}: ");
                item = int.Parse(Console.ReadLine());
                lc.InsertarPrimero(item);
            }

            lc.Imprimir();
            cantidad = lc.Cantidad();
            int num = cantidad / 2;
            if (cantidad % 2 != 0)
            {
                num++;
            }
            ListaCircular l1 = lc.ListTo(num);
            ListaCircular l2 = lc.laux;
            l1.Imprimir();
            l2.Imprimir();

        }
    }
}
