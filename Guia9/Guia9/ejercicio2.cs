using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia9
{
    static class ejercicio2
    {

        static Dictionary<string, alumnos> alum = new Dictionary<string, alumnos>();
        public static void menu2()
        {
            bool bandera = true;
            string op;
            do
            {

           
            Console.WriteLine("menu--------------[1-2-3-4-5-6]");
            switch (Convert.ToInt32(Console.ReadLine()))
            {case 1:
                    alumnos alumno=new alumnos();
                    do
                    {
                        Console.WriteLine("carnet: ");
                        op = Console.ReadLine();
                        if (alum.ContainsKey(op))
                        {
                            Console.WriteLine("el carnet ya existe");
                            
                        }
                        else
                        {
                            alumno.carnet = op;
                            break;
                        }
                    } while (true);
                    Console.WriteLine("nombre");
                    alumno.nombre = Console.ReadLine();
                    alum.Add(alumno.carnet, alumno);
                    break;
                case 2:
                    foreach (var a in alum)
                    {
                        Console.WriteLine(  "carnet: {0}",a.Value.carnet);
                        Console.WriteLine("nombre:  {0}",a.Value.nombre);
                    }
                    break;
                case 3:
                    string op2;
                    Console.WriteLine("ingrese carnet:");
                    op2 = Console.ReadLine();
                    if (alum.ContainsKey(op2))
                    {
                        Console.WriteLine(alum[op2].carnet);
                        Console.WriteLine(alum[op2].nombre);
                    }



                    break;
                case 4:
                    string op3;
                    Console.WriteLine("ingrese carnet:");
                    op3 = Console.ReadLine();
                    
                    if (alum.ContainsKey(op3))
                    {
                        alum.Remove(op3);
                    }
                    break;
                    case 5:
                        alum.Clear();
                        Console.WriteLine("diccionario vaciado");
                        break;
                    case 6:
                        bandera = false;
                        break;
                default:
                    break;
                }
            } while (bandera);
            Console.ReadKey();
        }

        public struct alumnos
        {
             public string carnet,nombre,carrera;
             private double cum;

             public void setcum(double cum)
             {
                 while (cum<=0.0 && cum>10.0)
                 {
                     Console.WriteLine("ingrese el cum: ");
                     cum = Convert.ToDouble(Console.ReadLine());

                 } this.cum = cum;
             }

             public double getCum()
             {
                 return this.cum;
             }
        }



        

    }



     
}
