using Foo;
using Foo.Bar;

namespace CS
{
    class Program
    {
        static void Main(string[] args)
        {
            Say.hello("from C#!");
            // Bar.Say.hello("from C#!"); // The name 'Bar' does not exist in the current context!
            Foo.Bar.Say.hello("from C#!");
        }
    }
}
