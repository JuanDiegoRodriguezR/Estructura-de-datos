using System;

namespace C__proyecto
{
    class Ejercicio_3
    {
        static void Main(string[] args)
        {
            //Creado por: Juan Diego Rodriguez Riaño
            //Actividad semana1
            //Turno: Diurno

            // Problema 3: las calificaciones
            float califi1,califi2,califi3,califi4,operacion;
            Console.WriteLine (" ");
            Console.WriteLine ("Presentado por Juan Diego Rodriguez Riaño");
            Console.WriteLine (" ");
            Console.WriteLine ("***Problema 3: las calificaciones de un estudiante ");
            Console.WriteLine (" ");
            //aqui recolectamos los datos del estudiate
            Console.WriteLine ("Ingrese la calificacion 1 del estudiante: " );
            califi1= float.Parse (System.Console.ReadLine());
            Console.WriteLine (" ");
            Console.WriteLine ("Ingrese la calificacion 2 del estudiante: " );
            califi2= float.Parse (System.Console.ReadLine());
            Console.WriteLine (" ");
            Console.WriteLine ("Ingrese la calificacion 3 del estudiante: " );
            califi3= float.Parse (System.Console.ReadLine());
            Console.WriteLine (" ");
            Console.WriteLine ("Ingrese la calificacion 4 del estudiante: " );
            califi4= float.Parse (System.Console.ReadLine());

            //para esta parte tomamos en cuenta las calificaciones altas:


            if (califi1>califi2 && califi1>califi3 && califi1>califi4)
            {
                Console.WriteLine ("La calificacion mas alta del estudiante ha sido la primera. ");
            }
            if (califi2>califi1 && califi2>califi3 && califi2>califi4)
            {
                Console.WriteLine ("La calificacion mas alta del estudiante ha sido la segunda. ");
            }
            
            if (califi4>califi2 && califi4>califi3 && califi4>califi1)
            {
                Console.WriteLine ("La calificacion mas alta del estudiante ha sido la cuarta. ");
            }
            if (califi3>califi1 && califi3>califi2 && califi3>califi4)
            {
                Console.WriteLine ("La calificacion mas alta del estudiante ha sido la tercera. ");
            }

            
            //para esta parte tomamos en cuenta las calificaciones bajas:


            if (califi1<califi2 && califi1<califi3 && califi1<califi4)
            {
                Console.WriteLine ("La calificacion mas baja del estudiante ha sido la primera. ");
            }
            if (califi2<califi1 && califi2<califi3 && califi2<califi4)
            {
                Console.WriteLine ("La calificacion mas baja del estudiante ha sido la segunda. ");
            }
            
            if (califi4<califi2 && califi4<califi3 && califi4<califi1)
            {
                Console.WriteLine ("La calificacion mas baja del estudiante ha sido la cuarta. ");
            }
            if (califi3<califi1 && califi3<califi2 && califi3<califi4)
            {
                Console.WriteLine ("La calificacion baja del estudiante ha sido la tercera. ");
            }
            
            //Para esta parte se saca el promedio:
            

        

            operacion= (califi1+califi2+califi3+califi4)/4;

            Console.WriteLine ("El promedio obtenido durante la materia es de: {0}",operacion);
            Console.WriteLine (" ");

        
            
           
           


            





        }
    }
} 
