using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace TiposDatos1
{
    internal class Program
    {
        struct Auto
        {
            public string marca;
            public int modelo;
            public string tipo;
        }
        static void Main(string[] args)
        {
            // tipos de datos
            int num1, num2;  // variable enteras
            long larga = 588;
            byte b = 125;
            short s = 255;
            float flotante = 3.14f;
            double doble = 25.568899d;
            decimal deci = 2555.36m;
            Boolean boleano = false;
            char caracter = 'a';
            string cadena = "Hoy es lunes";


            // var y dynamic
            var variable = 20;

            dynamic dinamico = 20;
            dinamico = "esto es C#";
            dinamico = true;
            dinamico = 'b';
            dinamico = 2.14f;

            Auto carro;

            carro.marca = "BMW";
            carro.tipo = "Sedan";
            carro.modelo = 2024;

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Marca:  " + " Tipo:  " + " Modelo:  ");
            Console.WriteLine("----------------------------------");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(carro.marca + "   " + carro.tipo + "   " + carro.modelo); // concatenacion
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Marca:{0}  Tipo:{1} Modelo:{2}", carro.marca, carro.tipo, carro.modelo); // referencia
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"Carro:{carro.marca}\nTipo:{carro.tipo}\nModelo{carro.modelo}"); //interpolacion

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("-----------------------------------");
            Console.ForegroundColor = ConsoleColor.White;
            num1 = 20; num2 = 5;

            //Console.WriteLine($"El resultado de la suma es: {num1 + num2}");
            //Console.WriteLine("La multiplicacio es: {0}", num1 * num2);
            //Console.WriteLine("Digite un numero");
            //num1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Digite un numero");
            //num2 = Convert.ToInt32(Console.ReadLine());
            int resultado = num1 - num2;
            int resultado2 = num1 / num2;

            Console.WriteLine(flotante + doble);

            float resultado3 = flotante + float.Parse(doble.ToString());

            Console.WriteLine($"La resta es de {resultado}");
            Console.WriteLine($"La division es de {resultado2}");

            int[] notas = new int[] {100,80,90,78,569,68};
            //                        0  1   2  3

            string[] estudiantes = new string[4];
            estudiantes[0] = "lUIS";
            estudiantes[1] = "Maria";
            estudiantes[2] = "Karla";
            estudiantes[3] = "Carlos";
            // 0 1 2 3 4     false
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(notas[i]);
            }

            for (int i = 0; i < notas.Length; i++)
            {
                Console.WriteLine(notas[i]);
            }

            for (int i = 0; i < notas.Length; i++)
            {
                Console.WriteLine(notas[i]);
            }

            for (int i = 0; i < notas.Length; i++)
            {
                Console.WriteLine(notas[i]);
            }





            Console.ReadLine();
        }
    }

}

