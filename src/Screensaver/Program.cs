using System.Numerics;
using Raylib_cs;

namespace Pong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaring variables for the three different corners of the triangle
            Vector2 cornerA;
            Vector2 cornerB;
            Vector2 cornerC;

            Raylib.InitWindow(800, 800, "Thine Fancy Application for Sparing Monitors");
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
