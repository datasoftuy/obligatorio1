using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace obligatorio1
{
    class Program
    {
        static void Main(string[] args)
        {

            string opcioncinco = "";
            string opcionlistado = "";
            string[] usuarios = new string[0];
            int[,] jugadas = new int[0, 0];

            while (opcioncinco != "0")
            {

                opcioncinco = MenuCincodeoro();
                switch (opcioncinco)
                {

                    case "1":

                        Console.WriteLine("Ingresar la cantidad de clientes de la agencia");
                        Console.ReadLine();
                        largovector(usuarios);

                        break;


                    case "2":

                        Console.WriteLine("Agregar una apuesta");
                        break;


                    case "3":

                        Console.WriteLine("Cinco de Oro sorpresa");
                        break;

                    case "4":

                        Console.WriteLine("Eliminar una apuesta");
                        break;

                    case "5":

                        Console.Clear();
                        opcionlistado = MenuListado();

                        switch (opcionlistado)
                        {

                            case "1":
                                Console.WriteLine("\t Números de un apostador.");

                                break;

                            case "2":
                                Console.WriteLine("\t Listado completo de apuestas");

                                break;

                            case "3":
                                Console.WriteLine("\t Números que no han tenido apuestas.");

                                break;




                        }

                        break;

                    default: Console.WriteLine("La opcion" + opcioncinco + " no es correcta");
                        break;
                }

            }

        }

        #region MenuCincodeoro
        static String MenuCincodeoro()
        {

            string opcion;
            Console.WriteLine("\n\n\t\t * Cinco de oro*\n\n");
            Console.WriteLine("\t1- Ingresar la cantidad de clientes de la agencia");
            Console.WriteLine("\t2- Agregar una apuesta");
            Console.WriteLine("\t3- Agregar una apuesta sorpresa");
            Console.WriteLine("\t4- Eliminar una apuesta");
            Console.WriteLine("\t5- Listados");
            Console.WriteLine("\n\tIngrese la opción deseada: ");
            opcion = Console.ReadLine();
            return opcion;
        }
        #endregion

        #region MenuListado

        static String MenuListado()
        {
            string opcionl;
            Console.WriteLine("\n\n\t\t * Listados de la aplicación*\n\n");
            Console.WriteLine("\t1- Números de un apostador.");
            Console.WriteLine("\t2- Listado completo de apuestas");
            Console.WriteLine("\t3- Números que no han tenido apuestas.");
            Console.Write("\n\tIngrese la opción deseada: ");
            opcionl = Console.ReadLine();
            return opcionl;
        }
        #endregion

        static String[] largovector(string[] usuarios)
        {

            
            string[] clientesfuncion = usuarios;
            string cambiar ="";
            int largo;
             if (clientesfuncion.Length > 0)
           {
               Console.Write("\n\tSi cambia este parametro se perderan los clientes\n");
               Console.Write("Desea continuar? (SI/NO): ");
               cambiar = Console.ReadLine();
           }
           if (cambiar.ToLower() == "si")
           {
               Console.Write("\n\tIngrese la cantidad de clientes: ");
               clientesfuncion = new string[Convert.ToInt32(Console.ReadLine())];
               Console.WriteLine("\n\n\tEl sistema se inicio con la cantidad de clientes: " + clientesfuncion.Length);
           }
           else
           { Console.WriteLine("\n\n\tNo se ha cambiado la cantidad de clientes del sistema."); }
           Console.Write("\n\t\tPulsar ENTER para CONTINUAR.");
          
            Console.ReadLine();




            return usuarios[];
        
        }




    }
}