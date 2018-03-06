using System;

namespace human
{
    class Program
    {
        static void Main(string[] args)
        {
            Human danny = new Human("Danny");
            Human robert = new Human("Robert");
            danny.Attack(robert);
        }
    }
}
