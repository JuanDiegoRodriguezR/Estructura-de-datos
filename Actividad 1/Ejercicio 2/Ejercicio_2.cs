using System;

namespace C__proyecto
{
    class Ejercicio_2
    {
        static void Main(string[] args)
        {
           //Creado por: Juan Diego Rodriguez Riaño
            //Actividad semana1
            //Turno: Diurno

            // Problema 3: las peliculas
            float peli1,peli2,peli3,opera;
            Console.WriteLine (" ");
            Console.WriteLine ("Presentado por Juan Diego Rodriguez Riaño");
            Console.WriteLine (" ");
            Console.WriteLine ("***Problema 3:Las peliculas promocion: ");
            Console.WriteLine (" ");

            //aqui recolectamos datos de las pelis

            Console.WriteLine("Ingrese el precio de la primera peli: ");
            peli1= float.Parse (System.Console.ReadLine());
            Console.WriteLine (" ");
            Console.WriteLine("Ingrese el precio de la segunda peli: ");
            peli2= float.Parse (System.Console.ReadLine());
            Console.WriteLine (" ");
            Console.WriteLine("Ingrese el precio de la tercera peli: ");
            peli3= float.Parse (System.Console.ReadLine());
            Console.WriteLine (" ");
            
            //aqui se realiza la operacion del descuento

            if (peli1>peli2 && peli1>peli3)
            {
                opera= peli2+peli3;
                Console.WriteLine("Por la compra de las 3 peliculas debe pagar: {0} ", opera);
            }
            else if (peli2 >peli1 && peli2>peli3 )
            {
                opera= peli3+peli1;
                Console.WriteLine("Por la compra de las 3 peliculas debe pagar: {0} ", opera);

            }
            else 
            {
                opera= peli1+peli2;
                Console.WriteLine ("Por la compra de las 3 peliculas debe pagar: {0} ", opera);

            }

            //fin del programa

            Console.WriteLine (" ");
            Console.WriteLine("Fin del programa.");


            





        }
    }
}