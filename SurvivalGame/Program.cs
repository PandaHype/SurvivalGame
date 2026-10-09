using System.Numerics;
using Raylib_cs;

Raylib.InitWindow(800, 600, "Tets");

Raylib.SetTargetFPS(60);

Vector2 pos = Raylib.GetScreenCenter();

while (!Raylib.WindowShouldClose())
{
    pos.X++;

    Raylib.BeginDrawing();
    Raylib.ClearBackground(Color.Beige);

    Raylib.DrawCircleV(pos, 30, Color.Green);
    Raylib.EndDrawing();
}