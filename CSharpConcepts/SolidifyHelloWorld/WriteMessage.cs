using System;


namespace CSharpConcepts.SolidifyHelloWorld
{
    class WriteMessage : IWriteMessage
    {
        public void DisplayMessage(string displayText)
        {
            Console.WriteLine(displayText);
        }
    }
}
