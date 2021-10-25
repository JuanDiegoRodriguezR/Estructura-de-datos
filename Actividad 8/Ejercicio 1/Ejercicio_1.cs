using System;
using System.Collections;
using System.Collections.Generic;
namespace C__proyecto
{
    class Ejercicio_1
    {
      

        
        static void Main(string[] args)
        {
     
        //Creado por: Juan Diego Rodriguez Riaño
        //Turno: Diurno
        //Codigo: 239-2A DIA

        /* Problema 1:  Hacer multiples representaciones de funciones String*/

        //Variables que seran usadas de forma global en el codigo
        int opciones,num1;
        string salida,cadena1,cadena2,cadena4;
        char pal;
        string [] cadena3;
        Boolean opcion;
        System.Text.StringBuilder Ap = new System.Text.StringBuilder();

         Console.WriteLine ("────────MENU─────────");


        do
        {
          Console.WriteLine ("Opciones \n1)Reemplazar una cadena por otra (Replace) \n2)Extraer los caracteres de una frase ingresada por teclado (SubString) \n3)Comparar una cadena de caracteres(Equals)");
          Console.WriteLine ("4)Concatenar dos strings (Concat) \n5)Conseguir en mayuscula y minuscula los elementos de un arraylist (ToLower y ToUpper) \n6)Comparar dos strings (Compare) \n7)Copiar una cadena de elementos a otra (CopyTo)");
          Console.WriteLine ("8)Verificar si un elemento esta dentro de una lista de strings ingresados por teclado (Contains) \n9)Verificar si una frase ingresada por teclado termina con determinado caracter(EndsWith) \n10)Insertar un nuevo elemento a una lista escrita por teclado (Insert) ");
          Console.WriteLine ("11)Conocer el ultimo indice de letra de una palabra escrita por teclado (LastIndexOf) \n12)Agregar una letra en la izquierda de una frase escrita por teclado(PadLeft) \n13)Agregar una letra en la derecha de una frase escrita por teclado (PadRight)");
          Console.WriteLine ("14)Remover un elemento de una lista ingresada por teclado (Remove) \n15)Separar un elemento de una frase ingresada por teclado (Split) \n16)Elimina todos los caracteres de toda una frase o palabra escrita por teclado (Trim) \n17)Elimina todos los caracteres del principio de una frase o palabra escrita por teclado (TrimStart) ");
          Console.WriteLine ("18)Elimina todos los caracteres del final de una frase o palabra escrita por teclado (TrimEnd) \n19)Hacer uso de valores booleanos y append para responder un pequeño formulario (Append) \n20) Hacer uso del AppendFormat para actualizar los elementos de una cadena escrita por teclado (AppendFormat) ");
          Console.WriteLine ("21)Hacer una lista de strings (WriteLine) \n22)ToString");
          Console.Write("Eliga una opcion: ");    
          opciones= int.Parse (Console.ReadLine());
          Console.WriteLine ("\n"); 
          switch (opciones)
          {
          

            case 1:
            Console.WriteLine ("Reemplazar una cadena por otra");
            Console.WriteLine ("─────────────────────");
            Console.WriteLine ("Inserte una palabra: ");
            cadena1= Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine ("Inserte otra palabra");
            cadena2= Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine ("Ahora la cadena 1 reemplazara la 2 y viceversa: ");
            Console.WriteLine ("-"+cadena1.Replace(cadena1,cadena2));
            Console.WriteLine ("-"+cadena2.Replace (cadena2,cadena1));
              break;

            case 2:
            string frase;
            Console.WriteLine ("Extraer los caracteres de una frase ingresada por teclado");
            Console.WriteLine ("─────────────────────");
            Console.WriteLine ("Escriba una frase");
            cadena1= Console.ReadLine ();
            Console.WriteLine ($"La frase que escribiste tiene {cadena1.Length} numero de caracteres");    
            Console.WriteLine ("Ahora conociendo esto, elija desde que numero quiere extraer el texto (tomando en cuenta el numero de caracteres): "); 
            num1= int.Parse (Console.ReadLine());
            frase= cadena1.Substring(0,num1);
            Console.WriteLine ("─────────────────────");
            Console.WriteLine ($"Las letras extraidas de la frase {cadena1} es: ");
            Console.WriteLine (frase);
              break; 
           

            case 3:
            Console.WriteLine ("Comparar una cadena de caracteres");
            Console.WriteLine ("─────────────────────");
            Console.WriteLine ("Inserte una palabra: ");
            cadena1= Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine ("Inserte otra palabra");
            cadena2= Console.ReadLine();
            Console.WriteLine();
            bool Comparar= cadena1.Equals(cadena2);
            if (Comparar==true)
            {
                Console.WriteLine ("La cadena es igual");
            }
            else
            {
                Console.WriteLine ("La cadena es diferente");
            }
              break;

            case 4:
           
            Console.WriteLine ("Concatenar dos strings");
            Console.WriteLine ("─────────────────────");
            Console.WriteLine ("Escriba una palabra o frase (primer string)");
            cadena1= Console.ReadLine();
            Console.WriteLine ("Escriba una palabra o frase (segundo string)");
            cadena2= Console.ReadLine();
            Console.WriteLine ("─────────────────────");
            Console.WriteLine ("Los elementos concatenados son: ");
            string conca= string.Concat (cadena1," "+cadena2);
            Console.WriteLine (conca);
              break;

            case 5:
            ArrayList mayu= new ArrayList();
            Console.WriteLine ("Conseguir en mayuscula y minuscula los elementos de un arraylist");
            Console.WriteLine ("─────────────────────");
            Console.WriteLine ("Ingrese la cantidad de elementos que ingresara en el arraylist");
            num1= int.Parse (Console.ReadLine());
            for (int a=0; a<num1;a++)
            {
              Console.WriteLine ($"Escriba el elemento de la lista N{a+1}");
              cadena1= Console.ReadLine();
              mayu.Add(cadena1);
            }
            Console.WriteLine ("─────La lista en mayuscula─────");
            foreach (string a in mayu)
            {
              Console.WriteLine (a.ToUpper());
            }
            Console.WriteLine ("─────La lista en minuscula─────");
            foreach (string a in mayu)
            {
              Console.WriteLine (a.ToLower());
            }
              break;

            case 6:
            Console.WriteLine ("Comparar dos strings usando compare");
            Console.WriteLine ("─────────────────────");
            Console.WriteLine ("Ingrese una palabra para el primer string: ");
            cadena1= Console.ReadLine();
            Console.WriteLine ("Ingrese una palabra para el segundo string: ");
            cadena2= Console.ReadLine();
            if (String.Compare(cadena1,cadena2)==0)
            {
              Console.WriteLine ("Los strings son iguales");
            }
            else
            {
              Console.WriteLine ("Los strings no son iguales");
            }
              break;

            case 7:
            
            List<string> fr = new List<string>();
            Console.WriteLine ("Copiar una cadena de elementos a otra haciendo uso del copyto");
            Console.WriteLine ("─────────────────────");
            Console.WriteLine ("¿Cuantas frases va agregar a la lista?: ");
            num1= int.Parse (Console.ReadLine());
        
            for (int a=0; a<num1 ;a++)
            {
              Console.WriteLine ($"Escriba el elemento N{a+1} de la lista");
              cadena1= Console.ReadLine();
              fr.Add(cadena1);
            }
            string [] fr2= new string [num1];
            fr.CopyTo(fr2);
            Console.WriteLine ("─────La copia de la lista─────");
            foreach (string a in fr2)
            {
              Console.Write(" "+a);
            }
            break;

           case 8:
           ArrayList el1= new ArrayList();
           Console.WriteLine ("Verificar si un elemento esta dentro de una lista de strings ingresados por teclado");
           Console.WriteLine ("─────────────────────");
           Console.WriteLine ("Ingrese cuantos elementos quiere ingresar a la lista");
           num1= int.Parse (Console.ReadLine());
           for (int a=0; a<num1;a++)
            {
           Console.WriteLine ($"Escriba el elemento {a+1} de la lista");
           cadena1= Console.ReadLine();
           el1.Add(cadena1);
            }
           Console.WriteLine ("─────────────────────");
           Console.WriteLine ("¿Que frase quiere comprobar que esta dentro del arraylist?");
           cadena2=Console.ReadLine();
           if (el1.Contains(cadena2)==true)
           {
             Console.WriteLine ();
             Console.WriteLine ("La frase esta en la lista");
           }
           else
           {
             Console.WriteLine ();
             Console.WriteLine ("La frase no esta en la lista");
           }

             break;
          case 9:
       
           Console.WriteLine ("Verificar si una frase ingresada por teclado termina con determinado caracter");
           Console.WriteLine ("─────────────────────");
           Console.WriteLine ("Ingrese una frase o letra");
           cadena1= Console.ReadLine();
           Console.Clear();
           Console.WriteLine ("¿Con que elemento cree que termina la frase?");
           cadena2= Console.ReadLine ();
           Console.WriteLine ("─────────────────────");
           if (cadena1.EndsWith(cadena2)==true)
           {
             Console.WriteLine ("¡CORRECTO!");
             Console.WriteLine ($"La frase {cadena1} si termina con {cadena2}");
           }
           else
           {
              Console.WriteLine ("¡INCORRECTO!");
              Console.WriteLine ($"La frase {cadena1} no termina con {cadena2}");
           }
           
             break;
           
           case 10:
         
           ArrayList li1= new ArrayList();
           Console.WriteLine ("Insertar un nuevo elemento a una lista escrita por teclado ");
           Console.WriteLine ("─────────────────────");
           Console.WriteLine ("¿Cuantos elementos quiere ingresar a la lista?");
           num1= int.Parse (Console.ReadLine());
           for (int a=0; a<num1;a++)
           {
             Console.WriteLine ($"Ingrese el elemento {a+1} del la lista: ");
             cadena1= Console.ReadLine();
             li1.Add(cadena1);
           }
           Console.WriteLine ($"El numero de elementos del array es {li1.Count} ");
           Console.WriteLine ("─────────────────────"); 
           Console.WriteLine ("Ingrese la palabra que quiere ingresar en la lista");
           cadena1= Console.ReadLine();
           Console.WriteLine ("Ingrese en que posicion lo quiere ingresar (no puede ser el tamaño del array)");
           num1= int.Parse (Console.ReadLine());
           li1.Insert (num1,cadena1);
           Console.WriteLine ("─────────────────────"); 
           Console.WriteLine ("La lista con elementos ingresados es la siguiente"); 
           foreach (string a in li1)
           {
             Console.WriteLine ("-"+a);
        
           }
             break;
          case 11:
         
          Console.WriteLine ("Conocer el ultimo indice de letra de una palabra escrita por teclado");
          Console.WriteLine ("─────────────────────");
          Console.WriteLine ("Escriba una palabra: ");
          cadena1= Console.ReadLine ();
          Console.WriteLine ("Escriba la letra de la cual quiere conocer su ultimo indice: ");
          cadena2= Console.ReadLine ();
          int nu= cadena1.LastIndexOf(cadena2);
          Console.WriteLine ("─────────────────────");
          Console.WriteLine ($"El ultimo indice de la letra {cadena1} en la palabra {cadena2} es: ");
          Console.WriteLine (nu);
             break;
          case 12:
          Console.WriteLine ("Agregar una letra en la izquierda de una frase escrita por teclado");
          Console.WriteLine ("─────────────────────");
          Console.WriteLine ("Escriba un texto: ");
          cadena1= Console.ReadLine();
          Console.WriteLine ("Escriba una letra que quiere agregarle (el caracter es char)");
          pal= char.Parse(Console.ReadLine());
          Console.WriteLine ($"Escriba cuantos espacios quiere aumentarle (tome en cuenta que aparecen desde el espacio {cadena1.Length+1})");
          num1= int.Parse (Console.ReadLine());
          Console.WriteLine ("─────────────────────");
          Console.WriteLine ($"La letra {pal} ha sido agregada al texto {cadena1} con un espacio de {num1} en la izquierda");
          Console.WriteLine (cadena1.PadLeft(num1,pal));
          
             break;
          case 13:
          Console.WriteLine ("Agregar una letra en la derecha de una frase escrita por teclado");
          Console.WriteLine ("─────────────────────");
          Console.WriteLine ("Escriba un texto: ");
          cadena1= Console.ReadLine();
          Console.WriteLine ("Escriba una letra que quiere agregarle (el caracter es char)");
          pal= char.Parse(Console.ReadLine());
          Console.WriteLine ($"Escriba cuantos espacios quiere aumentarle (tome en cuenta que aparecen desde el espacio {cadena1.Length+1})");
          num1= int.Parse (Console.ReadLine());
          Console.WriteLine ("─────────────────────");
          Console.WriteLine ($"La letra {pal} ha sido agregada al texto {cadena1} con un espacio de {num1} en la derecha");
          Console.WriteLine (cadena1.PadRight(num1,pal));
             break;
          
          case 14:
          ArrayList li2= new ArrayList();
          Console.WriteLine ("Remover un elemento de una lista ingresada por teclado");
          Console.WriteLine ("─────────────────────");
          Console.WriteLine ("¿Cuantos elementos quiere ingresar a la lista?");
          num1= int.Parse (Console.ReadLine());
           for (int a=0; a<num1;a++)
           {
             Console.WriteLine ($"Ingrese el elemento {a+1} del la lista: ");
             cadena1= Console.ReadLine();
             li2.Add(cadena1);
           }
           Console.WriteLine ();
           Console.WriteLine ("¿Que palabra quiere remover de la lista?");
           cadena2= Console.ReadLine();
           li2.Remove (cadena2);
           Console.WriteLine ("─────────────────────");
           Console.WriteLine ($"La lista ha removido el elemento {cadena2}, queda de la siguiente manera: ");  
           foreach (string a in li2)
           {
             Console.WriteLine ("-"+a);
           }

          
             break;

          case 15:
          Console.WriteLine ("Separar un elemento de una frase ingresada por teclado");
          Console.WriteLine ("─────────────────────");
          Console.WriteLine ("Ingresa una frase: ");
          cadena1= Console.ReadLine();
          Console.WriteLine("Ingresar el elemento que vas a separar de la frase");
          pal= char.Parse(Console.ReadLine());
          cadena3= cadena1.Split(pal);
          Console.WriteLine ("─────────────────────");
          Console.WriteLine ($"Se ha separado {pal} de la frase {cadena1}, quedando de la siguiente manera: ");
          foreach (string a in cadena3)
          {
            Console.WriteLine (a);
          }
              break;
          
          case 16:
          Console.WriteLine ("Elimina todos los caracteres de toda una frase o palabra escrita por teclado");
          Console.WriteLine ("─────────────────────");
          Console.WriteLine ("Escriba una frase: ");
          cadena1= Console.ReadLine();
          Console.WriteLine ("Ingrese otra frase: ");
          cadena2= Console.ReadLine();
          Console.WriteLine ("Ahora escriba un caracter que quiere eliminar de estas frases");
          pal= char.Parse (Console.ReadLine());
          cadena4= (cadena1.Trim(pal)+cadena2.Trim(pal)).Trim(pal);
          Console.WriteLine ($"Las frases {cadena1+cadena2} sin el elemento {pal} en toda la frase son iguales a: ");
          Console.WriteLine (cadena4);
              break;
          
          case 17:
          Console.WriteLine ("Elimina todos los caracteres del principio de una frase o palabra escrita por teclado");
          Console.WriteLine ("─────────────────────"); 
          Console.WriteLine ("Escriba una frase: ");
          cadena1= Console.ReadLine();
          Console.WriteLine ("Ingrese otra frase: ");
          cadena2= Console.ReadLine();
          Console.WriteLine ("Ahora escriba un caracter que quiere eliminar de estas frases");
          pal= char.Parse (Console.ReadLine());
          cadena4= (cadena1.TrimStart(pal)+cadena2.TrimStart(pal)).TrimStart(pal);
          Console.WriteLine ($"Las frases {cadena1+cadena2} sin el elemento {pal} al principio de la frase son iguales a: ");
          Console.WriteLine (cadena4);
              break;
          case 18:
          Console.WriteLine ("Elimina todos los caracteres del final de una frase o palabra escrita por teclado");
          Console.WriteLine ("─────────────────────"); 
          Console.WriteLine ("Escriba una frase: ");
          cadena1= Console.ReadLine();
          Console.WriteLine ("Ingrese otra frase: ");
          cadena2= Console.ReadLine();
          Console.WriteLine ("Ahora escriba un caracter que quiere eliminar de estas frases");
          pal= char.Parse (Console.ReadLine());
          cadena4= (cadena1.TrimEnd(pal)+cadena2.TrimEnd(pal)).TrimEnd(pal);
          Console.WriteLine ($"Las frases {cadena1+cadena2} sin el elemento {pal} del final de la frase son iguales a: ");
          Console.WriteLine (cadena4);
              break;

          case 19:
          Console.WriteLine ("Hacer uso de valores booleanos y append para responder un pequeño formulario");
          Console.WriteLine ("─────────────────────"); 
          Console.WriteLine ("Ingrese su primer y segundo nombre");
          cadena1= Console.ReadLine();
          Console.WriteLine ("Escriba sus apellidos");
          cadena2= Console.ReadLine();
          Console.WriteLine ("─────────────────────"); 
          Console.WriteLine ($"Bienvenido a la fiesta {cadena1} "+Ap.Append(cadena2));
          Console.WriteLine ("¿Que edad tiene?");
          num1= int.Parse (Console.ReadLine());
          Ap.Clear();
          if (num1>=18)
          {
            opcion= true;
            Console.WriteLine ($"Al tener {num1} su valor booleano es "+Ap.Append(opcion)+" por lo tanto, puede entrar a la fiesta");
          }
          else
          {
            opcion= false;
            Console.WriteLine ($"Al tener {num1} su valor booleano es "+Ap.Append(opcion)+" por lo tanto, no puede entrar a la fiesta");
          }
          Console.WriteLine ("─────────────────────"); 
          Console.WriteLine ("Fin del formulario");
          Ap.Clear();
              break;
          
          case 20:
          Console.WriteLine ("Hacer uso del AppendFormat para actualizar los elementos de una cadena escrita por teclado");
          Console.WriteLine ("─────────────────────"); 
          Console.WriteLine ("Escriba un texto a palabra");
          cadena1= Console.ReadLine();
          Console.WriteLine ("Ahora escriba el texto con el cual lo va reemplazar");
          cadena2= Console.ReadLine();
          Ap.AppendFormat(cadena2);
          cadena1= ($"{Ap}");
          Console.WriteLine ("─────────────────────"); 
          Console.WriteLine ("Ahora el texto queda de la siguiente manera: ");
          Console.WriteLine (cadena1);
          Console.WriteLine ("De esta manera, al llamar a la primera al llamar a la primera cadena, nos dara el resultado de la segunda");


             break;

          case 21:
          string [] CADE= new string [0];
              Console.WriteLine ("Hacer una lista de strings");
              Console.WriteLine ("─────────────────────"); 
              Console.WriteLine ("Ingresa el espacio de la cadena: ");
              num1= int.Parse (Console.ReadLine());
              Console.WriteLine ("--Ahora ingresa elementos a la cadena--");
              CADE= new string [num1];
              Console.WriteLine();
              for (int a=0; a<CADE.Length; a++)
              {
                  Console.WriteLine ($"Elemento {a+1} de la cadena");
                  CADE[a]= Console.ReadLine();
              }
              Console.WriteLine();
              Console.WriteLine ($"La lista de cadena es:");
              foreach (string a in CADE)
               {
               Console.Write (","+ a);
               }
              Console.WriteLine ("\n"); 
              break; 
          
          case 22: 
          Console.WriteLine ("Convertir un int a un string y concatenarlo con otro string");
          Console.WriteLine ("─────────────────────");
          Console.WriteLine ("Escriba su nombre");
          cadena1= Console.ReadLine();
          Console.WriteLine ("Escriba su edad");
          num1= int.Parse (Console.ReadLine());
          cadena2= num1.ToString();
          Console.WriteLine ("─────────────────────");
          Console.WriteLine ($"Su nombre es {cadena1} y su edad es {cadena2}");
          Console.WriteLine ($"El formato de su nombre es {cadena1.GetType()} y el de su edad es {cadena2.GetType()}");
             break;

          


          default:
          Console.WriteLine ("─────────────────────");
          Console.WriteLine ("Esa opcion no esta dentro del menu");
            break;
   
           
           
            
           
           
          
     
         


          }
          Console.WriteLine();
          Console.WriteLine ("¿Quiere salir? (S/N)");
          salida= Console.ReadLine();
        }while (salida=="n" || salida=="N");
        Console.WriteLine ("El programa ha finalizado (de enter si quiere borrar la pantalla)");
        Console.ReadKey();
        Console.Clear();
        Console.WriteLine ("─────────────────────"); 
        Console.WriteLine ("Gracias por su tiempo");
        Console.WriteLine ("─────────────────────"); 
        }
    }
} 