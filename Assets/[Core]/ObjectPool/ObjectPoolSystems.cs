using Entitas;

namespace _Core_.ObjectPool
{
    public sealed class ObjectPoolSystems : Systems
    {
        public ObjectPoolSystems(Contexts contexts)
        {
            Add(new InitObjectPoolSystem(contexts));
            Add(new ActiveObjectsReactiveSystem(contexts));
        }
    }
}