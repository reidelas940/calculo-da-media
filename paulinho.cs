using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paulinho
{
    class Program
    {
        static void Main(string[] args)
        {
            int opção;
            double resultado, numero1, numero2, altura;

            Console.WriteLine("escolha a operação");
            Console.WriteLine("1- Aréa Quadrilatero");
            Console.WriteLine("2- Aréa Trapésio");
            Console.WriteLine("3- Aréa Triangulo");

            opção = Convert.ToInt32(Console.ReadLine());
        

            switch (opção)
            {

                case 1:
                    Console.WriteLine("Insira a base maior");
                    numero1 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Insira a base menor");
                    numero2 = Convert.ToDouble(Console.ReadLine());

                    resultado = numero1 * numero2 / 2;

                    Console.WriteLine(resultado);

                    break;

                case 2:
                    Console.WriteLine("Insira a base maior");
                    numero1 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Insira a base menor");
                    numero2 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Insira a altura");
                    altura = Convert.ToDouble(Console.ReadLine());

                    resultado = numero1 + numero2 * altura /2;

                    Console.WriteLine(resultado);

                    break;
                case 3:
                    Console.WriteLine("Insira a base");
                    numero1 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Insira a altura");
                    numero2 = Convert.ToDouble(Console.ReadLine());

                    resultado = numero1 * numero2 / 2;

                    Console.WriteLine(resultado);

                    break;
            }

            Console.ReadKey();
        }
    }
}
