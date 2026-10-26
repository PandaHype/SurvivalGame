public class Player
{
    private readonly Grid grid;

    public int GridX;
    public int GridY;

    public Vector2 Pos { get; private set; }

    public Player(Grid grid, int x = 0, int y = 0)
    {
        this.grid = grid;
        GridX = x;
        GridY = y;

        Pos = new Vector2(x, y);
    }

    public void update()
    {
        Vector2 NextPos = Pos;

        if (Raylib.IsKeyPressed(KeyboardKey.W))
            NextPos.Y--;

        if (Raylib.IsKeyPressed(KeyboardKey.S))
            NextPos.Y++;

        if (Raylib.IsKeyPressed(KeyboardKey.A))
            NextPos.X--;

        if (Raylib.IsKeyPressed(KeyboardKey.D))
            NextPos.X++;

        if (
            NextPos.X < 0 || NextPos.X >= grid.Width ||
            NextPos.Y < 0 || NextPos.Y >= grid.Height) 
            return;
        
        Pos = NextPos;
        GridX = (int)NextPos.X;
        GridY = (int)NextPos.Y;
    }
}