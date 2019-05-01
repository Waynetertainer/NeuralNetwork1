using System;

namespace NeuralNetwork_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Network network = new Network(new[] { 2, 3, 4, 5 });
            Console.ReadKey();
        }
    }
}
