using Listening_assistant.Cluster;
using System;
using System.Text;

namespace Listening_assistant
{
    class Program
    {
        static void Main(string[] args)
        {

            EscuchaSQLSERVER escucha1 = new EscuchaSQLSERVER();
            escucha1.Start();
        }
    }
}
