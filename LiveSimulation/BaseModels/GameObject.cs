using System;

namespace LiveSimulation.BaseModels;

public abstract class GameObject
{
    public readonly string Id = Guid.NewGuid().ToString();
    public string Name { get; set; }
    public double X { get; set; }
    public double Y { get; set; }

    public GameObject(double x, double y, string name = null)
    {
        Name = name;
        X = x;
        Y = y;
    }
}

