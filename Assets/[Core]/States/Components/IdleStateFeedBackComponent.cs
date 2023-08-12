using Entitas;
using Entitas.CodeGeneration.Attributes;

namespace _Core_.States.Components
{
    [Game, Cleanup(CleanupMode.RemoveComponent), Event(EventTarget.Self)]
    public sealed class IdleStateFeedBackComponent : IComponent
    {
        
    }
}