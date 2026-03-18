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
            float speed = 50;
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
                if (cornerA.X < 0 || cornerA.X > Raylib.GetScreenWidth())
                {
                    dirA.X = dirA.X * -1.0f;
                }
                if (cornerA.Y < 0 || cornerA.Y > Raylib.GetScreenHeight())
                {
                    dirA.Y = dirA.Y * -1.0f;
                }

                // Moving cornerB
                cornerB = cornerB + dirB * speed * Raylib.GetFrameTime();
                // and making sure it doesn't escape
                if (cornerB.X < 0 || cornerB.X > Raylib.GetScreenWidth())
                {
                    dirB.X = dirB.X * -1.0f;
                }
                if (cornerB.Y < 0 || cornerB.Y > Raylib.GetScreenHeight())
                {
                    dirB.Y = dirB.Y * -1.0f;
                }

                // Moving cornerC
                cornerC = cornerC + dirC * speed * Raylib.GetFrameTime();
                // and making sure it doesn't escape
                if (cornerC.X < 0 || cornerC.X > Raylib.GetScreenWidth())
                {
                    dirC.X = dirC.X * -1.0f;
                }
                if (cornerC.Y < 0 || cornerC.Y > Raylib.GetScreenHeight())
                {
                    dirC.Y = dirC.Y * -1.0f;
                }

                Raylib.EndDrawing();
            }
            Raylib.CloseWindow();
        }
    }
}
