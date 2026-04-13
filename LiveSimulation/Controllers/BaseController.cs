using LiveSimulation.BaseModels;

namespace LiveSimulation.Controllers;

public class BaseController
{
    public GameObject GameObject { get; set; }

    public BaseController(GameObject gameObject)
    {
        GameObject = gameObject;
    }

    public virtual void Update()
    {
    }
}
