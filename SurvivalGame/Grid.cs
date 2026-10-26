public class Grid
{
    public int Size { get; } = 48;
    public int Width { get; }
    public int Height { get; }

    private Vector2 offset;

    public Grid(int w, int h, int width = 16, int height = 16)
    {
        Width = width;
        Height = height;

        offset = new Vector2(
        w / 2 - Size * Width / 2,
        h / 2 - Size * Height / 2
    );
    }

    public Vector2 GridToWorld(int x, int y)
    {
        return new Vector2(x * Size, y * Size) + offset;
    }

    public void DrawPlayer(Player p)
    {
        Vector2 pos = GridToWorld(p.GridX, p.GridY);

        Raylib.DrawRectangleV(
            pos + new Vector2(0, 1),          // Draw player 1 pixel down to center its rect inside the grid tiles
            new Vector2(48 - 1, 48 - 1),      // Make the player's rect be 1 pixel smaller on each side so it can fit inside of the grid tiles
            Color.Blue
        );
    }

    public void draw()
    {
        for (int x = 0; x <= Width; x++)
        {

            Raylib.DrawLineEx(
                new Vector2(x * Size, 0) + offset,
                new Vector2(x * Size, Width * Size) + offset,
                1, Color.White
            );

            for (int y = 0; y <= Height; y++)
            {
                Raylib.DrawLineEx(
                new Vector2(0, y * Size) + offset,
                new Vector2(Height * Size, y * Size) + offset,
                1, Color.White
                );
            }
        }
    }
}
