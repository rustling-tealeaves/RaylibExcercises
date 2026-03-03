using System.Numerics;
using Raylib_cs;

namespace Screensaver
{
    internal class Screensaver
    {
        static void Main(string[] args)
        {
            // Declaring variables for the three different corners of the triangle
            // Also defining their locations
            Vector2 cornerA = new Vector2 (Raylib.GetScreenWidth()/2, 40);
            Vector2 cornerB = new Vector2 (40, Raylib.GetScreenHeight()/2);
            Vector2 cornerC = new Vector2(Raylib.GetScreenWidth() - 40, (float)(Raylib.GetScreenHeight() * 0.75));

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
