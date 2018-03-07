using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    class Program
    {
        static void Main(string[] args){
            Console.Clear();
            Figura ofig = null; // este objeto no fue instanciado todavia
            //Dentro del while->switch, se instanciara en Circulo, Cuadrado, segun la opcion
            //que se haya elegido.

            while (true) {

                Console.Write("\nSeleccione una opcion: \n");
                Console.WriteLine("0-Salir");
                Console.WriteLine("1-Circulo");
                Console.WriteLine("2-Triangulo");
                Console.WriteLine("3-Cuadrado");
                Console.WriteLine("4-Rectangulo\n");
                Console.Write("Opcion: ");

                //string opcion = Console.ReadKey().ToString(); //Lee hasta la primera letra, pero readKey es char, lo casteo a string
                string opcion = Console.ReadLine().ToString(); //Otra alternativa
                //Si uso con Key, el if de abajo no va a funcionar
                 int output;
                 if (int.TryParse(opcion, out output))
                 {
                     float output2;

                     if (output == 0)
                         break;
                     else {
                         switch (output)
                         {
                             case 1: Console.Write("\nIngrese el radio: ");
                                     while (true) { 
                                     opcion = Console.ReadLine().ToString();
                               
                                        if (float.TryParse(opcion, out output2))
                                        {
                                            //Circulo circ = new Circulo(output2);
                                            ofig = new Circulo(output2);
                                            break;
                                        }
                                        else
                                            Console.Write("Ingrese nuevamente el radio: ");
                                      }
                                      break;

                             case 2: Console.Write("\nIngrese la base: ");
                                      while (true){
                                          opcion = Console.ReadLine().ToString();
                                          if (float.TryParse(opcion, out output2)){
                                              float baseaux = output2;
                                              Console.Write("\nIngrese la altura: ");
                                              while (true) { 
                                                opcion = Console.ReadLine().ToString();
                                                if (float.TryParse(opcion, out output2))
                                                {
                                                    Triangulo trian = new Triangulo(baseaux, output2);
                       
                                                    break;
                                                }
                                                else
                                                    Console.Write("\nIngrese nuevamente la altura: ");
                                              }
                                              break;
                                          }
                                          else
                                              Console.Write("Ingrese nuevamente el radio: ");
        
                                      }
                                    break;
                             case 3: Console.Write("\nIngrese el lado: ");
                                    while (true) {
                                        opcion = Console.ReadLine().ToString();
                                        if (float.TryParse(opcion, out output2))
                                        {
                                            //Cuadrado cuad = new Cuadrado(output2);
                                            ofig = new Cuadrado(output2);
                                            break;
                                        }
                                        else
                                            Console.Write("\nIngrese nuevamente el lado: ");  
                                    }
                                    break;
                             case 4: Console.Write("\nIngrese el lado A: ");
                                    while (true) {
                                        opcion = Console.ReadLine().ToString();
                                        if (float.TryParse(opcion, out output2))
                                        {
                                            Console.Write("\nIngrese el lado B: ");
                                            float auxLadoA = output2;
                                            while (true)
                                            {
                                                if (float.TryParse(opcion, out output2))
                                                {
                                                    break;
                                                }
                                                else
                                                    Console.Write("Ingrese nuevamente ladoB: ");
                                            }
                                            break;
                                        }
                                        else
                                            Console.Write("Ingrese nuevamente ladoA: ");
                                    
                                    }
                                    break;       
                         }

                         Console.WriteLine("\n{0} es el Area de la figura\n", ofig.calcularArea());
                         
                     }
                         

                 }
                 else //Cuando no lo puede parsear
                     Console.WriteLine("\nIngrese la opcion correcta");
                    
                 
                 
                //Intenta parsear opcion, si lo parsea bien, (convertirlo a int)
                //el resultado lo devuelve en output, y devuelve true, de lo contrario false
            }
            
            //Console.Read();
        }
    }
} //El OUT es para indicar que es una variable de salida

//No hay pagina de inicio en aplicacion de escritorio, es obligatorio un Main.
//0- Agregar elemento -> "Clase" Circulo, Cuadrado... etc.
//1- Hago que todas las clases (Circulo, Cuadrado, etc.) hereden de Figura
//2- Metodo comun que tiene que tener para se clase base (Figura): Area y perimetro. Usamos area.
//3- Declaro propiedades (atributos) para cada figura segun corresponda: radio para Circulo, etc.
//4- Redefino en cada clase que heredo de Figura el metodo calcularArea() segun corresponda.
//4.1- En este caso puedo guardar en el atributo Area que fue declarada en Figura, antes de hace return.
//luego para obtener el area (el valor del atributo) hago un GET en Figura.
//Si quiero acceder al atributo del Padre, o uso GET, o cambio el modificador de Area, de public a protected.

/////////////////////////////////////////////////////////////////////////////////
/*Puedo castear objetos: De Figura a Circulo: -NO-
                         de Circulo a Figura: -SI-

"SI ES, LO PUEDO CASTEAR", Circulo es Figura, entonces lo puedo castear.
 *                         Figura no es Circulo, entonces no lo puedo castear.

 * Figura hereda de Object, que tiene algunos atributos como toString, entre otros.
 * Es la clase base de todas, todas heredan de Object
*/
/////////////////////////////////////////////////////////////////////////////////
//Exception: clase de la que heredan todas las exceptions, es la base

///////////////////////////////////////////////////////////////////////////////////
//Uso de abstract en lugar de virtual: Cuando defino un metodo abstracto, toda la clase tiene
//que ser abstracta, y el metodo no tiene que tener nada dentro
//Abstract me obliga a redefinir en las clases derivadas, en cambio virtual no obliga.
//POLIMORFISMO: Un objeto en tiempo de ejecucion se transforma en otro, con virtual o con abstract.
