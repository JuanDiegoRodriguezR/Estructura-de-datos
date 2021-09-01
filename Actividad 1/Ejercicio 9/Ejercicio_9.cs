using System;

namespace C__proyecto
{
    class Ejercicio_9
    {
        static void Main(string[] args)
        {
        //Creado por: Juan Diego Rodriguez Riaño
        //Actividad semana1
        //Turno: Diurno
        // Problema 9: edad humana a edad perruna
            double edad,conversion;
            Console.WriteLine (" ");
            Console.WriteLine ("Presentado por Juan Diego Rodriguez Riaño");
            Console.WriteLine (" ");
            Console.WriteLine ("***Problema 9: edad humana a edad perruna ");
            Console.WriteLine (" ");


            Console.WriteLine (" ");
            Console.WriteLine ("Ingrese la edad humana: ");
            edad= int.Parse (System.Console.ReadLine());
            Console.WriteLine (" ");


            if (edad<=2)
            {
                //los primeros dos años perrunos equivalen a 10.5, por lo cual seria una multiplicacion
            conversion= edad*10.5; 
            Console.WriteLine ("La edad ingresada {0} en años perrunos es {1}", edad, conversion);
            }
            else
            {
                //a partir de aqui se saca los años perruno en base a que despues de los 2 años dejan de ser 10.5 años y pasan
                //a ser 4, se le suma los 21 años de los 2 años, se le resta un dos y se multiplican los 4 años.
             conversion= 21+(edad-2)*4;
             
             Console.WriteLine ("La edad ingresada {0} en años perrunos es de aproximadamente de {1}", edad, conversion);
           
            }
           



            





        }
    }
}