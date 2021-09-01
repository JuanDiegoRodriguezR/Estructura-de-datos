using System;

namespace C__proyecto
{
    class Ejercicio_6
    {
        static void Main(string[] args)
        {
        //Creado por: Juan Diego Rodriguez Riaño
        //Actividad semana1
        //Turno: Diurno
        // Problema 6: conversion de tiempo
            int fecha,swi=1, dias, minutos, horas, segundos, minutos2;
            Console.WriteLine (" ");
            Console.WriteLine ("Presentado por Juan Diego Rodriguez Riaño");
            Console.WriteLine (" ");
            Console.WriteLine ("***Problema 6: conversion del tiempo ");
            Console.WriteLine (" ");

            while(swi==1)
            {
            //se recoge el numero entero que designa el periodp de tiempo
            Console.WriteLine (" ");
            Console.WriteLine ("Para salir del programa oprima 0");
            Console.WriteLine ("Ingrese el numero del que quiere conocer el periodo de tiempo (en segundos): ");
            fecha= int.Parse (System.Console.ReadLine());
            Console.WriteLine (" ");


            if (fecha>=1)
            {
                //se hace la conversion de dias,minutos,horas y segundos.
                minutos= fecha/60;
                segundos= fecha%60;
                horas= minutos/60;
                minutos2= minutos%60;
                dias= horas/24;

                Console.WriteLine (" ");
                Console.WriteLine ("La cantidad ingresada en segundos son: {0}",segundos);
                Console.WriteLine ("La cantidad ingresada en horas son: {0} ", horas);
                Console.WriteLine ("La cantidad ingresada en minutos son: {0}",minutos2);
                Console.WriteLine ("La cantidad en dias son: {0}",dias);
                Console.WriteLine (" ");

            }

            //se cierra el ciclo while.

            if (fecha==0)
            {
                swi=0;
            }

            }
            Console.WriteLine (" ");
            Console.WriteLine ("Fin del programa, de enter para terminar");
            Console.ReadKey();





        }
    }
}