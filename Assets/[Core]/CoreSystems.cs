using _Core_.Car;
using _Core_.GameManager;
using _Core_.Level;
using _Core_.ObjectPool;

namespace _Core_
{
    public sealed class CoreSystems : Feature
    {
        public CoreSystems(Contexts contexts)
        {
            Add(new ObjectPoolSystems(contexts));
            Add(new LevelSystems(contexts));
            Add(new GameManagerSystems(contexts));
            Add(new CarSystems(contexts));

            Add(new GameEventSystems(contexts));
            Add(new GameCleanupSystems(contexts));
        }
    }
}