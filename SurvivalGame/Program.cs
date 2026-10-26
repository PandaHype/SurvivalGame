global using Raylib_cs;
global using System.Numerics;

int w = 1280;
int h = 960;

Grid g = new(w, h);
Player p = new(g, 0, 0);

Raylib.InitWindow(w, h, "Tets");
Raylib.SetTargetFPS(60);

while (!Raylib.WindowShouldClose())
{
    Raylib.BeginDrawing();

    Raylib.ClearBackground(Color.Black);

    g.draw();
    g.DrawPlayer(p);
    p.update();

    Raylib.EndDrawing();
}