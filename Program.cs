using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> enteros = new List<int>();
            enteros.Add(1);
            enteros.Add(2);
            enteros.Add(3);
            enteros.Add(4);
            enteros.Add(5);
            enteros.Add(6);
            enteros.Add(7);
            enteros.Add(8);
            enteros.Add(9);
            enteros.Add(10);
            int[] resultado = getArray(enteros);
            Console.WriteLine("---- ARRAY ----");
            foreach (int entero in resultado)
            {
                Console.WriteLine(""+entero);
            }
            Console.WriteLine("---- LISTA ----");
            enteros = getList(resultado);
            foreach (int entero in enteros)
            {
                Console.WriteLine("" + entero);
            }
            Console.ReadLine();
        }

        static T[] getArray<T>(List<T> lista)
        {
            T[] array = new T[lista.Count];
            for (int i = 0; i < lista.Count; i++)
            {
                array[i] = lista[i];
            }
            return array;
        }

        static List<T> getList<T>(T[] array)
        {
            List<T> lista = new List<T>();
            for (int i = 0; i < array.Length; i++)
            {
                lista.Add(array[i]);
            }
            return lista;
        }
    }
}
