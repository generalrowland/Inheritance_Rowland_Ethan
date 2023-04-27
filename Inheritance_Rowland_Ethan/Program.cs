using System;

namespace Inheritance_Rowland_Ethan
{
    class Program
    {
        static void Main(string[] args)
        {
            FPS myFPS = new FPS("E", "Zombcube");

            Console.WriteLine(myFPS.Desribe());
            myFPS.PlayGame();

            FPS csGo = newFPS("M", "CS:GO");
            Console.WriteLine(csGo.Describe());
            csGo.PlayGame();
        }
    }
}
