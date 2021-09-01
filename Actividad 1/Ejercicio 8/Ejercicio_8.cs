using System;

namespace C__proyecto
{
    class Ejercicio_8
    {
        static void Main(string[] args)
        {
        //Creado por: Juan Diego Rodriguez Riaño
        //Actividad semana1
        //Turno: Diurno
        // Problema 8: vocal,letra minuscula y alfabeto
            
            char c;
            string lol="";
            int o=1;
            Console.WriteLine (" ");
            Console.WriteLine ("Presentado por Juan Diego Rodriguez Riaño");
            Console.WriteLine (" ");
            Console.WriteLine ("***vocal,letra minuscula y alfabeto*** ");
            Console.WriteLine (" ");

            while (o==1)
             {

             Console.WriteLine (" ");
             Console.WriteLine ("Escriba una letra: ");
             c= char.Parse (System.Console.ReadLine());
             //aqui determina si es mayuscula y a partir de eso, determina si es un alfabeto o vocal

             if (char.IsUpper(c))
             {
                Console.WriteLine (" ");
                Console.WriteLine ("El valor ingresado es alfabeto");
                Console.WriteLine (" ");
                Console.WriteLine ("La letra {0} es mayuscula. ", c);
                //con el switch se decide si es vocal la letra ingresada, no se puede con el if debido a que se usa un valor char
                switch (c)
             {
                case 'A':
                   Console.WriteLine("La letra {0} es vocal",c);
                   break;
               case 'E':
                   Console.WriteLine("La letra {0} es vocal",c);
                    break;
               case 'I':
                   Console.WriteLine("La letra {0} es vocal",c);
                   break;
               case 'O':
                   Console.WriteLine("La letra {0} es vocal",c);
                   break;
               case 'U':
                   Console.WriteLine("La letra {0} es vocal",c);
                   break;
               
             }
             
            }else if (char.IsLower(c))
             {
                Console.WriteLine (" ");
                Console.WriteLine ("El valor ingresado es alfabeto");
                Console.WriteLine (" ");
                Console.WriteLine ("La letra {0} es minuscula. ", c);
                switch (c)
             {
                //con el switch se decide si es vocal la letra ingresada, no se puede con el if debido a que se usa un valor char
                case 'a':
                   Console.WriteLine("La letra {0} es vocal",c);
                   break;
               case 'e':
                   Console.WriteLine("La letra {0} es vocal",c);
                    break;
               case 'i':
                   Console.WriteLine("La letra {0} es vocal",c);
                   break;
               case 'o':
                   Console.WriteLine("La letra {0} es vocal",c);
                   break;
               case 'u':
                   Console.WriteLine("La letra {0} es vocal",c);
                   break;
             }
             

               
            //Si no es un alfabeto, mandara un error
             }else 
            {
                Console.WriteLine (" ");
                Console.WriteLine ("El caracter ingresado {0} no es un alfabeto ", c);

            }
            //aqui determina si es minuscula y a partir de eso, determina si es un alfabeto o vocal

           
               
             
             Console.WriteLine ("¿Desea salir del sistema (s/n)?");
             lol= Console.ReadLine();
             if ( lol=="S" || lol=="s")
            {
                o=0;
            }
             
      
             
        }
            
            
             




            





        }
    }
} 