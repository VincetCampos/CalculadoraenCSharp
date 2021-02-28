using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculadora_en_C_
{
    class Program
    {
        static int selec;
        static double valor1;
        static double valor2;
        static double suma;
        static double resta;
        static double multipli;
        static double division;
        static double residuo;

        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a la calculadora");
            do{
                Console.WriteLine("Elija una de las siguientes opciones: ");
                Console.WriteLine("1. Suma");
                Console.WriteLine("2. Resta");
                Console.WriteLine("3. Multiplicación");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Encontrar el Residuo");
                Console.WriteLine("6. Salir");
                selec = Int32.Parse(Console.ReadLine());
                if(selec == 6){
                    Console.WriteLine("Hasta pronto");
                }
                switch(selec)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Se a elegido la opcion de suma");
                        Console.WriteLine();
                        colecciondatos();
                        suma = valor1 + valor2;
                        Console.WriteLine("El valor de la suma es de: " + suma);
                        Console.WriteLine("Presione enter para continuar");
                        Console.ReadLine();
                        break;
                
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Se a elegido la opcion de resta");
                        Console.WriteLine();
                        colecciondatos();
                        resta = valor1 - valor2;
                        Console.WriteLine("El valor de la resta es de: " + resta);
                        Console.WriteLine("Presione enter para continuar");
                        Console.ReadLine();
                        break;
                     case 3:
                        Console.Clear();
                        Console.WriteLine("Se a elegido la opcion de multiplicacion");
                        Console.WriteLine();
                        colecciondatos();
                        multipli = valor1 * valor2;
                        Console.WriteLine("El valor de la resta es de: " + multipli);
                        Console.WriteLine("Presione enter para continuar");
                        Console.ReadLine();
                        break;
                     case 4:
                        Console.Clear();
                        Console.WriteLine("Se a elegido la opcion de encontrar el Residuo");
                        Console.WriteLine();
                        colecciondatos();
                        if(valor2 == 0){
                            while(valor2 == 0){
                                Console.WriteLine("**ERROR**");
                                Console.WriteLine("Porfavor elegir un numero que no sea el cero");
                                valor2 = double.Parse(Console.ReadLine());
                            }
                        }
                        division = valor1 / valor2;
                        Console.WriteLine("El valor de la division es de: " + division);
                        Console.WriteLine("Presione enter para continuar");
                        Console.ReadLine();
                        break;
                        case 5:
                            Console.Clear();
                            Console.WriteLine("Se a elegido la opcion de encontrar el residuo");
                            Console.WriteLine();
                            colecciondatos();
                            if(valor2 == 0){
                                while(valor2 == 0){
                                    Console.WriteLine("Porfavor elegir un numero que no sea el cero");
                                    valor2 = double.Parse(Console.ReadLine());
                                }
                            }
                            residuo = valor1 % valor2;
                            Console.WriteLine("El residuo de la division es de: " + residuo);
                            Console.WriteLine("Presione enter para continuar");
                            Console.ReadLine();
                            break;
                    }
            } while(selec < 6);

           
        }
          static void colecciondatos(){
              Console.WriteLine("Ingrese el primer valor");
              valor1 = double.Parse(Console.ReadLine());
              Console.WriteLine("Ingrese el segundo valor");
              valor2 = double.Parse(Console.ReadLine());

    }
    }
}
