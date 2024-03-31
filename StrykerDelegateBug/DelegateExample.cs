using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrykerDelegateBug
{
    public class DelegateExample
    {
        delegate void Callback(string message);

        public static void OutputString(string input)
        {
            var example = delegate(string name)
            {
                Console.WriteLine($"Hello {name}");
            };

            example.Invoke(input);
        }
    }
}
