using System.Numerics;
using Raylib_cs;

namespace Pong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Paikat pelaajille 2kpl ja pallolle
            Vector2 player1; // Vasen reuna
            Vector2 player2; // Oikea reuna
            Vector2 ball; // Keskelle
            Vector2 playerSize; // Molemmille sama koko

            Raylib.InitWindow(800, 600, "PONK!");
            Raylib.SetTargetFPS(60);
            while(Raylib.WindowShouldClose() == false)
            {
                Raylib.BeginDrawing();
                Raylib.EndDrawing();
            }
            Raylib.CloseWindow();
        }
    }
}
