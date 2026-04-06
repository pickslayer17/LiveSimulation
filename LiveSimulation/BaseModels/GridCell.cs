using System.Collections.Generic;

namespace LiveSimulation.Models;

public class GridCell
{
    public List<GameObject> GameObjects { get; set; }

    public GridCell()
    {
        GameObjects = new List<GameObject>();
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

    public void RemoveGameObject(GameObject gameObject)
    {
        GameObjects.Remove(gameObject);
    }
}
