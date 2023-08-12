using Entitas;
using Entitas.CodeGeneration.Attributes;

namespace _Core_.Common.Components
{
    [Game]
    public sealed class HashCodeComponent : IComponent
    {
        [PrimaryEntityIndex] public int value;
    }
}