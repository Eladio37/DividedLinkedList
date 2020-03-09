using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio2
{
    public class ListaCircular {
        private Nodo raiz;
        public ListaCircular laux;

        public ListaCircular()
        {
            raiz = null;
        }

        public void InsertarPrimero(int x)
        {
            Nodo nuevo = new Nodo();
            nuevo.info = x;
            if (raiz == null)
            {
                nuevo.sig = nuevo;
                nuevo.ant = nuevo;
                raiz = nuevo;
            }
            else
            {
                Nodo ultimo = raiz.ant;
                nuevo.sig = raiz;
                nuevo.ant = ultimo;
                raiz.ant = nuevo;
                ultimo.sig = nuevo;
                raiz = nuevo;
            }
        }

        public void InsertarUltimo(int x)
        {
            Nodo nuevo = new Nodo();
            nuevo.info = x;
            if (raiz == null)
            {
                nuevo.sig = nuevo;
                nuevo.ant = nuevo;
                raiz = nuevo;
            }
            else
            {
                Nodo ultimo = raiz.ant;
                nuevo.sig = raiz;
                nuevo.ant = ultimo;
                raiz.ant = nuevo;
                ultimo.sig = nuevo;
            }
        }

        public bool Vacia()
        {
            if (raiz == null)
                return true;
            else
                return false;
        }

        public void Imprimir()
        {
            if (!Vacia())
            {
                Nodo reco = raiz;
                do
                {
                    Console.Write(reco.info + "->");
                    reco = reco.sig;
                } while (reco != raiz);
                Console.WriteLine();
            }
        }

        public int Cantidad()
        {
            int cant = 0;
            if (!Vacia())
            {
                Nodo reco = raiz;
                do
                {
                    cant++;
                    reco = reco.sig;
                } while (reco != raiz);
            }
            return cant;
        }

        public ListaCircular ListTo(int value)
        {
            ListaCircular li = new ListaCircular();
            ListaCircular l2 = new ListaCircular();

            if (!Vacia())
            {
                int cont = 0;
                Nodo reco = raiz;
                do
                {

                    if (cont < value)
                    {
                        li.InsertarPrimero(reco.info);
                    }
                    else
                    {
                        l2.InsertarPrimero(reco.info);
                        //Console.WriteLine(reco.info);
                    }

                    cont++;
                    //Console.Write(reco.info + "->");
                    reco = reco.sig;

                } while (reco != raiz);

                
            }
            ListFromTo(l2);
            return li;
        }

        public void ListFromTo(ListaCircular lista)
        {
            this.laux = lista;
        }

        public void Borrar(int pos)
        {
            if (pos <= Cantidad())
            {
                if (pos == 1)
                {
                    if (Cantidad() == 1)
                    {
                        raiz = null;
                    }
                    else
                    {
                        Nodo ultimo = raiz.ant;
                        raiz = raiz.sig;
                        ultimo.sig = raiz;
                        raiz.ant = ultimo;
                    }
                }
                else
                {
                    Nodo reco = raiz;
                    for (int f = 1; f <= pos - 1; f++)
                        reco = reco.sig;
                    Nodo anterior = reco.ant;
                    reco = reco.sig;
                    anterior.sig = reco;
                    reco.ant = anterior;
                }
            }
        }

    }
}
