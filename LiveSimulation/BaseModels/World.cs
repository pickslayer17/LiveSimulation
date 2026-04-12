using System.Collections.Generic;

namespace LiveSimulation.BaseModels;

public class World
{
    private readonly List<GameObject> _gameObjects = new();
    public IReadOnlyList<GameObject> GameObjects => _gameObjects;
    private Grid _grid;

    public World(Grid grid)
    {
        _grid = grid;
    }

    public bool AddGameObject(GameObject gameObject, double xCoordinate, double yCoordinate)
    {
        if(_grid.LinkGameObject(gameObject, xCoordinate, yCoordinate))
        {
            _gameObjects.Add(gameObject);

            return true;
        }
        else
        {
            return false;
        }
    }
}
