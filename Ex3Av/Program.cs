using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3Av
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*3 – Criar um programa para calcular e mostrar a área de 3 figuras geométricas diferentes, não vale quadrado e nem retângulo.
            Observação: as figuras são de escolha livre, dá um Google se não lembrar como faz o cálculo de alguma delas.
            Requisitos: Deve ser apresentada uma lista para o usuário com o nome das 3 figuras que ele pode escolher para calcular.
            Deve-se utilizar Switch Case.*/
            int figuras;
            Console.WriteLine("Escolha a figura: \n[1] Círculo\n[2] Losango\n[3] Trapézio");
            figuras = Convert.ToInt16(Console.ReadLine());
            switch (figuras)
            {
                case 1:
                    double raio;
                    Console.WriteLine("Raio: ");
                    raio = double.Parse(Console.ReadLine());
                    Console.WriteLine("A área do círculo é (aproximadamente)" + (raio * raio) * 3.14);
                    break;
                case 2:
                    double dMa, dMe;
                    Console.WriteLine("Diagonal maior: ");
                    dMa = double.Parse(Console.ReadLine());
                    Console.WriteLine("Diagonal menor: ");
                    dMe = double.Parse(Console.ReadLine());
                    Console.WriteLine("A área do losango é: " + dMa * dMe / 2);
                    break;
                case 3:
                    double bMa, bMe, alt;
                    Console.WriteLine("Base maior: ");
                    bMa = double.Parse(Console.ReadLine());
                    Console.WriteLine("Base menor: ");
                    bMe = double.Parse(Console.ReadLine());
                    Console.WriteLine("Altura: ");
                    alt = double.Parse(Console.ReadLine());
                    Console.WriteLine("A área do trapézio é: " + (bMa + bMe) * alt / 2);
                    break;
            }
            Console.ReadKey();
        }
    }
}
