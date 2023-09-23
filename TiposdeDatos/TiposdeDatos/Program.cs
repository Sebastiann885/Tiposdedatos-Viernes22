using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TiposdeDatos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tipos De Datos

            int num1, num2; 
            
            byte b = 255;
            short s = 67;
            long largo = 9999999;
            float flotante = 3.14f; //permite 6 a  9 digitos despues de la coma
            double doble = 365.25555d;//Numeros mas grandes con mas decimales
            decimal deci = 366.56m;
            bool bolean = false;
            string cadena = "Hola mundo pla";
            char caracter = 'A';

            var variable = 20;
            variable = 30;

            dynamic dinamica = false;
            dinamica = 20;
            dinamica = "Hola mundo";
            dinamica = 'a';

            num1 = 20;
            num2 = 30;

            Console.WriteLine(num1);
            Console.WriteLine(num1*num2);
            Console.WriteLine("La division es: " + (num1 / num2));
            Console.WriteLine("La division es: {0}", num1/num2);
            //Pasar valores por referencia
            Console.WriteLine("La resta de {0}-{1} es: {2}", num1,num2,num1-num2);
            //Pasar valores por interpolacion
            Console.WriteLine($"La suma de {num1}+{num2} es: {num1+num2}");

            Console.WriteLine("Digite su nombre:");
            string nombre = Console.ReadLine();
            Console.WriteLine($"Gracias {nombre} desea hacer un prestamo?");
            Console.WriteLine("Digite un monto:");
            // Convertir el monto de string a flotante
            float monto = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite los meses:");
            // convertir los meses de string a intenger
            int mes = int.Parse(Console.ReadLine());
            float resultado = (monto / mes);
            Console.WriteLine($"Su cuota mensual es de {resultado}");
            Console.WriteLine($", Puedo hacer algo mas por usted {nombre}");


            Console.ReadLine();
        }
    }
}
