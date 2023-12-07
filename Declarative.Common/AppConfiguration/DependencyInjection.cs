using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Declarative.Common.AppConfiguration
{
    internal class DependencyInjection
    {
        public void WriteMessage(string message)
        {
            Console.WriteLine($"MyDependency.WriteMessage called. Message: {message}");
        }
    }   
}
