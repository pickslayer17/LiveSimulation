using System.Collections.Generic;

namespace LiveSimulation.Models;

public class GridCell
{
    public int XCoordinate { get; set; }
    public int YCoordinate { get; set; }
    public int XSideSize { get; set; }
    public int YSideSize { get; set; }
    public List<GameObject> GameObjects { get; set; }

    public GridCell(int xCoordinate, int yCoordinate, int xSideSize, int ySideSize)
    {
        GameObjects = new List<GameObject>();
        XCoordinate = xCoordinate;
        YCoordinate = yCoordinate;
        XSideSize = xSideSize;
        YSideSize = ySideSize;
    }

    public bool AddGameObject(GameObject gameObject)
    {
        if(GameObjects.Contains(gameObject))
        {
            return false; 
        }

        GameObjects.Add(gameObject);

        return true;
    }

    public bool RemoveGameObject(GameObject gameObject)
    {
        return GameObjects.Remove(gameObject);
    }
}
