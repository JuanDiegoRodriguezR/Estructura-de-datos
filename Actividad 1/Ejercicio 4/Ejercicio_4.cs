using System;

namespace C__proyecto
{
    class Ejercicio_4
    {
        static void Main(string[] args)
        {
            //Creado por: Juan Diego Rodriguez Riaño
            //Actividad semana1
            //Turno: Diurno

            // Problema 4: conjetura de Collatz
            float nume1,swi=1;
            Console.WriteLine (" ");
            Console.WriteLine ("Presentado por Juan Diego Rodriguez Riaño");
            Console.WriteLine (" ");
            Console.WriteLine ("***Problema 4: la conjetura de Collatz ");
            Console.WriteLine (" ");

            //Aqui se hace un switch, haciendo que el ciclo se repita mientras que la variable swi sea igual a uno

            while (swi==1)
            {

            Console.WriteLine (" ");
            Console.WriteLine ("Si quiere salir del sistema, ingrese 0. ");
            Console.WriteLine ("Ingresar el numero: ");
            nume1= float.Parse (System.Console.ReadLine());
            Console.WriteLine (" ");
            //Como es indicado, si el resultado es 1 entonces la secuencia no se puede dar, de todas maneras no es necesario un
            //else en este caso al ser un ciclo que se repite y le da al usuario la opcion de volver a ingresar un numero
            if (nume1==1)
            {
                Console.WriteLine (" ");
                Console.WriteLine ("Este numero no hace parte de la secuencia. ");
                Console.WriteLine (" ");
            }
            //A partir de que la variable sea uno, ya se puede iniciar otro ciclo donde se determina si el numero es par o no
            //y con eso se hace la conjetura de Collatz
            while (nume1>1)
            {
                 if (nume1%2==0)
            {
                Console.WriteLine (" ");
                Console.WriteLine ("La secuencia de este numero par es: ");
                nume1=nume1/2;
                Console.WriteLine ("{0}", nume1);
                Console.WriteLine (" "); 
            }
            else
            {
                Console.WriteLine (" ");
                Console.WriteLine ("La secuencia de este numero impar es: ");
                nume1=(nume1*3)+1;
                Console.WriteLine ("{0}", nume1);
                Console.WriteLine (" ");

            }

            }

            //para cerrar el ciclo y salir del sistema se apaga el switch, haciendo que si la variable ingresada es igual a cero c
            //haga un cambio en el swi, cambiandolo a cero y acabando asi el ciclo

            if (nume1==0)
            {
                swi=0;
            }

            }
            Console.WriteLine (" ");
            Console.WriteLine ("Fin del sistema");
            Console.WriteLine (" ");





            





        }
    }
}