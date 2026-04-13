using LiveSimulation.Controllers;
using System;

namespace LiveSimulation.Factories;

public class ControllerFactory
{
    public static BaseController CreateControllerForGameObject(BaseModels.GameObject gameObject)
    {
        return gameObject switch
        {
            GameModels.Fly => new FlyController(gameObject),
            _ => throw new NotImplementedException($"No controller implemented for {gameObject.GetType().Name}")
        };
    }
}
