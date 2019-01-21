using CSharpConcepts.SolidifyHelloWorld;
using System;

namespace CSharpConcepts
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            IWriteMessage message = new WriteMessage();
            IReadMessage input = new ReadMessage();
            HelloWorld helloWorld = new HelloWorld(message, input);
            helloWorld.DisplayMessageToWorld();

            Console.ReadKey();
        }
    }
}