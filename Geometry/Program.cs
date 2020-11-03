using System;

namespace Geometry
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa para Calcular el area de un triangulo \n");

            Console.WriteLine(" Cuantos cemtimetros mide la base de su triangulo");
           decimal Base =Convert.ToDecimal (Console.ReadLine());

            Console.WriteLine("Cuantos cemtimetros mide la altura de su triangulo ");
            decimal altura = Convert.ToDecimal(Console.ReadLine());

            var area_triangulo = (Base * altura) / 2;

            if (Base == altura)
            {
                Console.WriteLine("Su triangulo es equilatero y el area mide " + area_triangulo);
            }
            else
            {
                Console.WriteLine("Su triangulo es Isosceles y el area mide " + area_triangulo + "cm");
            }

            Console.ReadKey();
        }
    }
}
