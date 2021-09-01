using System;

namespace C__proyecto
{
    class Ejercicio_1
    {
        static void Main(string[] args)
        {
            //Creado por: Juan Diego Rodriguez Riaño
            //Actividad semana1
            //Turno: Diurno

            // Problema 1: encontrar el valor absoluto de un numero
            float nume, nume2=0;
            Console.WriteLine (" ");
            Console.WriteLine ("Presentado por Juan Diego Rodriguez Riaño");
            Console.WriteLine (" ");
            Console.WriteLine ("***Problema 1: encontrar el valor absoluto de un numero");
            Console.WriteLine (" ");

            //recolectar el numero en cuestion

            Console.WriteLine ("Ingresar el numero del que quiere saber su valor absoluto: ");
            nume= float.Parse (System.Console.ReadLine());
            Console.WriteLine (" ");

            //sacar el valor absoluto
            

           if (nume>=nume2)
           {
           Console.WriteLine ("El valor absoluto del numero ingresado es: {0}", nume);
           Console.WriteLine (" ");
           }
           else
           {
           nume= -nume;
           Console.WriteLine ("El valor absoluto del numero ingresado es: {0}", nume);
           Console.WriteLine (" ");
           }
        
           

            


            





        }
    }
}