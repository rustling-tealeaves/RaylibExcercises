using Raylib_cs;

namespace Pong
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
