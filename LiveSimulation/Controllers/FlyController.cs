using LiveSimulation.BaseModels;
using System.Diagnostics;

namespace LiveSimulation.Controllers;

public class FlyController : BaseController
{
    public FlyController(GameObject gameObject) : base(gameObject)
    {
    }

    public override void Update()
    {
        Debug.WriteLine($"Im a fly with coord {GameObject.X} and {GameObject.Y}");
    }
}
