using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia9
{
     static class Ejercicio1
    {
         static public List<string> frutas=new List<string>();

         public static void menu1()

         {
             int op = 0;
             Console.WriteLine("menu-------");
             Console.WriteLine("1------");
             op = Convert.ToInt32(Console.ReadLine());
             switch (op)
             { case 1:
                     Console.Write("nombre: ");
                     string f = Console.ReadLine();
                     frutas.Add(f);
                     break;

                 case 2:
                     mostrar();
                     break;
                 case 3:
                     Console.WriteLine("posicion: ");
                     op = Convert.ToInt32(Console.ReadLine());
                     Console.WriteLine("nombre:");
                     frutas.Insert(op,Console.ReadLine());
                     break;
                 case 4:
                     Console.WriteLine("nombre:");
                     frutas.Remove(Console.ReadLine());

                     break;
                 case 5:

                     if (frutas.Contains(Console.ReadLine()))
                     {
                         Console.WriteLine("el elemento existe");
                     }
                     else
                     {
                         Console.WriteLine("no se encontro el elemento");
                     }
                     break;
                 case 6:
                     frutas.Clear();
                     break;


                 default:
                     break;
             }

             Console.ReadKey();
         }



         static void mostrar()
         {
             foreach (string item in frutas)
             {
                 Console.WriteLine(item);
             }
         }



    }

    







}
