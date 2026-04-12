using System;

namespace LiveSimulation.BaseModels;

public class Grid
{
    public readonly int GridPixelSizeX; 
    public readonly int GridPixelSizeY;
    public readonly int CellSideSize;
    public int CellsX { get; private set; }
    public int CellsY { get; private set; }

    private GridCell[,] Cells { get; set; }

    public Grid(int gridPixelSizeX, int gridPixelSizeY, int cellSideSize)
    {
        GridPixelSizeX = gridPixelSizeX;
        GridPixelSizeY = gridPixelSizeY;
        CellSideSize = cellSideSize;
    }

    public void InitializeCells()
    {
        CellsX = (int)(GridPixelSizeX / CellSideSize);
        int restX = GridPixelSizeX % CellSideSize;
        if (restX > 0)
            CellsX++;

        CellsY = (int)(GridPixelSizeY / CellSideSize);
        int restY = GridPixelSizeY % CellSideSize;
        if (restY > 0)
            CellsY++;

        Cells = new GridCell[CellsX, CellsY];
        for (int x = 0; x < CellsX; x++)
        {
            for (int y = 0; y < CellsY; y++)
            {
                var cellX = x * CellSideSize;
                var cellY = y * CellSideSize;
                var cellXSideSize = CellSideSize;
                var cellYSideSize = CellSideSize;

                if (x == CellsX - 1 && restX > 0)
                    cellXSideSize = restX;

                if (y == CellsY - 1 && restY > 0)
                    cellYSideSize = restY;

                Cells[x, y] = new GridCell(x * CellSideSize, y * CellSideSize, cellXSideSize, cellYSideSize);
            }
        }
    }

    public GridCell FindCell(double x, double y)
    {
        int cellX = (int)(x / CellSideSize);
        int cellY = (int)(y / CellSideSize);

        return Cells[cellX, cellY];
    }

    internal bool LinkGameObject(GameObject gameObject)
    {
        var gameObjectX = gameObject.X;
        var gameObjectY = gameObject.Y;
        var cell = FindCell(gameObjectX, gameObjectY);

        return cell.AddGameObject(gameObject);
    }
}
