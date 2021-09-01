using System;

namespace C__proyecto
{
    class Ejercicio_7
    {
        static void Main(string[] args)
        {
            // Problema 7: ventas de tres productos
            Console.WriteLine (" ");
            Console.WriteLine ("Presentado por Juan Diego Rodriguez Riaño");
            Console.WriteLine (" ");
            Console.WriteLine ("***Problema 7: ventas de tres productos ");
            Console.WriteLine (" ");
            int A=0;
            int B=0;
            int C=0;
            int total;
            string op;
            

           do{

            Console.WriteLine (" ");
            Console.WriteLine ("Para iniciar, ingrese las ventas de los respectivos productos: ");
            Console.WriteLine (" ");
            Console.WriteLine ("Ingrese las ventas del producto A: " );
            A= int.Parse (System.Console.ReadLine());
            Console.WriteLine (" ");
            Console.WriteLine ("Ingrese las ventas del producto B: " );
            B= int.Parse (System.Console.ReadLine());
            Console.WriteLine (" ");
            Console.WriteLine ("Ingrese las ventas del producto C: " );
            C= int.Parse (System.Console.ReadLine());

            total=A+B+C;
           
            if (A>B && A>C)
            {
                Console.WriteLine (" ");
                Console.WriteLine ("El producto A es quien tiene mas ventas");
                Console.WriteLine (" ");

            }

            if (B<A && B<C)
            {
                Console.WriteLine (" ");
                Console.WriteLine ("El producto B es quien tiene menos ventas");
                Console.WriteLine (" ");

            }
        
            if (A>=200 || B>=200 || C>=200)
            {
                Console.WriteLine (" ");
                Console.WriteLine ("Ningun producto tiene ventas inferiores a las 200.");
                Console.WriteLine (" ");
            }

            
            
            if (A>=400 || B>=400 || C>=400)
            {
                Console.WriteLine (" ");
                Console.WriteLine ("Uno de los productos tiene ventas superiores a las 400.");
                Console.WriteLine (" ");
                
            }



            if (total/3>=500)
            {
                Console.WriteLine (" ");
                Console.WriteLine ("La media de ventas de los productos es igual a");
                Console.WriteLine (" ");

            }
            if (total>=500 && total<=1000)
            {
                Console.WriteLine (" ");
                Console.WriteLine ("La venta total del producto varia entre 500 y 1000");
                Console.WriteLine (" ");
            }

            

           Console.WriteLine("¿Desea salir? (S/N)");
            op= Console.ReadLine();
           }while (op!="S" && op!="s");




        }
    }
}