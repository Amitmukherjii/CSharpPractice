using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpConcepts.SolidifyHelloWorld
{
    class ReadMessage : IReadMessage
    {
        public string ReadInputMessage()
        {
            Console.Write("Enter message for the world: ");
            return Console.ReadLine();
        }
    }
}
