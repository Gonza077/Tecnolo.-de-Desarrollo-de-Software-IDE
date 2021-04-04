using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LabSintaxis2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Ejercicio 1
            /*
            int num1, num2;
            System.Console.WriteLine("Ingrese el numero 1");
            num1 = Int32.Parse(System.Console.ReadLine());
            System.Console.WriteLine("Ingrese el numero 2");
            num2 = Int32.Parse(System.Console.ReadLine());
            System.Console.Clear();
            System.Console.WriteLine("El resultado de la suma de " + num1 + " y " + num2 + " es " + (num1+num2));
            System.Console.ReadKey();
            */
            #endregion

            #region Ejercicio 2
            /*
            int año;
            System.Console.WriteLine("Ingrese el numero del año");
            año = Int32.Parse(System.Console.ReadLine());
            if ( año % 4 == 0 && año % 100 != 0 )
                { 
                System.Console.WriteLine("El año " + año + " es un año bisiesto");
                System.Console.ReadKey();
                }
            else if (año% 100 == 0 && año % 400 == 0)
                    { 
                    System.Console.WriteLine("El año " + año + " es un año bisiesto");
                    System.Console.ReadKey();
                    }
                else 
                    {
                    System.Console.WriteLine("El año " + año + " no es un año bisiesto");
                    System.Console.ReadKey();
                    }   
            */
            #endregion

            #region Ejercicio 3
            /*
            int cantNumeros = 0,proxNum=0,sumador=0;
            var numFibonacci = new List<int>();
            numFibonacci.Add(1);
            numFibonacci.Add(1);
            Console.WriteLine("¿Cuantos numeros de la sumatoria desea sumar?");
            cantNumeros = Int32.Parse(Console.ReadLine());   
            Console.Clear();
            Console.WriteLine("Los numeros de la serie son");
            for (int k=1; k<cantNumeros;k++) 
                {
                proxNum = numFibonacci[k-1] + numFibonacci[k];
                numFibonacci.Add(proxNum);               
                }

            for (int k = 0; k < numFibonacci.Count()-1; k++)
                {
                Console.Write(numFibonacci[k]+",");          
                sumador = numFibonacci[k] + sumador;
                }
            Console.WriteLine("\nLa sumatoria de los numeros de la serie de Fibonacci es = "+ sumador); 
            Console.ReadKey();
            */
            #endregion

            #region Ejercicio 4   
            /*
            System.Console.WriteLine("Los numero pares entre 1 y 100 son :");
            for (int i = 1; i <= 100; i++)
                {
                    if (i % 2 == 0)
                        {
                        System.Console.Write(i+", ");                        
                        }          
                }
            System.Console.ReadKey();
            */
            #endregion

            #region Ejercicio 5
            /*
            string mes;
            string[] mesDelAño;
            mesDelAño=new string[]{"ENERO","FEBRERO","MARZO","ABRIL","MAYO","JUNIO","JULIO","AGOSTO","SEPTIEMBRE","OCTUBRE","NOVIEMBRE","DICIEMBRE"};
            System.Console.WriteLine("Ingrese nombre del mes");
            mes = System.Console.ReadLine();
            mes = mes.ToUpper();
            if (mesDelAño.Contains(mes)==true)
            {
                for (int i = 0; i < mesDelAño.Length; i++)
                {
                    if (mesDelAño[i]==mes)
                        {
                        System.Console.WriteLine("El mes de " + mes +" tiene como numero el " + (i+1));
                        }              
                }
            }
            else 
            {
                System.Console.WriteLine("El mes ingresado no es correcto");
            }               
            System.Console.ReadKey();
            */
            #endregion

            #region Ejercicio 6
            /*           
            int numEntero,unidad,decena,centena,mil;
            System.Console.WriteLine("Ingrese un numero entero");
            numEntero = Int32.Parse(System.Console.ReadLine());
            unidad = numEntero % 10; numEntero = numEntero / 10;
            decena = numEntero % 10; numEntero = numEntero / 10;
            centena = numEntero % 10; numEntero = numEntero / 10;
            mil = numEntero % 10; numEntero = numEntero / 10;
            System.Console.WriteLine("El numero ingresado trnasformado a numero romano es :");
            switch (mil) 
                {
                case 1: { System.Console.Write("M"); break; }
                case 2: { System.Console.Write("MM"); break; }
                case 3: { System.Console.Write("MMM"); break; }
                }
            switch (centena)
            {
                case 1: { System.Console.Write("C"); break; }
                case 2: { System.Console.Write("CC"); break; }
                case 3: { System.Console.Write("CCC"); break; }
                case 4: { System.Console.Write("CD"); break; }
                case 5: { System.Console.Write("D"); break; }
                case 6: { System.Console.Write("DC"); break; }
                case 7: { System.Console.Write("DCC"); break; }
                case 8: { System.Console.Write("DCCC"); break; }
                case 9: { System.Console.Write("CM"); break; }
            }
            switch (decena)
            {
                case 1: { System.Console.Write("X"); break; }
                case 2: { System.Console.Write("XX"); break; }
                case 3: { System.Console.Write("XXX"); break; }
                case 4: { System.Console.Write("XL"); break; }
                case 5: { System.Console.Write("L"); break; }
                case 6: { System.Console.Write("XL"); break; }
                case 7: { System.Console.Write("XLL"); break; }
                case 8: { System.Console.Write("XLLL"); break; }
                case 9: { System.Console.Write("XC"); break; }
            }
            switch (unidad)
            {
                case 1: { System.Console.Write("I"); break; }
                case 2: { System.Console.Write("II"); break; }
                case 3: { System.Console.Write("III"); break; }
                case 4: { System.Console.Write("IV"); break; }
                case 5: { System.Console.Write("V"); break; }
                case 6: { System.Console.Write("VI"); break; }
                case 7: { System.Console.Write("VII"); break; }
                case 8: { System.Console.Write("VIII"); break; }
                case 9: { System.Console.Write("IX"); break; }
            }
            System.Console.ReadKey();
            */
            #endregion

            #region Ejercicio 7
            /*
            int numN, cantDivisores, contador = 0;
            int[] numeroPrimos = new int[1000];
            System.Console.WriteLine("Ingrese el numero N de par ");
            numN = Convert.ToInt32(System.Console.ReadLine());
            Console.Clear();
            for (int j = 2; j < numN; j++)
            {
                cantDivisores = 0;
                for (int i = 1; i < j + 1; i++)
                {
                    if (j % i == 0)
                    {
                        cantDivisores++;
                    }
                }
                if (cantDivisores == 2)
                {
                    numeroPrimos[contador] = j;                                        
                    contador++;                    
                }               
            }                      
            Console.WriteLine("A continuacion se mostraran los numeros primos gemelos");
            for (int x = 1; x < contador - 1; x++)
            {
                if ((numeroPrimos[x + 1] - numeroPrimos[x]) == 2)
                {
                    Console.WriteLine (numeroPrimos[x + 1] + " y " + numeroPrimos[x] );
                }
            }
            Console.ReadKey();         
            */
            #endregion

            #region Ejercicio 8
            /*
            int intentos = 0;
            string password = "1234",clave;
            for ( ; intentos <= 4; intentos++)
            {
                if (intentos < 4)
                {
                    Console.WriteLine("Intento N°" + (intentos + 1));
                    Console.WriteLine("Ingrese la clave por favor");
                    clave = Console.ReadLine();
                    if (clave == password)
                    {
                        Console.WriteLine("Clave correcta");
                        Console.ReadKey();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Clave erronea");
                        Console.ReadKey();
                        Console.Clear();
                    }
                }
                else
                {
                    Console.WriteLine("Se supero el maximo de intentos");
                    Console.WriteLine("Pulse una tecla para salir");
                    Console.ReadKey();
                    break;
                }
            }
            */
            #endregion

            #region Ejercicio 9
            /*
            Console.WriteLine("Ingrese numero de filas: ");
            int cantFilas = Convert.ToInt32(Console.ReadLine());
            int linea = 1, ast = 1;
            StringBuilder figura = new StringBuilder(cantFilas);                         
            while ((linea - 1) < cantFilas) 
            {
                figura.Append(DibujaEsp(cantFilas - linea));
                figura.AppendLine(DibujaAst(ast));
                linea += 1;
                ast += 2;
            }
            Console.WriteLine(figura);
            Console.ReadKey();
            */
        }
        public static string DibujaEsp(int linea) //Dibuja espacios segun numero de linea
            {
              if (linea > 0)
                    return " " + DibujaEsp(linea - 1);
              else return null;
            }
        public static string DibujaAst(int asterisco) //Dibuja asteriscos segun numero de asteriscos
            {
                if (asterisco > 0)
               
                    return "*" + DibujaAst(asterisco - 1);
                
                else return null;
            }        
            #endregion     
    }
}
