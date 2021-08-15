using System;

namespace ActividadSemana3_Programacion
{

    class Program
    {
        static void Main(string[] args)
        {



            int Opcion;
            Opcion = 0;

            Console.WriteLine("::Menu");

            Console.WriteLine("Opcion 1");
            Console.WriteLine("Opcion 2");
            Console.WriteLine("Opcon  3");
            Console.WriteLine("Opcion 4");
            Console.WriteLine("");
            Console.Write("Digite una Opcion del menu");
            Console.WriteLine("");
            Opcion = Convert.ToInt32(Console.ReadLine());
            switch (Opcion)
            {
                case 1:
                    Programa1();
                    break;

                case 2:
                    Programa2();
                    break;

                case 3:
                    Programa3();
                    break;
                case 4:
                    Programa4();
                    break;
                case 0:
                    Console.Write("fin, hasta la proxima....!!");
                    break;

                default:
                    Console.Write("opcion equivocada");
                    break;
            }

            static void Programa1()
            {
                System.Console.WriteLine(" programa 1");
            }


            static void Programa2()
            {
                System.Console.WriteLine(" programa 2");
            }


            static void Programa3()
            {
                System.Console.WriteLine(" programa 3");

            }


            static void Programa4()
            {
                System.Console.WriteLine(" programa 4");
            }
        }
    }
}