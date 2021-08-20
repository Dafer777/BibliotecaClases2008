using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
    public class CollectionExample
    {
        public static void SortedListCollection()
        {
            //definir tamaño de la lista
            Console.Write("Cuantos elementos agregara a la lista: ");
            var elements = Convert.ToInt32(Console.ReadLine());

            //Declarar arrays vacios
            object[] key = new object[elements];
            object[] value = new object[elements];


            // Declarar la lista
            SortedList<object, object> srtList = new SortedList<object, object >();
            int i = 0;

            while (i < elements)
            {
                Console.WriteLine("Escriba el elemento a agregar {0}", i);

                //llenar los arrays
                Console.Write("Key: ");
                key[i] = Console.ReadLine();
                Console.Write("Value: ");
                value[i] = Console.ReadLine();

                //llenar lista
                srtList.Add(key[i], value[i]);

                i++;
            }

            //Mostrar los elementos de la lista
            Console.WriteLine("****ELEMENTOS DE LA LISTA****");
            foreach(KeyValuePair<object,object> element in srtList)
            {
                Console.WriteLine("{0}: {1}", element.Key, element.Value);
            }

               




        }
    }
}
