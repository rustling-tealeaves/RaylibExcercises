using System.Numerics;
using Raylib_cs;

namespace Pong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Raylib.InitWindow(800, 600, "Thine Fancy Application for Sparing Monitors");
            Raylib.SetTargetFPS(30);
            while (Raylib.WindowShouldClose() == false)
            {
                Raylib.BeginDrawing();
                Raylib.EndDrawing();
            }
            Raylib.CloseWindow();
        }
    }
}
