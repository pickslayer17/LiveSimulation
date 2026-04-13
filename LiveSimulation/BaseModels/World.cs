using LiveSimulation.Controllers;
using LiveSimulation.Factories;
using System.Collections.Generic;

namespace LiveSimulation.BaseModels;

public class World
{
    private readonly List<GameObject> _gameObjects = new();
    private readonly List<BaseController> _controllers = new();
    public IReadOnlyList<GameObject> GameObjects => _gameObjects;
    public IReadOnlyList<BaseController> Controllers => _controllers;
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
            ControllerFactory.CreateControllerForGameObject(gameObject);
            _controllers.Add(ControllerFactory.CreateControllerForGameObject(gameObject));

            return true;
        }
        else
        {
            return false;
        }
    }

    public void Update()
    {
        foreach (var controller in _controllers)
        {
            controller.Update();
        }
    }
}
