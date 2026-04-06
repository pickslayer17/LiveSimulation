using System;

namespace LiveSimulation.Models;

public abstract class GameObject
{
    public readonly string Id = Guid.NewGuid().ToString();
    public string Name { get; set; }
    public double X { get; set; }
    public double Y { get; set; }
    private Grid Grid { get; set; }

    public GameObject(double x, double y, Grid grid, string name = null)
    {
        Name = name;
        X = x;
        Y = y;
        Grid = grid;
        Grid.LinkGameObject(this);
    }
}

