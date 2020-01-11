using System;

namespace ExemploStruct
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarando tipo de valor
            Point p;

            p.X = 10;
            p.Y = 20;

            Console.WriteLine(p);

            //Tipo de valor struct também aceita instancia
            p = new Point();
            Console.WriteLine(p);
        }
    }
}
