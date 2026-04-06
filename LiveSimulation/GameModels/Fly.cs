using LiveSimulation.Models;

namespace LiveSimulation.GameModels;

public class Fly : GameObject
{
    public Fly(double x, double y, Grid grid, string name = null) : base(x, y, grid, name)
    {
    }
}
