using Raylib_cs;

namespace RaylibTesti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Raylib.InitWindow(800, 600, "Raylib");
            while(Raylib.WindowShouldClose() == false)
            {
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.SkyBlue);
                Raylib.DrawCircle(
                    Raylib.GetScreenWidth() / 2,
                    Raylib.GetScreenHeight() / 2,
                    1 + (float)Raylib.GetTime() * 4, 
                    Color.Violet);

                Raylib.DrawCircleV(
                    Raylib.GetScreenCenter(), 10,
                    Color.Pink);
                // Kaiken piirtämisen jälkeen
                Raylib.EndDrawing();
            }
            Raylib.CloseWindow();
        }
    }
}
