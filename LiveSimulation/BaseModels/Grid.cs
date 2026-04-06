namespace LiveSimulation.Models;

public class Grid
{
    public int GridSize { get; private set; }
    public double CellSize { get; private set; } = 1.0;
    private GridCell[,] Cells { get; set; }
    private (double X, double Y) TotalSize => (GridSize * (int)CellSize, GridSize * (int)CellSize);

    public Grid(int gridSize)
    {
        GridSize = gridSize;
        Cells = new GridCell[gridSize, gridSize];
        InitializeCells();
    }

    public bool LinkGameObject(GameObject gameObject)
    {
        if (IsWithinBounds(gameObject.X, gameObject.Y))
        {
            var cell = Cells[(int)(gameObject.X / CellSize), (int)(gameObject.Y / CellSize)];

            return cell.AddGameObject(gameObject);
        }
        else
        {
            return false;
        }
    }

    private void InitializeCells()
    {
        for (int x = 0; x < GridSize; x++)
        {
            for (int y = 0; y < GridSize; y++)
            {
                Cells[x, y] = new GridCell();
            }
        }
    }

    private bool IsWithinBounds(double x, double y)
    {
        return x >= 0 && x < TotalSize.X && y >= 0 && y < TotalSize.Y;
    }
}
