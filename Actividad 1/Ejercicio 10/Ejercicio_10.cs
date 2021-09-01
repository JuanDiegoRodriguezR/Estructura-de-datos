using System;

namespace C__proyecto
{
    class Ejercicio_10
    {
        static void Main(string[] args)
        {
        //Creado por: Juan Diego Rodriguez Riaño
        //Actividad semana1
        //Turno: Diurno
        // Problema 10: sacar la raiz cuadrada
            string contraseña;
            int wi=1;
            Console.WriteLine (" ");
            Console.WriteLine ("Presentado por Juan Diego Rodriguez Riaño");
            Console.WriteLine (" ");
            Console.WriteLine ("***Problema 10: la contraseña ");
            Console.WriteLine (" ");

            Console.WriteLine ("La contraseña para ingresar al sistema es iloveyou123. ");
            Console.WriteLine (" ");

            while (wi==1)
            {
            Console.WriteLine ("Ingrese la contraseña: ");
            contraseña= System.Console.ReadLine();
            Console.WriteLine (" ");

            //al ingresar la contraseña de manera correcta, nos permite desactivar el ciclo while y por lo tanto entrar al sistema

            if (contraseña== "iloveyou123")
            {
            wi=0;

            }
            //si la contraseña es distinta a lo indicado, el ciclo while continuara hasta que el usuario ingrese la contraseña
            //correcta
            if (contraseña != "iloveyou123")
            {
            
            Console.WriteLine (" ");
            Console.WriteLine ("La contraseña es incorrecta, vuelva a intentar ");
            Console.WriteLine (" ");


            }

            }
            Console.WriteLine (" ");
            Console.WriteLine ("Bienvenido al sistema ");
            Console.WriteLine (" ");

            


            





        }
    }
}