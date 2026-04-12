using System;

namespace LiveSimulation.BaseModels;

public abstract class GameObject
{
    public readonly string Id = Guid.NewGuid().ToString();
    public string Name { get; set; }
    public double X { get; internal set; }
    public double Y { get; internal set; }
    private GridCell _cell;

    public GameObject(string name = null)
    {
        Name = name;
    }

    internal void LinkToCell(GridCell cell)
    {
        _cell = cell;
    }
}

