using System;

namespace C__proyecto
{
    class Ejercicio_5
    {
        static void Main(string[] args)
        {
        //Creado por: Juan Diego Rodriguez Riaño
        //Actividad semana1
        //Turno: Diurno

        // Problema 5: sacar la raiz cuadrada
        //Las variables son double debido a que la funcion para sacar la raiz solo acepta variables double
            double nume,raiz;
            Console.WriteLine (" ");
            Console.WriteLine ("Presentado por Juan Diego Rodriguez Riaño");
            Console.WriteLine (" ");
            Console.WriteLine ("***Problema 5: sacar la raiz cuadrada ");
            Console.WriteLine (" ");

            //Aqui toma los datos.

            Console.WriteLine ("Inserte el numero al que sacar la raiz cuadrada: ");
            nume= float.Parse (System.Console.ReadLine());
            Console.WriteLine (" ");

            //Si el numero es positivo entonces se realiza la raiz

            if (nume>=1)
            {

            raiz= Math.Sqrt(nume);
            Console.WriteLine (" ");
            Console.WriteLine ("La raiz del numero {0} es {1} ", nume, raiz);
            Console.WriteLine (" ");

            }

            //Si el numero es negativo no es posible de realizarse la raiz.
            
            if (nume<=0)
            {
            Console.WriteLine (" ");
            Console.WriteLine ("El numero no es positivo, por lo tanto no puede tener raiz. ");
            Console.WriteLine (" ");

            }




            


            





        }
    }
}