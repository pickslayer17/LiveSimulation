using LiveSimulation.BaseModels;

namespace LiveSimulation.BaseModels;

public class World
{
    private Grid _grid;
    
    public World(Grid grid)
    {
        _grid = grid;
    }

    public void AddGameObject(GameObject gameObject)
    {
        _grid.LinkGameObject(gameObject);
    }
}
