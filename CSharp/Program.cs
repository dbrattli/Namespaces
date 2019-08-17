using Foo;
using Foo.Bar;

namespace CS
{
    class Program
    {
        static void Main(string[] args)
        {
            Say.hello("from C#!");
            // Bar.Say.hello("from C#!"); // Does not work!
            Foo.Bar.Say.hello("from C#!");
        }
    }
}
