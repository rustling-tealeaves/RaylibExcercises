using System.Numerics;
using Raylib_cs;

namespace Screensaver
{
    internal class Screensaver
    {
        static void Main(string[] args)
        {
            Raylib.InitWindow(800, 800, "Thine Fancy Application for Sparing Monitors");
            Raylib.SetTargetFPS(30);

            // Declaring variables for the three different corners of the triangle
            // Also defining their locations
            Vector2 cornerA = new(Raylib.GetScreenWidth()/2, 40);
            Vector2 cornerB = new(40, Raylib.GetScreenHeight()/2);
            Vector2 cornerC = new(Raylib.GetScreenWidth() - 40, (float)(Raylib.GetScreenHeight() * 0.75));

            // Declaring a speed variable
            float speed = 20;
            // Declaring variables for the directions of the three points
            // Also defining the directions
            Vector2 dirA = new(1, 1);
            Vector2 dirB = new(1, -1);
            Vector2 dirC = new(-1, 1);

            while (Raylib.WindowShouldClose() == false)
            {
                Raylib.BeginDrawing();

                // Clear the screen with black
                Raylib.ClearBackground(Color.Black);

                // Draw a green line from A to B
                Raylib.DrawLineV(cornerA, cornerB, Color.Green);
                // Draw a yellow line from B to C
                Raylib.DrawLineV(cornerB, cornerC, Color.Yellow);
                // Draw a light blue line from C to A
                Raylib.DrawLineV(cornerC, cornerA, Color.SkyBlue);

                // Moving cornerA
                cornerA = cornerA + dirA * speed * Raylib.GetFrameTime();
                // and making sure it doesn't escape
                // Moving cornerB
                cornerB = cornerB + dirB * speed * Raylib.GetFrameTime();
                // Moving cornerC
                cornerC = cornerC + dirC * speed * Raylib.GetFrameTime();

                Raylib.EndDrawing();
            }
            Raylib.CloseWindow();
        }
    }
}
