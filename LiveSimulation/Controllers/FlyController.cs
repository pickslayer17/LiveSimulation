using LiveSimulation.BaseModels;

namespace LiveSimulation.Controllers;

public class FlyController : BaseController
{
    public FlyController(GameObject gameObject) : base(gameObject)
    {
    }

    public override void Update()
    {
        // Implement fly behavior here, e.g., random movement, seeking food, etc.
    }
}
