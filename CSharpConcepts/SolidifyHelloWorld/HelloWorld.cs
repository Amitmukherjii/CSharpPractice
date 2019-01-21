using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpConcepts.SolidifyHelloWorld
{
    public class HelloWorld
    {
        private readonly IReadMessage _readMessage;
        private readonly IWriteMessage _writeMessage;
        public HelloWorld(IWriteMessage writeMessage, IReadMessage readMessage)
        {
            _readMessage = readMessage;
            _writeMessage = writeMessage;
        }

        public void DisplayMessageToWorld()
        {
            string message = _readMessage.ReadInputMessage();
            _writeMessage.DisplayMessage(message);
        }
    }
}
