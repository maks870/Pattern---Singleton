using System;

namespace Pattern___Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Initializer gameInitializer = Initializer.getInstance();
            gameInitializer.Initialize();
            gameInitializer.Initialize();
        }
    }
}
