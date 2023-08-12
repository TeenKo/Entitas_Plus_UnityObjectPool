using Entitas;
using Entitas.CodeGeneration.Attributes;

namespace _Core_.GameManager.Components
{
    [Game, Cleanup(CleanupMode.DestroyEntity)]
    public class SpawnCarComponent : IComponent
    {
        
    }
}