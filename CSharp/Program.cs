using Foo;

namespace CS
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bar.Say.hello("from C#!");
            Foo.Bar.Say.hello("from C#!"); // Why must I fully qualify?
        }
    }
}
