using _Core_.ObjectPool.Interfaces;
using Entitas;
using Entitas.CodeGeneration.Attributes;

namespace _Core_.ObjectPool.Components
{
    [Game, Unique]
    public class CarPoolObjectComponent : IComponent
    {
        public ICarPoolObject value;
    }
}